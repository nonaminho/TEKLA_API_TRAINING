using System;
using System.Windows.Forms;
using Tekla.Structures.Geometry3d;
using TSG=Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using System.Collections;

namespace Create_Spaced_Beams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Criar_Click(object sender, EventArgs e)
        {
            string Perfil = textBox_Perfil.Text;
            int quantidade = int.Parse(textBox_QTD.Text);
            string material = "A36";
            
            Model model = new Model();
            Picker picker = new Picker();

            ArrayList pontos1 = picker.PickPoints(Picker.PickPointEnum.PICK_TWO_POINTS, "Selecione os pontos iniciais");
            ArrayList pontos2 = picker.PickPoints(Picker.PickPointEnum.PICK_TWO_POINTS, "Selecione os pontos finais");
            TSG.Point p1 = (TSG.Point)pontos1[0];
            TSG.Point p2 = (TSG.Point)pontos1[1];
            TSG.Point p3 = (TSG.Point)pontos2[0];
            TSG.Point p4 = (TSG.Point)pontos2[1];
            double delta = 1.0 / (quantidade+1);
            TSG.Vector deltaL1 = new Vector(p2 - p1) * delta;
            TSG.Vector deltaL2 = new Vector(p4 - p3) * delta;

            for (int i = 1; i <= quantidade; i++)
            {
                Beam viga = new Beam();
                viga.StartPoint = p1 + deltaL1 * i;
                viga.EndPoint = p3 + deltaL2 * i;
                viga.Profile.ProfileString = Perfil;
                viga.Material.MaterialString = material;
                viga.Class = "5";
                viga.Insert();
            }
            model.CommitChanges();

        }
    }
}
