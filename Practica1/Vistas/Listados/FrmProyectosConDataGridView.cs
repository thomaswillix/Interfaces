using Practica1.Modelo;
using System;
using System.Windows.Forms;

namespace Practica1.Vistas.Listados
{
    public partial class FrmProyectosConDataGridView : Form
    {
        // Crear una instancia de tu controlador de base de datos


        public FrmProyectosConDataGridView()
        {
            InitializeComponent();
        }

        private void FrmProyectosConDataGridView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sampleDatabaseDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.sampleDatabaseDataSet.Customers);
            CargarDatosDataGridView();
            CargarDatosEspecificosDataGridView();
        }
        private void CargarDatosDataGridView()
        {
            // Obtener los datos de la base de datos
            dataGridView1.DataSource = Database.ObtenerProyectos();

            // Opcional: ajustar la apariencia del DataGridView, si es necesario
            // Por ejemplo, ajustar el tamaño de las columnas
            dataGridView1.AutoResizeColumns();
        }

        private void CargarDatosEspecificosDataGridView()
        {
            // Obtener los datos específicos de la base de datos
            dataGridView2.Rows.Clear(); // Limpiar filas existentes en caso de que el DataGridView ya contenga datos

            // Llenar el DataGridView con los datos específicos
            Database.CargarDatosEspecificosDataGridView(dataGridView2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(comboBox2.SelectedValue);
            groupBox1.Controls.Clear();
            Cliente c = Database.ObtenerCustomer(i);
            crearLabel(c.Nombre + " " + c.Telefono + " " + c.Dni);
        }

        private void crearLabel(string s)
        {
            System.Windows.Forms.Label cb = new System.Windows.Forms.Label();
            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            cb.Location = new System.Drawing.Point(10, 20);
            cb.Size = new System.Drawing.Size(291, 10);
            cb.TabIndex = 1;
            cb.Text = s;
            groupBox1.Controls.Add(cb);
        }

    }
}
