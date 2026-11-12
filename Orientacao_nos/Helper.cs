using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using Tekla.Structures;
using System.Windows.Forms;

namespace Orientacao_nos
{
    internal static class Helper
    {
        internal static void PreencherAngulo()
        {
            Model model = new Model();
            ModelObjectEnumerator selecao = new Tekla.Structures.Model.UI.ModelObjectSelector().GetSelectedObjects();

            while (selecao.MoveNext())
            {
                Beam coluna = selecao.Current as Beam;
                if (coluna == null) continue;
                Vector eixoYGlobal = new Vector(0, 1, 0);
                Vector localY = coluna.GetCoordinateSystem().AxisY;
                double ang = eixoYGlobal.GetAngleBetween(localY)*180/Math.PI;
                if (ang >= 180)
                    ang -= 180;
                

                coluna.SetUserProperty("ROT_COL", ang);
            }
            model.CommitChanges();

        }


        internal static string NumerarNos(string prefix, int posInicial)
        {
            Model model = new Model();
            ModelObjectEnumerator selecao = new Tekla.Structures.Model.UI.ModelObjectSelector().GetSelectedObjects();

            int PosNo = posInicial;
            List<Beam> colunas = new List<Beam>();
            while (selecao.MoveNext())
            {
                Beam coluna = selecao.Current as Beam;
                if (coluna == null) continue;
                colunas.Add(coluna);
            }

            colunas = colunas.OrderBy(c => Math.Round(c.StartPoint.Y)).ThenBy(c => Math.Round(c.StartPoint.X)).ToList();

            for (int i = 0; i < colunas.Count; i++)
            {
                Beam coluna = colunas[i];
                string No = prefix + PosNo.ToString();
                coluna.SetUserProperty("NOLOCACAO", No);
                PosNo++;
            }
            
            model.CommitChanges();
            return PosNo.ToString();
        }
    }
}
