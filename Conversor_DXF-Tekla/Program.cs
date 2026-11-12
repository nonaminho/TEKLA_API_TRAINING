using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netDxf;
using netDxf.Entities;


namespace Conversor_DXF_Tekla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caminho do arquivo: ");
            string caminho = Console.ReadLine();

            DxfDocument arquivo = DxfDocument.Load(caminho);
            int linhas= 0;
            foreach (EntityObject entidade in arquivo.Lines)
            {
                Line enti = entidade as Line;
                Console.WriteLine(enti.CodeName);
                Console.WriteLine(enti.Layer.Name);
                Console.WriteLine($"Ponto Inicial: {enti.StartPoint.X}, {enti.StartPoint.Y}, {enti.StartPoint.Z}");
                Console.WriteLine($"Ponto Final: {enti.EndPoint.X}, {enti.EndPoint.Y}, {enti.EndPoint.Z}");
                Console.WriteLine();
                linhas++;
            }
            int arcos = 0;
            foreach (EntityObject entidade in arquivo.Arcs)
            {
                Arc enti = entidade as Arc;
                Console.WriteLine(enti.CodeName);
                Console.WriteLine(enti.Layer.Name);
                Console.WriteLine($"Centro: {enti.Center.X}, {enti.Center.Y}, {enti.Center.Z}");
                Console.WriteLine($"Raio: {enti.Radius}");
                Console.WriteLine();
                arcos++;
            }

            Console.WriteLine(linhas);
            Console.WriteLine(arcos);

        }

    }
}
