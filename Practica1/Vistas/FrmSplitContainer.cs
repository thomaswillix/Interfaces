using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.Vistas
{
    public partial class FrmSplitContainer : Form
    {
        public FrmSplitContainer()
        {
            InitializeComponent();
        }

        private void FrmSplitContainer_Load(object sender, EventArgs e)
        {
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.SplitterDistance = 42;
            splitContainer1.SplitterWidth = 25;
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
