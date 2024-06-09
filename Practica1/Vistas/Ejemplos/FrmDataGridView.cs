using Practica1.Manejadores;
using Practica1.Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica1.Vistas.Ejemplos
{
    public partial class FrmDataGridView : Form
    {
        public FrmDataGridView()
        {
            InitializeComponent();
        }

        private void FrmDataGridView_Load(object sender, EventArgs e)
        {
            ControladorProyectosBin.cargarProyectos();
            dataGridView3.DataSource = ControladorProyectosBin.listaProyectos;
            // TODO: esta línea de código carga datos en la tabla 'sampleDatabaseDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.sampleDatabaseDataSet.Customers);
            // TODO: esta línea de código carga datos en la tabla 'sampleDatabaseDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.sampleDatabaseDataSet.Orders);

            // Permitir la edición de celdas
            dataGridView1.ReadOnly = false;

            // Cambiar el color de fondo de las celdas seleccionadas
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Magenta;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Chocolate;

            // Agregar una columna programáticamente
            DataGridViewTextBoxColumn nuevaColumna = new DataGridViewTextBoxColumn();
            nuevaColumna.HeaderText = "Columna añadida mediante código";
            dataGridView3.Columns.Add(nuevaColumna);


            // Establecer el estilo de una celda condicionalmente
            if (Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value) > 10)
            {
                dataGridView2.Rows[0].Cells[3].Style.BackColor = Color.Red;
            }

            Database.CargarDatosEspecificosDataGridView(dataGridView4); //Obtiene solo el id y el estado de los proyectos.

            dataGridView5.DataSource = Database.Obtener(); //Obtiene todos los datos de la tabla Customers

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if(dataGridView1.)
        }
    }
}
