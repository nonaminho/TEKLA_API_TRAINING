using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Tekla.Structures.DialogInternal;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using T3D = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.Operations;

namespace Rotate_with_reference
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        Picker picker = new Picker();

        public Form1()
        {
            InitializeComponent();

            T3D.Point origem = new T3D.Point();
            T3D.Point referencia = new T3D.Point();
            T3D.Point destino = new T3D.Point();

            origem = picker.PickPoint("Selecione o ponto de Origem");
            textBox_OrigemX.Text = origem.X.ToString();
            textBox_OrigemY.Text = origem.Y.ToString();
            textBox_OrigemZ.Text = origem.Z.ToString();

            referencia = picker.PickPoint("Selecione o ponto de Referência");
            textBox_RefX.Text = referencia.X.ToString();
            textBox_RefY.Text = referencia.Y.ToString();
            textBox_RefZ.Text = referencia.Z.ToString();

            destino = picker.PickPoint("Selecione o ponto de Destino");
            textBox_DestX.Text = destino.X.ToString();
            textBox_DestY.Text = destino.Y.ToString();
            textBox_DestZ.Text = destino.Z.ToString();
        }

        private void button_Origem_Click(object sender, EventArgs e)
        {

            T3D.Point point = picker.PickPoint("Selecione o ponto de Origem");

            textBox_OrigemX.Text = point.X.ToString();
            textBox_OrigemY.Text = point.Y.ToString();
            textBox_OrigemZ.Text = point.Z.ToString();

        }

        private void button_Ref_Click(object sender, EventArgs e)
        {
            T3D.Point point = picker.PickPoint("Selecione o ponto de Referência");

            textBox_RefX.Text = point.X.ToString();
            textBox_RefY.Text = point.Y.ToString();
            textBox_RefZ.Text = point.Z.ToString();
        }

        private void button_Dest_Click(object sender, EventArgs e)
        {
            T3D.Point point = picker.PickPoint("Selecione o ponto de Destino");

            textBox_DestX.Text = point.X.ToString();
            textBox_DestY.Text = point.Y.ToString();
            textBox_DestZ.Text = point.Z.ToString();
        }

        private void button_Rotate_Click(object sender, EventArgs e)
        {
            T3D.Point origem = new T3D.Point(Convert.ToDouble(textBox_OrigemX.Text), Convert.ToDouble(textBox_OrigemY.Text), Convert.ToDouble(textBox_OrigemZ.Text));
            T3D.Point refPonto = new T3D.Point(Convert.ToDouble(textBox_RefX.Text), Convert.ToDouble(textBox_RefY.Text), Convert.ToDouble(textBox_RefZ.Text));
            T3D.Point destPonto = new T3D.Point(Convert.ToDouble(textBox_DestX.Text), Convert.ToDouble(textBox_DestY.Text), Convert.ToDouble(textBox_DestZ.Text));

            Vector refVetor = new Vector(refPonto.X - origem.X, refPonto.Y - origem.Y, refPonto.Z - origem.Z);
            Vector destVetor = new Vector(destPonto.X - origem.X, destPonto.Y - origem.Y, destPonto.Z - origem.Z);
            Vector eixoRotacao = refVetor.Cross(destVetor);
            eixoRotacao.Normalize();

            ModelObjectEnumerator objetos = picker.PickObjects(new Picker.PickObjectsEnum(), "Selecione os objetos para rotacionar");

            double angle = refVetor.GetAngleBetween(destVetor);
            //label_angle.Text = (180 * angle / Math.PI).ToString() + " - " + objetos.GetSize().ToString();

            Matrix matrizRotacao = MatrixFactory.Rotate(angle, eixoRotacao);
            CoordinateSystem original = new CoordinateSystem(origem, refVetor, eixoRotacao);
            CoordinateSystem moved = new CoordinateSystem(origem, destVetor, eixoRotacao); ;

            ArrayList objetosArray = new ArrayList();
            while (objetos.MoveNext())
            {
                objetosArray.Add(objetos.Current);
            }

            foreach (ModelObject obj in objetosArray)
            {
                Operation.MoveObject(obj, original, moved);
            }
            model.CommitChanges();
        }
    }
}
