using System;
using System.Windows.Forms;

namespace EjemploPasarParametros
{
    public partial class FormularioOrigen : Form
    {
        public FormularioOrigen()
        {
            InitializeComponent();
        }

        private void buttonAbrirDestino_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario destino y pasar parámetros al constructor.

            FormularioDestino formularioDestino = new FormularioDestino("Este mensaje se pasa mediante el constructor");            
           
            // Establecer valores de las propiedades públicas en el formulario destino. (para hacer esto el constructor tendrá que estar vacío)
            formularioDestino.Mensaje = "Este mensaje se pasa mediante una propiedad pública";
            // Mostrar el formulario destino.
            formularioDestino.Show();
        }
    
    }
}

