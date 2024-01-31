using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Practica1.Vistas
{
    public partial class FrmNuevoCliente : Form
    {
        private int i = 1;

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
        private void AddBoledDate()
        {
            DateTime d = new DateTime(2024, 2, 12);
            this.monthCalendar1.AddMonthlyBoldedDate(d);
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ape2_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_Click(object sender, EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ape1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
         
        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            ShowAWeeksVacationOneMonthFromToday();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Image newLogo = Image.FromFile(openFileDialog1.FileName);
            textBox1.Text = openFileDialog1.FileName; 
            
            pictureBox1.Image = newLogo;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            validar();

            switch (tabControl1.SelectedTab)
            {
                case tabPage1:
                    tabControl1.SelectedTab = tabPage2;
                    break;
                string id = "tabPage";
                string numVal = i.ToString();
                // tabControl1.SelectedTab = id + numVal;
            }
        }

        private void validar()
        {
            if()
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
