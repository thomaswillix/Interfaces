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
    public partial class FrmFlowLayout : Form
    {
        public FrmFlowLayout()
        {
            InitializeComponent();
        }

        private void FrmFlowLayout_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
        }
    }
}
