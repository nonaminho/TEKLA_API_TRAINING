using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Datatype;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Solid;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using TSMUI=Tekla.Structures.Model.UI;
using TSG=Tekla.Structures.Geometry3d;
using System.Collections;


namespace BoltArray
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        TSMUI.Picker picker = new TSMUI.Picker();
        private static ArrayList ObjectList = new ArrayList();
        int nFaces = 0, nLoops = 0, nVerteces = 0;

        public Form1()
        {
            InitializeComponent();
            if (model.GetConnectionStatus())
            {
                Operation.DisplayPrompt("Modelo conectado!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tekla.Structures.Model.BoltArray BA = new Tekla.Structures.Model.BoltArray();
            ModelObject mo1 = picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_OBJECT, "Part to bolt to");
            Part part1 = mo1 as Part;

            ModelObject mo2 = picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_OBJECT, "Part to be bolted");
            Part part2 = mo2 as Part;

            if (part1 != null)
            {
                BA.PartToBeBolted = part2;
                BA.PartToBoltTo = part1;
                TSG.Point firstPoint = picker.PickPoint("Pick first point");
                TSG.Point secondPoint = picker.PickPoint("Pick second point");
                BA.FirstPosition = firstPoint;
                BA.SecondPosition = secondPoint;
                BA.BoltSize = 19.05;
                BA.BoltStandard = "A325N";
                BA.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
                BA.Length = 150;
                BA.ThreadInMaterial = BoltGroup.BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES;
                BA.Position.Depth = Position.DepthEnum.MIDDLE;
                BA.Position.Plane = Position.PlaneEnum.MIDDLE;
                BA.Position.Rotation = Position.RotationEnum.FRONT;
                BA.ExtraLength = 6.35;

                double dist = TSG.Distance.PointToPoint(firstPoint, secondPoint);
                int numberOfBolts = (int)(dist / 150);
                double offset = (dist - (numberOfBolts) * 150) / 2;

                BA.StartPointOffset.Dx = offset;

                for (int b = 0; b<numberOfBolts; b++)
                {
                    BA.AddBoltDistX(150);
                }

                BA.AddBoltDistY(100);

                if (!BA.Insert())
                {
                    MessageBox.Show("Insertion failed!");
                }

                

                model.CommitChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Beam beam = new Beam();
            beam.StartPoint = new TSG.Point(0, 0, 0);
            beam.EndPoint = new TSG.Point(3000, 0, 0);
            beam.Profile.ProfileString = "W250x17.9";
            beam.Material.MaterialString = "A36";
            beam.Insert();

            CutPlane cutPlane = new CutPlane();
            cutPlane.Plane.Origin = new TSG.Point(1000, 0, 0);
            cutPlane.Plane.AxisX = new TSG.Vector(0, 1, 0);
            cutPlane.Plane.AxisY = new TSG.Vector(0, 0, -10);
            cutPlane.Father = beam;
            cutPlane.Insert();

            Vector v1 = new Vector(1000,0,0);
            Vector v2 = new Vector(0, 1, 0);
            Vector v3 = v1.Cross(v2);

            model.CommitChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Weld weld = new Weld();
            ModelObject mo1 = picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_OBJECT, "First part to weld");
            Part part1 = mo1 as Part;
            ModelObject mo2 = picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_OBJECT, "First part to weld");
            Part part2 = mo2 as Part;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SolidTest();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ModelObjectSelector selector = model.GetModelObjectSelector();
            ModelObjectEnumerator objects = selector.GetAllObjectsWithType(ModelObject.ModelObjectEnum.CONTOURPLATE);
            

            foreach (ModelObject mo in objects)
            {
                ContourPlate cp = mo as ContourPlate;

                cp.Material.MaterialString = "A36";
                cp.Class = "99";
                cp.Name = "CHAPA";
                cp.Modify();

            }
            model.CommitChanges();
        }

        private Beam insertBeam()
        {
            TSG.Point startPoint = new TSG.Point(5000, 0, 0);
            TSG.Point endPoint = new TSG.Point(7000, 0, 0);
            Beam beam = new Beam(startPoint, endPoint);
            beam.Profile.ProfileString = "PL500*200";
            beam.Name = "SolidTestBeam";
            beam.Finish = "Normal";
            beam.Class = "5";

            if (!beam.Insert())
            {
                MessageBox.Show("Beam insertion failed!");
            }
            else
            {
                ObjectList.Add(beam);
            }
            model.CommitChanges();
            return beam;
        }

        private void SolidTest()
        {
            Beam beam = picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_OBJECT, "Selecione OBjeto") as Beam;


            Solid solid = beam.GetSolid();
            FaceEnumerator FaceEnum = solid.GetFaceEnumerator();

            

            while(FaceEnum.MoveNext())
            {
                nFaces++;
                Face face = FaceEnum.Current as Face;
                LoopEnumerator LoopEnum = face.GetLoopEnumerator();

                while (LoopEnum.MoveNext())
                {
                    nLoops++;
                    Loop loop = LoopEnum.Current as Loop;
                    VertexEnumerator vertexEnum = loop.GetVertexEnumerator();

                    while (vertexEnum.MoveNext())
                    {
                        nVerteces++;
                    }

                }
            }
            MessageBox.Show($"nFaces = {nFaces}, nLoops = {nLoops}, nVertexes = {nVerteces}");
            MessageBox.Show("BeamSolidTest Complete!");
        }
    }
}
