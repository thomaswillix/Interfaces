using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1.Modelo;
using Practica1.Manejadores;
using System.Windows.Forms;

namespace Practica1.Vistas
{
    public partial class FrmImprimir : Form
    {
        internal PrintPreviewDialog PrintPreviewDialog1;
        internal System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();

        public FrmImprimir()
        {
            InitializeComponent();
        }
        private void imprimirPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicializa el printpreviewdialog
            PrintPreviewDialog1 = new PrintPreviewDialog();
            //Set the size, location, and name.
            PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
            PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
            //establece el documento a imprimir
            document.DocumentName = "Previsualización";
            PrintPreviewDialog1.Document = document;

            //muestra el printpreviewdialog
            PrintPreviewDialog1.ShowDialog();

        }

        private void FrmImprimir_Load(object sender, EventArgs e)
        {
            document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);
        }
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0;
            int contador = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            Font font = new Font("Arial", 10);
            // Ajusta el espacio entre líneas a un valor más grande (por ejemplo, 20)
            float espacioEntreLineas = 20;

            // Imprime el encabezado
            yPos = topMargin + (contador * espacioEntreLineas);
            e.Graphics.DrawString("LISTADO DE CLIENTES", font, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            contador++;

            // Imprime los datos de los clientes
            List<Cliente> lista = ControladorClientesXML.listaClientes;
            lista.ForEach(cliente =>
            {
                yPos = topMargin + (contador * espacioEntreLineas);
                e.Graphics.DrawString(cliente.ToString(), font, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                contador++;
            });
        }

        // En el load del formulario se añade un evento para poder imprimir el documento
        private void Alumnos_Load(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new
            System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
        }
        // Creamos un evento para el botón imprimir del formulario
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        //este método imprime la imagen de la captura de la pantalla
        private void printDocument1_PrintPage(System.Object sender,
        System.Drawing.Printing.PrintPageEventArgs e)
        {
            //captura la pantalla
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            Bitmap memoryImage = new Bitmap(s.Width,
            s.Height, myGraphics);
            Graphics memoryGraphics =
            Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            //dibuja la pantalla en el documento
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
