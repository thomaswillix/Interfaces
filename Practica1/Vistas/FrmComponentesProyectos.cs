using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1.Manejadores;
using Practica1.Modelo;

namespace Practica1.Vistas
{
    public partial class FrmComponentesProyectos : Form
    {
        public FrmComponentesProyectos()
        {
            InitializeComponent();
        }

        private void mostrarEmpleados()
        {
            int posicion = 2;

            foreach (Empleado e in ControladorEmpleadosJSON.listaEmpleados)
            {
                crearChecked(e, posicion);
                posicion += 30;
            }
        }

        private void crearChecked(Empleado x, int posicion)
        {
            System.Windows.Forms.CheckBox cb = new System.Windows.Forms.CheckBox();

            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            cb.Location = new System.Drawing.Point(20, posicion);
            cb.Size = new System.Drawing.Size(291, 20);
            cb.TabIndex = 1;
            cb.Text = x.Id.ToString() + " " + x.Nombre + " " + x.Apellido1 + " " + x.Puesto;
            listBox1.Controls.Add(cb);
        }

        private void FrmComponenesProyectos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ControladorComponentesProyecto.escribirComponentes();
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("No guardado");
            }
        }


        private void btElim_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.CheckBox cd in listBox1.Controls)
            {
                if (cd.Checked)
                {
                    int posicion = ControladorEmpleadosJSON.listaEmpleados.FindIndex(x => x.Id.ToString() + " " + x.Nombre + " " + x.Apellido1 + " " + x.Puesto == cd.Text);
                    ControladorProyectosBin.listaProyectos.RemoveAt(posicion);
                }
            }
            this.listBox1.Controls.Clear();
            mostrarEmpleados();
        }

        private void populateCombo()
        {
            comboBox1.Items.Clear();

            foreach (Proyecto p in ControladorProyectosBin.listaProyectos)
            {
                comboBox1.Items.Add(p.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ControladorComponentesProyecto.listaComponentes.Contains(
                new ComponentesProyecto {CodigoProyecto = comboBox1.SelectedIndex.ToString()})) 
            {
                populateListView();
            } 
        }

        private void populateListView()
        {
            foreach (ComponentesProyecto cp in ControladorComponentesProyecto.listaComponentes)
            {
                listBox2.Text = cp.IdEmpleado.ToString() + " " + cp.Puesto + 
                    " " + cp.PorcentajeDedicacion +"\n";
            }
        }

        private void FrmComponentesProyectos_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
            populateCombo();
        }

    }
}
