using System;
using System.Windows.Forms;

namespace Practica1.Vistas.Listados
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sampleDatabaseDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sampleDatabaseDataSet.Clientes);

        }
    }
}
