using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Drawing.UI;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using Tekla.Structures.Model.UI;
using T3D = Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;



namespace HandleAlign
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        TSMUI.Picker picker = new TSMUI.Picker();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Alinhar_Click(object sender, EventArgs e)
        {
            TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
            ModelObjectEnumerator selectedObjects = selector.GetSelectedObjects();

            if (selectedObjects.GetSize() == 0)
            {
                MessageBox.Show("Selecione pelo menos um objeto.");
                return;
            }

            T3D.Point ponto1 = picker.PickPoint("Selecione o primeiro ponto.");
            T3D.Point ponto2 = picker.PickPoint("Selecione o segundo ponto.");
            Line alignLine = new Line(ponto1, ponto2);

            int count = 0;
            Beam beam = null;


            while (selectedObjects.MoveNext())
            {
                beam = selectedObjects.Current as Beam;
                if (beam != null)
                {
                    double pZ = beam.StartPoint.Z;
                    T3D.Point p1 = Projection.PointToLine(beam.StartPoint, alignLine);
                    T3D.Point p2 = Projection.PointToLine(beam.EndPoint, alignLine);
                    beam.StartPoint = new T3D.Point(p1.X, p1.Y, pZ);
                    beam.EndPoint = new T3D.Point(p2.X, p2.Y, pZ);
                    if (!beam.Modify())
                    {
                        count++;
                    }
                }
            }
            model.CommitChanges();
            if (count > 0)
            {
                MessageBox.Show("Não foi possível alinhar " + count + " objetos.");
            }
            else
            {
                MessageBox.Show("Objetos alinhados com sucesso.");
            }
        }

        private void button_colAlign_Click(object sender, EventArgs e)
        {
            double tolerancia = textBox1.Text != "" ? Convert.ToDouble(textBox1.Text) : 10.0;
            TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
            ModelObjectEnumerator selectedObjects = selector.GetSelectedObjects();
            if (selectedObjects.GetSize() == 0)
            {
                MessageBox.Show("Selecione pelo menos uma viga e uma coluna.");
                return;
            }

            int count = 0;
            List<Beam> colunas = new List<Beam>();
            List<Beam> vigas = new List<Beam>();
            Beam peca = null;
            while (selectedObjects.MoveNext())
            {
                peca = selectedObjects.Current as Beam;
                if (peca != null)
                {
                    if (peca.Name.ToUpper().Contains("COLUNA"))
                    {
                        colunas.Add(peca);
                    }
                    else if (peca.Name.ToUpper().Contains("VIGA"))
                    {
                        vigas.Add(peca);
                    }
                }
            }

            foreach (Beam coluna in colunas)
            {
                Line col = new Line(coluna.StartPoint, coluna.EndPoint);
                foreach (Beam viga in vigas)
                {
                    double dist1 = Distance.PointToLine(viga.StartPoint, col);
                    double dist2 = Distance.PointToLine(viga.EndPoint, col);
                    if (dist1 <= tolerancia)
                    {
                        T3D.Point p1 = Projection.PointToLine(viga.StartPoint, col);
                        viga.StartPoint = new T3D.Point(p1.X, p1.Y, viga.StartPoint.Z);
                        if (!viga.Modify())
                        {
                            count++;
                        }
                    }
                    else if (dist2 <= tolerancia)
                    {
                        T3D.Point p1 = Projection.PointToLine(viga.StartPoint, col);
                        viga.EndPoint = new T3D.Point(p1.X, p1.Y, viga.StartPoint.Z);
                        if (!viga.Modify())
                        {
                            count++;
                        }
                    }
                }
            }
            model.CommitChanges();
            if (count > 0)
            {
                MessageBox.Show("Não foi possível alinhar " + count + " objetos.");
            }
            else
            {
                MessageBox.Show("Objetos alinhados com sucesso.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
            ModelObjectEnumerator selectedObjects = selector.GetSelectedObjects();

            if (selectedObjects.GetSize() == 0)
            {
                MessageBox.Show("Selecione pelo menos um objeto.");
                return;
            }

            T3D.Point ponto = picker.PickPoint("Selecione o primeiro ponto.");
            T3D.Vector z = new Vector(0, 0, 1);
            Line alignLine = new Line(ponto, z);

            double tolerancia = textBox1.Text != "" ? Convert.ToDouble(textBox1.Text) : 10.0;
            int count = 0;

            Beam viga = null;

            while (selectedObjects.MoveNext())
            {
                viga = selectedObjects.Current as Beam;
                if (viga != null)
                {
                    double dist1 = Distance.PointToLine(viga.StartPoint, alignLine);
                    double dist2 = Distance.PointToLine(viga.EndPoint, alignLine);

                    if (dist1 <= tolerancia)
                    {
                        T3D.Point p1 = Projection.PointToLine(viga.StartPoint, alignLine);
                        viga.StartPoint = new T3D.Point(p1.X, p1.Y, viga.StartPoint.Z);
                        if (!viga.Modify())
                        {
                            count++;
                        }
                    }
                    if (dist2 <= tolerancia)
                    {
                        T3D.Point p1 = Projection.PointToLine(viga.StartPoint, alignLine);
                        viga.EndPoint = new T3D.Point(p1.X, p1.Y, viga.EndPoint.Z);
                        if (!viga.Modify())
                        {
                            count++;
                        }
                    }
                }

            }
            model.CommitChanges();

            if (count > 0)
            {
                MessageBox.Show("Não foi possível alinhar " + count + " objetos.");
            }
            else
            {
                MessageBox.Show("Objetos alinhados com sucesso.");
            }
        }
    }

}
