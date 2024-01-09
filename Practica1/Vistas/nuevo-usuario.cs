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

namespace Practica1.Vistas
{
    public partial class nuevo_usuario : Form
    {
        public nuevo_usuario()
        {
            InitializeComponent();
        }

        private void nuevo_usuario_Load(object sender, EventArgs e)
        {
            ControladorUsuariosXML.leerUsuariosXML();
        }
        private bool validar()
        {
            if (user.Text == "" || pass.Text == "" || pass.Text.Length < 4  || user.Text.Length < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void vaciarCampos()
        {
            user.Text = "";
            pass.Text = "";
        }
        private void camposNormal()
        {
            user.BackColor = Color.White; 
            pass.BackColor = Color.White;
        }
        private void camposIncorrectos()
        {
            if (user.Text == "" || user.Text.Length < 4)
            {
                user.BackColor = Color.Red;
            }
            if (pass.Text == "" || pass.Text.Length < 4) 
            {
                pass.BackColor = Color.Red;

            }
        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirUsu();
                vaciarCampos();
                camposNormal();
            }
            else {
                camposNormal();
                camposIncorrectos();
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }
        private void aniadirUsu()
        {
            Usuario u = new Usuario();

            if (ControladorUsuariosXML.buscarUsuario(user.Text, pass.Text))
            {
                MessageBox.Show("Ese usuario ya existe");
            }
            else
            {
                u.User = user.Text;
                u.Pass = pass.Text;
                ControladorUsuariosXML.listaUsuarios.Add(u);
                ControladorUsuariosXML.escribirUsuariosXML();
                MessageBox.Show("Usuario registrado con éxito.");

            }
        }
    }
}
