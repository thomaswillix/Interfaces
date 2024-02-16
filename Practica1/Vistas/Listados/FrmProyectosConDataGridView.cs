using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.Vistas.Listados
{
    public partial class FrmProyectosConDataGridView : Form
    {
        // Crear una instancia de tu controlador de base de datos

        Modelo.Database db = new Modelo.Database();

        public FrmProyectosConDataGridView()
        {
            InitializeComponent();
        }

        private void FrmProyectosConDataGridView_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
            CargarDatosEspecificosDataGridView();
        }
        private void CargarDatosDataGridView()
        {
            
            // Obtener los datos de la base de datos
            dataGridView1.DataSource = db.ObtenerProyectos();

            // Opcional: ajustar la apariencia del DataGridView, si es necesario
            // Por ejemplo, ajustar el tamaño de las columnas
            dataGridView1.AutoResizeColumns();
        }
        private void CargarDatosEspecificosDataGridView()
        {
            // Obtener los datos específicos de la base de datos
            dataGridView2.Rows.Clear(); // Limpiar filas existentes en caso de que el DataGridView ya contenga datos

            // Llenar el DataGridView con los datos específicos
            db.CargarDatosEspecificosDataGridView(dataGridView2);
        }
    }
}
