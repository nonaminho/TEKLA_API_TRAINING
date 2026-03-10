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
using TSG=Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.UI;
using System.Collections;

namespace ContourPlate
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        Picker picker = new Picker();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!model.GetConnectionStatus())
            {
                MessageBox.Show("Tekla Structures is not running.");
                return;
            }
            ArrayList pickedPoints = new ArrayList();
            pickedPoints = picker.PickPoints(Picker.PickPointEnum.PICK_POLYGON, "Pick points for contour plate");

            

            ArrayList contourPoints = new ArrayList();
            foreach (TSG.Point point in pickedPoints)
            {
                ContourPoint contourPoint = new ContourPoint(point, new Chamfer());
                contourPoints.Add(contourPoint);
            }

            Tekla.Structures.Model.ContourPlate cP= new Tekla.Structures.Model.ContourPlate();
            cP.Contour.ContourPoints = contourPoints;
            cP.Material.MaterialString = "A36";
            cP.Profile.ProfileString = "CH10";
            cP.Insert();

            model.CommitChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!model.GetConnectionStatus())
            {
                MessageBox.Show("Tekla Structures is not running.");
                return;
            }
            ArrayList pickedPoints = new ArrayList();
            pickedPoints = picker.PickPoints(Picker.PickPointEnum.PICK_POLYGON, "Pick points for contour plate");

            ArrayList contourPoints = new ArrayList();
            foreach (TSG.Point point in pickedPoints)
            {
                ContourPoint contourPoint = new ContourPoint(point, new Chamfer());
                contourPoints.Add(contourPoint);
            }

            PolyBeam polyBeam = new PolyBeam();
            polyBeam.Contour.ContourPoints = contourPoints;
            polyBeam.Material.MaterialString = "A36";
            polyBeam.Profile.ProfileString = "W250x17.9";
            polyBeam.Insert();

            model.CommitChanges();
        }
    }
}
