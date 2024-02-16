using System;
using System.Drawing.Text;
using System.Security.Permissions;
using System.Windows.Forms;
using Practica1.Manejadores;
using Practica1.manejadores;
using Practica1.Vistas;

namespace Practica1
{
    public partial class FrmLogin : Form
    {
        private int intentos = 0;
        

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }    
        
        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Has pulsado Aceptar");    
            string usuario = cuadroUsu.Text.ToLower();
            string contrasena = cuadroCont.Text.ToLower();
            if(validaLogin(ref usuario, ref contrasena) == true){
                //ControladorUsuariosXML.buscarUsuario(usuario, contrasena);
                cuadroUsu.Clear();
                cuadroCont.Clear();
                this.Hide();
                FrmPrincipal Form = new FrmPrincipal();
                Form.ShowDialog();
                Form.Dispose();
                this.Show();
            }
            else
            {
                intentos++;
                cuadroUsu.Clear();
                cuadroCont.Clear();
                cuadroUsu.Focus();
                if (intentos >=3)
                {
                    MessageBox.Show("Llevas 3 intentos");
                    intentos = 0;
                    Application.Exit();
                }
            }
            // En la llamada es necesario pasarlo como ref | out
        }
       
        bool validaLogin(ref string usuario, ref string clave)
        {
            return ControladorUsuariosXML.validaLogin(ref usuario, ref clave);

        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Has pulsado Cancelar");
        }

        private void GestionaIES_Load(object sender, System.EventArgs e)
        {
            ControladorClientesXML.cargarClientesXML();
            ControladorComponentesProyecto.crearComponentes();
            ControladorEmpleadosJSON.cargarEmpleados();
            ControladorProyectosBin.cargarProyectos();
            ControladorUsuariosXML.cargarUsuariosXML();
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            Label nuevaLbl = new Label();
            nuevaLbl.Text = "PRUEBA";
            nuevaLbl.Location = new System.Drawing.Point(100, 25);
            nuevaLbl.Size = new System.Drawing.Size(70, 20);
            this.Controls.Add(nuevaLbl);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario nuevoUsu = new FrmNuevoUsuario();
            this.Hide();
            nuevoUsu.ShowDialog();
            this.Show();
        }
    }
}
