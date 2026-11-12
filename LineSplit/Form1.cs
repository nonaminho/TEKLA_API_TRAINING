using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model.UI;
using TSMUI = Tekla.Structures.Model.UI;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using T3D = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.Operations;

namespace LineSplit
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        Picker picker = new Picker();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Cut_Click(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    T3D.Point ponto1 = picker.PickPoint("Selecione o primeiro ponto.");
                    T3D.Point ponto2 = picker.PickPoint("Selecione o segundo ponto.");
                    Line cutline = new Line(ponto1, ponto2);


                TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
                ModelObjectEnumerator selectedObjects = selector.GetSelectedObjects();

                Beam beam = null;
                while (selectedObjects.MoveNext())
                {
                    beam = selectedObjects.Current as Beam;
                    if (beam != null)
                    {
                        Line beamline = new Line(beam.StartPoint, beam.EndPoint);
                        T3D.Point cutPoint = Intersection.LineToLine(beamline, cutline).Point1;
                        Beam newbeam = Operation.Split(beam, cutPoint);
                    }
                }
                model.CommitChanges();
                }
                catch (Exception ex)
                {
                    Operation.DisplayPrompt("User Cancel");
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Beam vigaPrincipal = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Selecione a viga principal.") as Beam;

            Line cutline = new Line(vigaPrincipal.StartPoint, vigaPrincipal.EndPoint);
            TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
            ModelObjectEnumerator selectedObjects = selector.GetSelectedObjects();

            Beam beam = null;
            while (selectedObjects.MoveNext())
            {
                beam = selectedObjects.Current as Beam;
                if (beam != null)
                {
                    Line beamline = new Line(beam.StartPoint, beam.EndPoint);
                    T3D.Point cutPoint = Intersection.LineToLine(beamline, cutline).Point1;
                    Beam newbeam = Operation.Split(beam, cutPoint);
                }
            }
            model.CommitChanges();
        }
    }
}
