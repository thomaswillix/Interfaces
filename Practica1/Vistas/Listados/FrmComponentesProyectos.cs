using Practica1.Manejadores;
using Practica1.Modelo;
using System;
using System.Windows.Forms;

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
                    listBox2.Items.Remove(cd);
                    MessageBox.Show("Proyecto eliminado");

                }
            }
        }

        private void populateCombo()
        {
            comboBox1.Items.Clear();
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            foreach (Proyecto p in ControladorProyectosBin.listaProyectos)
            {
                comboBox1.Items.Add(new { Text = p.Descripcion, Value = p.Codigo });
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Controls.Clear();
            foreach (ComponentesProyecto cp in ControladorComponentesProyecto.listaComponentes)
            {
                if (cp.CodigoP == Convert.ToInt32(comboBox1.SelectedValue))
                {
                    populateListView();
                }
            }

        }
        private void crearLabel(string s, int n)
        {
            System.Windows.Forms.Label cb = new System.Windows.Forms.Label();

            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            cb.Location = new System.Drawing.Point(20, 15 + n);
            cb.Size = new System.Drawing.Size(291, 20);
            cb.TabIndex = 1;
            cb.Text = s;
            listBox2.Controls.Add(cb);
        }
        private void populateListView()
        {
            foreach (ComponentesProyecto cp in ControladorComponentesProyecto.listaComponentes)
            {
                crearLabel(cp.DescripcionP, 10);
                crearLabel(Convert.ToString(cp.IdEmpleado), 40);
                crearLabel(cp.Puesto, 70);
            }
        }

        private void FrmComponentesProyectos_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
            populateCombo();
        }

    }
}
