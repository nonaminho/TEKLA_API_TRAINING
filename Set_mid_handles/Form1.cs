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
using TSM = Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using TSMUI = Tekla.Structures.Model.UI;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using System.Net.Http;
using Tekla.Structures.Drawing.UI;
using Tekla.Structures.Model.UI;
using System.Collections;


namespace Set_mid_handles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MidHandle_Click(object sender, EventArgs e)
        {
                Model model = new Model();

                TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
                ModelObjectEnumerator Selecionados = selector.GetSelectedObjects();


                if (Selecionados.GetSize() == 0)
                {
                    Operation.DisplayPrompt("Nenhum objeto selecionado");
                    return;
                }
                Beam beam = null;
                while (Selecionados.MoveNext())
                {
                    beam = Selecionados.Current as Beam;
                    if (beam != null)
                    {                    
                        ArrayList pontos = beam.GetCenterLine(false);
                        TSG.Point p1 = pontos[0] as TSG.Point;
                        TSG.Point p2 = pontos[1] as TSG.Point;

                        beam.StartPoint = p1;
                        beam.EndPoint = p2;

                        beam.Modify();
                    }
                }
                model.CommitChanges();
        }
    }
}
