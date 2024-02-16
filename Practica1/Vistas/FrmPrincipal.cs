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
using Practica1.Vistas.Ejemplos;
using Practica1.Vistas.Listados;

namespace Practica1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            //Mensaje personalizado para la pestaña principal.
            label2.Text += " " +Usuario.u.User;

            logsToolStripMenuItem.Visible = false;
            if (Usuario.u.EsAdmin)
            {
                logsToolStripMenuItem.Visible = true;
            }
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
            folderBrowserDialog.ShowDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FrmLogs logs = new FrmLogs();
                //propiedad pública del formulario log
                logs.directorio = folderBrowserDialog.SelectedPath;
                logs.ShowDialog();
            }
        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComponentesProyectos componentes = new FrmComponentesProyectos();
            componentes.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe acercaDe = new FrmAcercaDe();
            acercaDe.ShowDialog();
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSplitContainer splitCon = new FrmSplitContainer();
            splitCon.ShowDialog();
        }

        private void flowLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFlowLayout flowLayout = new FrmFlowLayout();
            flowLayout.ShowDialog();
        }

        private void tableLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTableLayout tableLayout = new FrmTableLayout();
            tableLayout.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImprimir imprimir  = new FrmImprimir();
            imprimir.ShowDialog();
        }

        private void mDIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasarParamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EjemploPasarParametros.FormularioOrigen origen = new EjemploPasarParametros.FormularioOrigen();
            origen.ShowDialog();
        }

        private void dataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataGridView gridView = new FrmDataGridView();
            gridView.ShowDialog();
        }

        private void dataGridViewsBBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProyectosConDataGridView frmProyectos = new FrmProyectosConDataGridView();
            frmProyectos.ShowDialog();
        }
    }

}
