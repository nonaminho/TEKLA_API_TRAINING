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
            Model model = new Model();

            Beam teklaBeam = new Beam();
            teklaBeam.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0, 0);
            teklaBeam.EndPoint = new Tekla.Structures.Geometry3d.Point(6000, 0, 0);
            teklaBeam.Profile.ProfileString = text_Profile.Text;
            teklaBeam.Material.MaterialString = text_Material.Text;
            teklaBeam.AssemblyNumber.StartNumber = 1000;
            teklaBeam.Class = "4";
            teklaBeam.Finish = "Oi";
            teklaBeam.Insert();
                        
            model.CommitChanges();
        }
    }
}
