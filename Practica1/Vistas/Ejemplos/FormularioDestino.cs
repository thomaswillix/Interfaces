using System;
using System.Windows.Forms;

namespace EjemploPasarParametros
{
    public partial class FormularioDestino : Form
    {
        // Propiedad pública para almacenar el mensaje. (Para que sea útil el constructor no ha de tener parámetros)
        public string Mensaje { get; set; }

        // Constructor que recibe parámetros.
        public FormularioDestino(string mensaje)
        {
            InitializeComponent();
            // Hacer algo con el parámetro recibido, como mostrarlo en un control
            textBoxMensaje.Text = mensaje;
            textBoxMensaje2.Text = Mensaje;
        }
    }
}
