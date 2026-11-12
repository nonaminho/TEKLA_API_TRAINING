using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using Tekla.Structures;
using Tekla.Structures.Model.Operations;

namespace Orientacao_nos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation.DisplayPrompt("Selecione os objetos.");
            int posInicial = Convert.ToInt16(textBox2.Text);
            try
            {
                string prefixo = textBox1.Text;
                if (check_NO.Checked)
                    textBox2.Text = Helper.NumerarNos(prefixo, posInicial);
                if (check_Angulo.Checked)
                    Helper.PreencherAngulo();
                Operation.DisplayPrompt("Concluido com sucesso.");
            }
            catch (Exception ex)
            {
                Operation.DisplayPrompt("Um erro ocorreu: " + ex.Message);
            }
        }
    }
}
