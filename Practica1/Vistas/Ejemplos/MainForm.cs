﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.Vistas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Establecer la propiedad IsMdiContainer en true para hacer de este formulario un MDI parent.
            this.IsMdiContainer = true;
            // Crear y mostrar formularios secundarios dentro del MDI parent.
            CrearFormularioHijo("FormularioHijo1");
            CrearFormularioHijo("FormularioHijo2");
        }
        private void CrearFormularioHijo(string nombreFormulario)
        {
            // Crear una nueva instancia del formulario hijo.
            //FormularioHijo formularioHijo = new FormularioHijo();
            // Establecer propiedades para el formulario hijo.
            /*formularioHijo.Text = nombreFormulario;
            formularioHijo.MdiParent = this; // Establecer el MDI parent a este formulario.
            // Mostrar el formulario hijo.
            formularioHijo.Show();*/
        }
    }
}
