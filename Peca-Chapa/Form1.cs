using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Solid;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using TSMUI = Tekla.Structures.Model.UI;
using TSG = Tekla.Structures.Geometry3d;
using System.Collections;
using Tekla.Structures.Catalogs;

namespace Peca_Chapa
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        TSMUI.Picker picker = new TSMUI.Picker();
        TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Converter_Click(object sender, EventArgs e)
        {
            WorkPlaneHandler workPlaneHandler = model.GetWorkPlaneHandler();
            TransformationPlane current = workPlaneHandler.GetCurrentTransformationPlane();
            ModelObjectEnumerator objetos = selector.GetSelectedObjects();
            if (!double.TryParse(textBox_Raio.Text, out double raio)) // Tenta a conversão do texto em double
            {                                                         // out double raio é a variavel de saída
                raio = 6.0;                                           // Caso a conversão falhe. Default para 6mm
            }

            if (!double.TryParse(textBox_Espessura.Text, out double espessuradef))
            {
                espessuradef = 0.0;
            }

            while (objetos.MoveNext())
            { 
                Beam cantoneira = objetos.Current as Beam;

                //Verifica trabalho com cantoneiras
                if (cantoneira == null)
                {
                    continue;
                }
                if (cantoneira.Name != "CANTONEIRA")
                {
                    continue;
                }
                //Fim da verificação

                //Cria UCS para manter cantoneiras alinhadas e com chapas para o lado correto
                CoordinateSystem CS = cantoneira.GetCoordinateSystem();
                TransformationPlane partTP = new TransformationPlane(CS);
                workPlaneHandler.SetCurrentTransformationPlane(partTP);

                //Verifica a existência de parafusos e coleta esses dados
                ModelObjectEnumerator Paraf = cantoneira.GetBolts();

                //Definição das propriedades da chapa dobrada que será criada
                string espessura = cantoneira.Profile.ProfileString.Split('X')[1];
                double esp = Convert.ToDouble(espessura);
                if (espessuradef != 0.0) esp = espessuradef;
                string classe = cantoneira.Class.ToString();
                string Nome = "CANTONEIRA";
                string PartPos = "Pos";
                int partStart = 1;
                string AssemPos = "L";
                int AssemStart = 1;

                //Pega o solido da peça > Pega as faces e armazena as 2 maiores
                //A partir das faces, pega o loop e então os pontos
                //Cria 2 chapas, uma em cada face
                //A partir dessas chapas, cria uma bentplate
                Solid cantSolid = cantoneira.GetSolid();
                FaceEnumerator faces = cantSolid.GetFaceEnumerator();
                Dictionary<Face, double> facesDict = new Dictionary<Face, double>();
                double maxArea = 0;
                while (faces.MoveNext())
                {
                    Face face = faces.Current;
                    double area = GetArea(face);
                    Console.WriteLine(face + " - " + area);
                    if (area > maxArea) maxArea = area;

                    facesDict[face] = area;
                }
                List<Face> facesconvert = new List<Face>();
                foreach(var face in facesDict)
                {
                    if (Convert.ToInt32(face.Value) == Convert.ToInt32(maxArea))
                    {
                        facesconvert.Add(face.Key);
                    }
                }
                Console.WriteLine(facesconvert.Count);
                List<Part> chapas = new List<Part>();
                foreach (var face in facesconvert)
                {

                    Console.WriteLine("------------------------------------");
                    ContourPlate cp = new ContourPlate();
                    var loopenum = face.GetLoopEnumerator();
                    while (loopenum.MoveNext())
                    {
                        Loop loop = loopenum.Current;
                        var pontos = loop.GetVertexEnumerator();
                        while (pontos.MoveNext())
                        {
                            TSG.Point ponto = pontos.Current as TSG.Point;
                            cp.AddContourPoint(new ContourPoint(ponto, null));
                        }
                        Console.WriteLine("----------------------------------");
                    }
                    cp.Profile.ProfileString = $"CH{espessura}";
                    cp.Material.MaterialString = "A36";
                    cp.Name = "CANTONEIRA";
                    cp.Position.Depth = Position.DepthEnum.FRONT;
                    cp.AssemblyNumber.Prefix = "L";
                    cp.AssemblyNumber.StartNumber = 1;

                    cp.Insert();
                    chapas.Add(cp);
                }
                //Cria e altera as propriedades da BentPate 
                BentPlate bp = Operation.CreateBentPlateByParts(chapas[0], chapas[1], raio);
                bp.Class = classe;
                bp.Name = Nome;
                bp.AssemblyNumber.Prefix = AssemPos;
                bp.AssemblyNumber.StartNumber=AssemStart;
                bp.PartNumber.Prefix = PartPos;
                bp.PartNumber.StartNumber = partStart;
                bp.Modify();

                //Caso exita parafusos, atualiza a peça a ser parafusada
                while (Paraf.MoveNext())
                {
                    BoltArray paraf = Paraf.Current as BoltArray;
                    paraf.PartToBeBolted = bp;
                    paraf.Modify();
                }

                //exclui a peça original
                cantoneira.Delete();
            }
            //retorna o CS para o que estava anteriormente
            workPlaneHandler.SetCurrentTransformationPlane(current);
            model.CommitChanges();
        }

        private double GetArea(Face face)
            //Retorna a área de uma face
        {
            double area = 0;
            LoopEnumerator loops = face.GetLoopEnumerator();
            while (loops.MoveNext())
            {
                Loop perimetro = loops.Current;
                VertexEnumerator vertexes = perimetro.GetVertexEnumerator();
                List<TSG.Point> pontos = new List<TSG.Point>();
                while(vertexes.MoveNext())
                {
                    pontos.Add(vertexes.Current as TSG.Point);
                }

                double areapre = Distance.PointToPoint(pontos[0], pontos[1]) * Distance.PointToPoint(pontos[1], pontos[2]);
                if (areapre > area) area = areapre;
            }

            return area;
        }
    }

}
