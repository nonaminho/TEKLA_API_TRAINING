using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Solid;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using TSMUI = Tekla.Structures.Model.UI;
using TSG = Tekla.Structures.Geometry3d;

namespace App_testes_de_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            //TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
            TSMUI.Picker picker = new TSMUI.Picker();
            int facecount = 0;
            int loopcount = 0;

            Beam viga = picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_OBJECT, "Selecione OBjeto") as Beam;
            Solid solido = viga.GetSolid(); 
            FaceEnumerator faces = solido.GetFaceEnumerator();

            while (faces.MoveNext())
            {
                Face face = faces.Current;
                LoopEnumerator loops = face.GetLoopEnumerator();
                facecount++;
                double area = 0;

                while (loops.MoveNext())
                {
                    List<TSG.Point> pontosLoop = new List<TSG.Point>();
                    Loop loop = loops.Current;
                    VertexEnumerator vertexes = loop.GetVertexEnumerator();
                    loopcount++;
                    while(vertexes.MoveNext())
                    {
                        TSG.Point ponto = vertexes.Current;
                        if (!pontosLoop.Contains(ponto))
                            pontosLoop.Add(ponto);
                    }
                    double arealoop = Math.Abs(Distance.PointToPoint(pontosLoop[0], pontosLoop[1]) * Distance.PointToPoint(pontosLoop[1], pontosLoop[2]));
                    Console.WriteLine($"Área loop: {arealoop}");
                    if (arealoop > area) area = arealoop;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------");
                Console.WriteLine($"Area da face = {area}");
                Console.WriteLine("----------------------");
                Console.ResetColor();
            }
            Console.WriteLine($"Faces = {facecount}\nLoops = {loopcount}");
            
        }
    }
}
