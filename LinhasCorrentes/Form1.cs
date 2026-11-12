using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Drawing.UI;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using T3D = Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;


namespace LinhasCorrentes
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        TSMUI.Picker picker = new TSMUI.Picker();
        WorkPlaneHandler wph;
        TransformationPlane OPlane;
        public Form1()
        {
            InitializeComponent();
            wph = model.GetWorkPlaneHandler();
            OPlane = wph.GetCurrentTransformationPlane();
        }

        private void btn_LCR_Click(object sender, EventArgs e)
        {
            try
            {
                //Seleciona as peças (terças)
                ModelObjectEnumerator MOtercas = picker.PickObjects(TSMUI.Picker.PickObjectsEnum.PICK_N_OBJECTS, "Selecione as terças");

                //Essa parte ordena as peças em relação a Y decrescente
                List<Beam> tercas = new List<Beam>();
                while (MOtercas.MoveNext())
                {
                    Beam beam = MOtercas.Current as Beam;
                    if (beam != null)
                    {
                        tercas.Add(beam);
                    }
                }
                var tercasOrdenadas = tercas.OrderByDescending(t => t.StartPoint.Y);
                //termina de ordenar

                //Define a terça principal, a que inicia a linha de corrente
                Beam principal = tercasOrdenadas.First();
                Line linha = new Line(principal.StartPoint, principal.EndPoint);
                double comprimento = Distance.PointToPoint(principal.StartPoint, principal.EndPoint);
                double distCorrentes = Convert.ToDouble(text_DistCorrentes.Text);
                int numCorrentes = (int)Math.Ceiling(comprimento / distCorrentes) - 1;
                double distCorrigido = comprimento / (numCorrentes + 1);
                label_Correntes.Text = $"Correntes: {numCorrentes}";
                T3D.Vector delta = new Vector(1, 0, 0) * distCorrigido;

                Beam[] tercasArray = tercasOrdenadas.ToArray();
                for (int i = 0; i < tercasArray.Length - 1; i++)
                {
                    T3D.Point p1 = tercasArray[i].StartPoint;
                    T3D.Point p2 = tercasArray[i + 1].StartPoint;
                    p1.Z = 0; p2.Z = 0; //Zera o eixo Z dos pontos

                    for (int j = 1; j <= numCorrentes; j++)
                    {
                        Beam corrente = new Beam();
                        corrente.StartPoint = p1 + delta * j;
                        corrente.EndPoint = p2 + delta * j;
                        corrente.Name = "CORRENTE_RIGIDA";
                        corrente.Profile.ProfileString = "U75X40X2";
                        corrente.Material.MaterialString = "ZAR-345";
                        corrente.Class = "21";
                        corrente.PartNumber.Prefix = "Pos";
                        corrente.PartNumber.StartNumber = 1;
                        corrente.AssemblyNumber.Prefix = "LCR";
                        corrente.AssemblyNumber.StartNumber = 1;
                        corrente.Position.Depth = Position.DepthEnum.MIDDLE;
                        corrente.Insert();
                    }

                }

                model.CommitChanges();
            }
            catch (Exception ex)
            {
                Operation.DisplayPrompt("Cancelado pelo Usuário");
            }
        }

        private void btn_UCS_Click(object sender, EventArgs e)
        {
            Beam principal = picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_OBJECT, "Selecione a viga superior") as Beam;
            double comprimento = Distance.PointToPoint(principal.StartPoint, principal.EndPoint);
            double distCorrentes = Convert.ToDouble(text_DistCorrentes.Text);
            int numCorrentes = (int)Math.Ceiling(comprimento / distCorrentes) - 1;
            CoordinateSystem ucsTerca = principal.GetCoordinateSystem();
            CoordinateSystem ucsTercas = new CoordinateSystem(ucsTerca.Origin, ucsTerca.AxisX, ucsTerca.AxisX.Cross(ucsTerca.AxisY));
            wph.SetCurrentTransformationPlane(new TransformationPlane(ucsTercas));
            label_Correntes.Text = $"Correntes: {numCorrentes}";
        }
    }
}
