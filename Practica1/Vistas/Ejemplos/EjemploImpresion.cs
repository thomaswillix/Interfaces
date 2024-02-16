using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Practica1.Vistas.Ejemplos
{
    public partial class EjemploImpresion : Form
    {
        private PrintDocument printDocument;
        private PrintDialog printDialog;

        public EjemploImpresion()
        {
            InitializeComponent();

            // Inicializar el PrintDocument y el PrintDialog.
            printDocument = new PrintDocument();
            printDialog = new PrintDialog();
            // Asociar el evento PrintPage al método de impresión.
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            // Mostrar el diálogo de impresión para seleccionar la impresora y configurar opciones.
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Iniciar el proceso de impresión.
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Aquí puedes dibujar el contenido que deseas imprimir en la página.
            // Por ejemplo, dibujar un mensaje en el centro de la página.
            
            string mensaje = "¡Hola, esto es un ejemplo de impresión en C#!";
            Font fuente = new Font("Arial", 12);
            PointF puntoInicio = new PointF(100, 100);
            // Dibujar el mensaje en la página.
            e.Graphics.DrawString(mensaje, fuente, Brushes.Black, puntoInicio);
        }
    }
}
