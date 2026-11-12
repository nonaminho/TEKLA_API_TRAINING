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
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Solid;
using TSM = Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using TSMUI = Tekla.Structures.Model.UI;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Drawing.UI;
using Tekla.Structures.Model.UI;

namespace QuickModify
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        TSMUI.Picker picker = new TSMUI.Picker();
        Dictionary<string, string> perfis = new Dictionary <string, string>
        {
            { "L51*3", "L51X3.2" },
            { "L76*6", "L76X6.4" },
            { "L51*5", "L51X4.8" },
            { "L89*8", "L89*89*7.9" },
            { "L102*8", "102X7.9" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },
            { "L51*3", "L51X3.18" },

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSMUI.ModelObjectSelector selector = new TSMUI.ModelObjectSelector();
            ModelObjectEnumerator selectedObjects = selector.GetSelectedObjects();

        }
    }
}
