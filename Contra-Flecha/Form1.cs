using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tekla.Structures.Model.UI;
using TSMUI = Tekla.Structures.Model.UI;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;


namespace Contra_Flecha
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
        Picker picker = new Picker();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Camber_Click(object sender, EventArgs e)
        {
            string nomeContem = textBox_Nome.Text;
            int compMin = Convert.ToInt32(textBox_Comp.Text);

            ModelObjectEnumerator vigasSelecionadas = selector.GetSelectedObjects();

            Beam beam = null;
            bool erro = false;
            int contador = 0;

            while (vigasSelecionadas.MoveNext())
            {
                beam = vigasSelecionadas.Current as Beam;
                if (beam != null)
                {
                    if (beam.Name.Contains(nomeContem))
                    {                   
                        double comprimento = new Vector(beam.StartPoint - beam.EndPoint).GetLength();
                        if (comprimento >= compMin)
                        {
                            int contraFlecha = Convert.ToInt32(Math.Round(comprimento / 375));
                            bool status = beam.SetUserProperty("cambering", contraFlecha);

                            if (!status)
                            {
                                beam.Class = "2";
                                erro = true;
                            }
                            else contador++;
                        }
                        else { beam.SetUserProperty("cambering", 0.00); }
                    }
                }
            }
            if (!erro && contador!=0)
            { 
                MessageBox.Show("Contra-flecha definida.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Uma ou mais vigas apresentaram erro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                model.CommitChanges();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                Beam beam = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Selecione uma Viga") as Beam;
                textBox_Nome.Text = beam.Name;
            }
            catch
            {
                MessageBox.Show("Viga não selecionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
