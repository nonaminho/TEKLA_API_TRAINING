using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Solid;
using TSM=Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using TSMUI = Tekla.Structures.Model.UI;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using System.Net.Http;
using Tekla.Structures.Drawing.UI;
using Tekla.Structures.Model.UI;




namespace App_testes_de_console
{
    internal class Program
    {

        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        Model model = new Model();
        //        Console.WriteLine("Selecione as peças");
        //        Console.ReadKey();

        //        TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
        //        ModelObjectEnumerator Selecionados = selector.GetSelectedObjects();


        //        if (Selecionados.GetSize() == 0)
        //        {
        //            Console.WriteLine("Nenhum objeto selecionado");
        //            continue;
        //        }
        //        Beam beam = null;
        //        while (Selecionados.MoveNext())
        //        {
        //            beam = Selecionados.Current as Beam;

        //            Assembly montagem = beam.GetAssembly();
        //            Console.WriteLine($"Montagem: {montagem.AssemblyNumber.Prefix}.{montagem.AssemblyNumber.StartNumber}");

        //            if (montagem.SetMainPart(beam))
        //            {
        //                Console.WriteLine("Montagem modificada");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Modificação Falhou");
        //            }
        //            montagem.Modify();
        //        }
        //        model.CommitChanges();

        //    }
        //}

        static void Main(string[] args)
        {

                Model model = new Model();
                Console.WriteLine("Nível Absoluto");
                double nivel = Convert.ToDouble(Console.ReadLine());

                TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
                ModelObjectEnumerator Selecionados = selector.GetSelectedObjects();


                if (Selecionados.GetSize() == 0)
                {
                    Console.WriteLine("Nenhum objeto selecionado");
                    return;
                }

                Beam beam = null;
                while (Selecionados.MoveNext())
                {
                    beam = Selecionados.Current as Beam;
                    beam.StartPoint = new Point(beam.StartPoint.X, beam.StartPoint.Y, nivel);
                    beam.EndPoint = new Point(beam.EndPoint.X, beam.EndPoint.Y, nivel);
                    beam.Modify();
                }
                Console.WriteLine("Vigas Ajustadas");
                model.CommitChanges();
            
        }


        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        Model model = new Model();
        //        Console.WriteLine("Selecione as peças");
        //        Console.ReadKey();

        //        TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
        //        ModelObjectEnumerator Selecionados = selector.GetSelectedObjects();


        //        if (Selecionados.GetSize() == 0)
        //        {
        //            Console.WriteLine("Nenhum objeto selecionado");
        //            continue;
        //        }
        //        Beam beam = null;
        //        while (Selecionados.MoveNext())
        //        {
        //            beam = Selecionados.Current as Beam;

        //            Assembly montagem = beam.GetAssembly();
        //            Console.WriteLine($"Montagem: {montagem.AssemblyNumber.Prefix}.{montagem.AssemblyNumber.StartNumber}");

        //            if (montagem.SetMainPart(beam))
        //            {
        //                Console.WriteLine("Montagem modificada");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Modificação Falhou");
        //            }
        //            montagem.Modify();
        //        }
        //        model.CommitChanges();

        //    }
        //}
    }
}