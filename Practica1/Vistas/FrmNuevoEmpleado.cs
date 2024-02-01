using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1.manejadores;

namespace Practica1
{

    public partial class FrmNuevoEmpleado : Form
    {

        public FrmNuevoEmpleado()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            List<string> errores = new List<string>();

            // Realiza todas las validaciones y recopila los mensajes de error
            if (!Validator.validateNumUpDown(cod))
            {
                errores.Add("El código no es válido.");
            }

            if (!Validator.validarDni(dni.Text))
            {
                errores.Add("El DNI no es válido.");
            }

            if (!Validator.validateString(nom))
            {
                errores.Add("El nombre no es válido.");
            }

            if (!Validator.validateString(ape1))
            {
                errores.Add("El primer apellido no es válido.");
            }

            if (!Validator.validateString(ape2))
            {
                errores.Add("El segundo apellido no es válido.");
            }

            if (!Validator.validateEmail(correo))
            {
                errores.Add("El correo electrónico no es válido.");
            }

            if (!Validator.validatePhoneNumber(tlf))
            {
                errores.Add("El número de teléfono no es válido.");
            }

            if (!Validator.validateString(come))
            {
                errores.Add("El campo de comentarios no es válido.");
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
            return true;
        }

        private void vaciarCampos()
        {
            string fecha = "Jan 01, 1953";
            var parsedDate = DateTime.Parse(fecha);
            cod.Value = 0;
            dni.Clear();
            nom.Clear();
            ape1.Clear();
            ape2.Clear();
            puesto.Items.Clear();
            tlf.Value = 600000000;
            correo.Clear();
            fechaNac.Value = parsedDate;
            numSS.Value = 0;
            come.Clear();
        }
        private void aniadirEmpleado()
        {
            ControladorEmpleadosJSON.listaEmpleados.Add(new Empleado((int)cod.Value, dni.Text, nom.Text, ape1.Text, ape2.Text,
                puesto.Text, (int)tlf.Value, correo.Text, fechaNac.Value, (int)numSS.Value, come.Text));
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirEmpleado();
                vaciarCampos();
                MessageBox.Show("Empleado añadido al repositorio de Empleados");
            }
            else
            {
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            wb.Visible = true;
        }

        private void esc_Click(object sender, EventArgs e)
        {
            wb.Visible = false;
        }
    }
}