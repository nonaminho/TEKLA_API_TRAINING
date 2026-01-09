using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.DialogInternal;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Model;
using System.Collections;
using Tekla.Structures.Geometry3d;
using T3D = Tekla.Structures.Geometry3d;

namespace BeamCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string profile = text_Profile.Text.ToUpper();
            string material = text_Material.Text.ToUpper();

            if (profile == "")
            {
                profile = "W250X17.9";
            }
            if (material =="")
            {
                material = "A572-GR.50";
            }

            Model model = new Model();

            Picker picker = new Picker();

            bool keepGoing = true;

            while (keepGoing)
            {
                try
                {
                    ArrayList PickedPoints = picker.PickPoints(Picker.PickPointEnum.PICK_TWO_POINTS);

                    if (PickedPoints.Count >= 2)
                    {
                        T3D.Point startPoint = (T3D.Point)PickedPoints[0];
                        T3D.Point finalPoint = (T3D.Point)PickedPoints[1];

                        Beam teklaBeam = new Beam();
                        teklaBeam.StartPoint = startPoint;
                        teklaBeam.EndPoint = finalPoint;
                        teklaBeam.Profile.ProfileString = profile;
                        teklaBeam.Material.MaterialString = material;
                        teklaBeam.AssemblyNumber.StartNumber = 1000;
                        teklaBeam.Class = "4";
                        teklaBeam.Finish = "Something";
                        teklaBeam.Insert();

                        model.CommitChanges();
                    }
                    else
                    {
                        keepGoing = false;
                    }
                }
                catch (Exception ex)
                {
                    Tekla.Structures.Model.Operations.Operation.DisplayPrompt("ERROR: " + ex.Message);
                    break;
                }
            }
        }
    }
}
