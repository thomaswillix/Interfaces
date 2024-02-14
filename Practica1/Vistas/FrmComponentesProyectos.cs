﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1.manejadores;

namespace Practica1.Vistas
{
    public partial class FrmComponentesProyectos : Form
    {
        public FrmComponentesProyectos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ordenarProyectos(Func<Proyecto, IComparable> aux)
        {
            ControladorProyectosBin.listaProyectos = ControladorProyectosBin.listaProyectos.OrderBy(aux).ToList();

        }

        private void mostrarProyectos()
        {
            int posicion = 10;

            foreach (Proyecto p in ControladorProyectosBin.listaProyectos)
            {
                crearChecked(p, posicion);
                posicion += 30;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarProyectos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Controls.Clear();
            ordenarProyectos(Proyecto => Proyecto.FechaIni);
            mostrarProyectos();
        }


        private void crearChecked(Proyecto p1, int posicion)
        {
            System.Windows.Forms.CheckBox cb = new System.Windows.Forms.CheckBox();

            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            cb.Location = new System.Drawing.Point(75, posicion);
            cb.Size = new System.Drawing.Size(291, 20);
            cb.TabIndex = 1;
            cb.Text = p1.Descripcion;
            listBox1.Controls.Add(cb);
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to really exit ? ",
                                    "Exit",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ordenarNombre_Click(object sender, EventArgs e)
        {
            listBox1.Controls.Clear();
            ordenarProyectos(Proyecto => Proyecto.Descripcion);
            mostrarProyectos();
        }

        private void btElim_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.CheckBox cd in listBox1.Controls)
            {
                if (cd.Checked)
                {
                    int posicion = ControladorProyectosBin.listaProyectos.FindIndex(x => x.Descripcion == cd.Text);
                    ControladorProyectosBin.listaProyectos.RemoveAt(posicion);
                }
            }
            this.listBox1.Controls.Clear();
            mostrarProyectos();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void populateCombo()
        {
            comboBox1.Items.Clear();

            foreach (Proyecto p in ControladorProyectosBin.listaProyectos)
            {
                comboBox1.Items.Add(p.ToString());
            }
        }

        private void FrmComponentesProyectos_Load(object sender, EventArgs e)
        {
            //ControladorProyectosBin.cargarProyectos();
            //ControladorProyectosBin.escribirProyectos();
            ControladorEmpleadosJSON.leerEmpleados();
            ControladorProyectosBin.leerProyectos();
            populateCombo();
        }
    }
}
