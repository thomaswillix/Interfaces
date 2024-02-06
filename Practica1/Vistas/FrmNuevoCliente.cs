using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1.manejadores;
using Practica1.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Practica1.Vistas
{

    public partial class FrmNuevoCliente : Form
    {
        private RadioButton selectedrb;
        public FrmNuevoCliente()
        {
            InitializeComponent();
            openFileDialog1.Title = "Change logo image";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        }
        // Computes a week one month from today.
        private void ShowAWeeksVacationOneMonthFromToday()
        {
            DateTime today = this.monthCalendar1.TodayDate;
            DateTime vacationStart = today.AddMonths(1);
            DateTime vacationEnd = vacationStart.AddDays(7);
            // Select the week using SelectionStart and SelectionEnd.
            this.monthCalendar1.SelectionStart =
            vacationStart.AddDays(-1);
            this.monthCalendar1.SelectionEnd = vacationEnd.AddDays(-1);
        }
        private void AddBoldedDate()
        {
            DateTime d = new DateTime(2024, 2, 12);
            this.monthCalendar1.AddMonthlyBoldedDate(d);
        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            ShowAWeeksVacationOneMonthFromToday();
            AddBoldedDate();
            progressBar1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            startTimer();
        }

        private void startTimer()
        {
            progressBar1.Show();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 200;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                progressBar1.Hide();
                try
                {
                    Image newLogo = Image.FromFile(openFileDialog1.FileName);
                    textBox1.Text = openFileDialog1.FileName;
                    pictureBox1.Image = newLogo;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("Archivo no encontrado");
                }
            }
        }
        private void aceptar_Click(object sender, EventArgs e)
        {
            // Crear un diccionario que mapea las pestañas a las funciones de validación
            Dictionary<TabPage, Func<bool>> validacionesPorPestaña = new Dictionary<TabPage, Func<bool>>
            {
                { tabPage1, validarTab1 },
                { tabPage2, validarTab2 },
                { tabPage3, validarTab3 },
                { tabPage4, validarTab4 }
            };

            // Obtener la función de validación correspondiente a la pestaña seleccionada
            if (validacionesPorPestaña.TryGetValue(tabControl1.SelectedTab, out Func<bool> validarPestaña))
            {
                validarPestaña(); // Ejecutar la función de validación
            }
        }

        private bool validarTab1()
        {
            List<string> errores = new List<string>();

            // Realiza todas las validaciones y recopila los mensajes de error
            if (!Validator.validateTextBox(nom))
            {
                errores.Add("El nombre no es válido.");
            }

            if (!Validator.validateTextBox(direccion))
            {
                errores.Add("La dirección no es válida.");
            }

            if (!Validator.validateTextBox(ciudad))
            {
                errores.Add("La ciudad no es válida.");
            }

            if (!Validator.validateTextBox(nomRepre))
            {
                errores.Add("El nombre del representante no es válido.");
            }

            if (!Validator.validateEmail(correo))
            {
                errores.Add("El correo electrónico no es válido.");
            }

            if (!Validator.validateMaskedTextBox(cif))
            {
                errores.Add("El código cif no es válido.");
            }

            if (!Validator.validateMaskedTextBox(telefono))
            {
                errores.Add("El número de teléfono no es válido.");
            }

            if (!Validator.validateComboBox(pais))
            {
                errores.Add("El país no es válido.");
            }
            // Si hay mensajes de error, imprímelos y devuelve false
            if (errores.Count > 0)
            {
                foreach (var error in errores)
                {
                    Console.WriteLine(error);
                }
                return false;
            }
            // Si no hay errores, devuelve true
            tabControl1.SelectedTab = tabPage2;
            return true;
        }
        private bool validarTab2()
        {
            List<string> errores = new List<string>();

            // Realiza todas las validaciones y recopila los mensajes de error
            if (!Validator.validateTextBox(nom))
            {
                errores.Add("El tipo de cliente no es válido.");
            }

            if (!peque.Checked && !mediano.Checked && !grande.Checked && multinac.Checked)
            {
                errores.Add("El tipo de cliente no es válido.");
            }
            
            if (!Validator.validateRichTextBox(coments))
            {
                errores.Add("Los comentarios están vacíos.");
            }

            // Si hay mensajes de error, imprímelos y devuelve false
            if (errores.Count > 0)
            {
                foreach (var error in errores)
                {
                    Console.WriteLine(error);
                }                
                return false;
            }
            // Si no hay errores, devuelve true
            tabControl1.SelectedTab = tabPage3;
            return true;
        }
        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                selectedrb = rb;
            }
        }
        // Show the text of the selected RadioButton.
        void getSelectedRB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedrb.Text);
        }

        private bool validarTab3()
        {
            string error = "";

            // Realiza todas las validaciones y recopila los mensajes de error
            if (pictureBox1.Image == null)
            {
                error = ("Falta una imagen.");
            }

            // Si hay mensajes de error, imprímelos y devuelve false
            if (!String.IsNullOrEmpty(error))
            {
                return false;
            }
            tabControl1.SelectedTab = tabPage4;
            return true;
        }
        private bool validarTab4()
        {
            string error = "";

            // Realiza todas las validaciones y recopila los mensajes de error
            if (dateTimePicker1.Value == null)
            {
                error = ("Falta una fecha.");
            }

            // Si hay mensajes de error, imprímelos y devuelve false
            if (!String.IsNullOrEmpty(error))
            {
                return false;
            }
            validarTodas();
            return true;
        }

        private void validarTodas()
        {
            if(validarTab1() && validarTab2() && validarTab3() && validarTab4())
            {
                crearCliente();
            }
            else
            {
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }

        private void crearCliente()
        {
            RadioButton rb = new RadioButton();

            foreach (Control cli in cliente.Controls)
            {
                if (cli is RadioButton)
                {
                    RadioButton r = (RadioButton) cli;
                    if (r.Checked)
                    {
                        rb = r;
                    }
                }
            }

            Empleado e = new Empleado(nomRepre.Text);
            Cliente c = new Cliente(cif.Text, nom.Text, direccion.Text, ciudad.Text, e, correo.Text,
                cif.Text, telefono.Text, pais.Text, rb.Text, descuento.Value, coments.Text,
                pictureBox1.Image, dateTimePicker1.Value);
            ControladorClientesXML.leerClientesXML();
            ControladorClientesXML.listaClientes.Add(c);
            ControladorClientesXML.escribirClientesXML();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void colorrcb_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                coments.BackColor = colorDialog1.Color;
            }
        }

        private void fuentercb_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                coments.Font = fontDialog1.Font;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var rutaAArchivo = string.Empty;
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        coments.SaveFile(saveFileDialog1.FileName);
                        MessageBox.Show("Datos exportados");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Datos NO exportados");
                    }
                }
            }
        }
    }
}
