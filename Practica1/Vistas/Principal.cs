using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1.Vistas;

namespace Practica1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Mensaje personalizado para la pestaña principal.
            label2.Text += " " +Usuario.u.User;

            logsToolStripMenuItem.Visible = false;
            if (Usuario.u.EsAdmin)
            {
                logsToolStripMenuItem.Visible = true;
            }
        }
        private void Principal_FormClosing(object sender,FormClosingEventArgs e)
        {
        }
        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProyectos Form = new FrmProyectos();
            Form.ShowDialog();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmNuevoProyecto proy = new FrmNuevoProyecto();
            proy.ShowDialog();
        }

        private void listadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmpleados listaEmpl = new FrmEmpleados();
            listaEmpl.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNuevoEmpleado empl = new FrmNuevoEmpleado();
            empl.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            nuevoCliente.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = ".";
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
