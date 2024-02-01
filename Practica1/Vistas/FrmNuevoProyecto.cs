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

namespace Practica1
{
    public partial class FrmNuevoProyecto : Form
    {
        ToolTip tp = new ToolTip();
        public FrmNuevoProyecto()
        {
            InitializeComponent();
        }

        private void checkBox2_MouseHover(object sender, EventArgs e)
        {
            tp.Show("Marcarse solo si sigue activo", cambios);
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            tp.Show("Marcarse solo si han habido cambios en la realización del proyecto", cambios);
        }

        private bool validar()
        {
            List<string> errores = new List<string>();

            // Realiza todas las validaciones y recopila los mensajes de error
            if (!Validator.validateTextBox(desc))
            {
                errores.Add("La descripción está vacía.");
            }

            if (!Validator.validateDates(fechaIni, fechaFin))
            {
                errores.Add("Las fechas no son válidas.");
            }

            if (!Validator.validateNumUpDown(presuIni))
            {
                errores.Add("El presupuesto inicial no es válido.");
            }

            if (!Validator.validateNumUpDown(presuFin))
            {
                errores.Add("El presupuesto final no es válido.");
            }

            if (!Validator.validateNumUpDown(cod))
            {
                errores.Add("El código no es válido.");
            }

            if (!Validator.validateNumUpDown(codCli))
            {
                errores.Add("El código del cliente no es válido.");
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
            desc.Clear();
            fechaIni.Value = DateTime.Now;
            fechaFin.Value = DateTime.Now;
            presuIni.Value = 0;
            estado.Checked = false;
            cambios.Checked = false;
            presuFin.Value = 0;
            cod.Value = 0;
            codCli.Value = 0;
        }

        private void aniadirProyecto()
        {
            ControladorProyectosBin.listaProyectos.Add(new Proyecto((int)cod.Value, desc.Text, fechaIni.Value,
                fechaFin.Value, estado.Checked, (Double)presuIni.Value, (Double)presuFin.Value,
                cambios.Checked, (int)codCli.Value));
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirProyecto();
                vaciarCampos();
                MessageBox.Show("Proyecto añadido al repositorio de Proyectos");

            }
            else
            {
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }
    }
}
