﻿namespace Practica1.Vistas
{
    partial class nuevo_cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nom = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.nomRepre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ape1 = new System.Windows.Forms.TextBox();
            this.ciudad = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.di = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.asd = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cif = new System.Windows.Forms.MaskedTextBox();
            this.telefono = new System.Windows.Forms.MaskedTextBox();
            this.pais = new System.Windows.Forms.ComboBox();
            this.cliente = new System.Windows.Forms.GroupBox();
            this.peque = new System.Windows.Forms.RadioButton();
            this.madiano = new System.Windows.Forms.RadioButton();
            this.grande = new System.Windows.Forms.RadioButton();
            this.multinac = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.coments = new System.Windows.Forms.Label();
            this.descuento = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.logo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(97, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pais);
            this.tabPage1.Controls.Add(this.telefono);
            this.tabPage1.Controls.Add(this.cif);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.asd);
            this.tabPage1.Controls.Add(this.t);
            this.tabPage1.Controls.Add(this.nom);
            this.tabPage1.Controls.Add(this.nombre);
            this.tabPage1.Controls.Add(this.correo);
            this.tabPage1.Controls.Add(this.c);
            this.tabPage1.Controls.Add(this.nomRepre);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.ape1);
            this.tabPage1.Controls.Add(this.ciudad);
            this.tabPage1.Controls.Add(this.direccion);
            this.tabPage1.Controls.Add(this.di);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(615, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.descuento);
            this.tabPage2.Controls.Add(this.coments);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(615, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Privados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.maskedTextBox1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.logo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(615, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.monthCalendar1);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(615, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Citas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(133, 31);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(242, 20);
            this.nom.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(10, 34);
            this.nombre.Name = "nombre";
            this.nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 82;
            this.nombre.Text = "Nombre";
            this.nombre.Click += new System.EventHandler(this.label6_Click);
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(133, 192);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(242, 20);
            this.correo.TabIndex = 5;
            this.correo.TextChanged += new System.EventHandler(this.correo_TextChanged);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(6, 195);
            this.c.Name = "c";
            this.c.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.c.Size = new System.Drawing.Size(38, 13);
            this.c.TabIndex = 80;
            this.c.Text = "Correo";
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // nomRepre
            // 
            this.nomRepre.Location = new System.Drawing.Point(133, 160);
            this.nomRepre.Name = "nomRepre";
            this.nomRepre.Size = new System.Drawing.Size(242, 20);
            this.nomRepre.TabIndex = 4;
            this.nomRepre.TextChanged += new System.EventHandler(this.ape2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 163);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Nombre Representante";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ape1
            // 
            this.ape1.Location = new System.Drawing.Point(133, 131);
            this.ape1.Name = "ape1";
            this.ape1.Size = new System.Drawing.Size(242, 20);
            this.ape1.TabIndex = 3;
            this.ape1.TextChanged += new System.EventHandler(this.ape1_TextChanged);
            // 
            // ciudad
            // 
            this.ciudad.AutoSize = true;
            this.ciudad.Location = new System.Drawing.Point(6, 134);
            this.ciudad.Name = "ciudad";
            this.ciudad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ciudad.Size = new System.Drawing.Size(40, 13);
            this.ciudad.TabIndex = 3;
            this.ciudad.Text = "Ciudad";
            this.ciudad.Click += new System.EventHandler(this.label8_Click);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(133, 61);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(242, 50);
            this.direccion.TabIndex = 2;
            this.direccion.TextChanged += new System.EventHandler(this.direccion_TextChanged);
            // 
            // di
            // 
            this.di.AutoSize = true;
            this.di.Location = new System.Drawing.Point(10, 77);
            this.di.Name = "di";
            this.di.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.di.Size = new System.Drawing.Size(52, 13);
            this.di.TabIndex = 72;
            this.di.Text = "Dirección";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(231, 428);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(119, 34);
            this.aceptar.TabIndex = 69;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(451, 428);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(119, 34);
            this.cancelar.TabIndex = 70;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(394, 34);
            this.asd.Name = "asd";
            this.asd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.asd.Size = new System.Drawing.Size(23, 13);
            this.asd.TabIndex = 0;
            this.asd.Text = "CIF";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(394, 64);
            this.t.Name = "t";
            this.t.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t.Size = new System.Drawing.Size(49, 13);
            this.t.TabIndex = 0;
            this.t.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 107);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "País";
            // 
            // cif
            // 
            this.cif.Location = new System.Drawing.Point(460, 31);
            this.cif.Mask = "L 0000000";
            this.cif.Name = "cif";
            this.cif.Size = new System.Drawing.Size(100, 20);
            this.cif.TabIndex = 6;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(460, 61);
            this.telefono.Mask = "(999)000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 7;
            // 
            // pais
            // 
            this.pais.FormattingEnabled = true;
            this.pais.Location = new System.Drawing.Point(460, 103);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(100, 21);
            this.pais.TabIndex = 83;
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.multinac);
            this.cliente.Controls.Add(this.grande);
            this.cliente.Controls.Add(this.madiano);
            this.cliente.Controls.Add(this.peque);
            this.cliente.Location = new System.Drawing.Point(51, 42);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(226, 100);
            this.cliente.TabIndex = 0;
            this.cliente.TabStop = false;
            this.cliente.Text = "Tipo de Cliente";
            // 
            // peque
            // 
            this.peque.AutoSize = true;
            this.peque.Location = new System.Drawing.Point(18, 31);
            this.peque.Name = "peque";
            this.peque.Size = new System.Drawing.Size(68, 17);
            this.peque.TabIndex = 1;
            this.peque.TabStop = true;
            this.peque.Text = "Pequeño";
            this.peque.UseVisualStyleBackColor = true;
            // 
            // madiano
            // 
            this.madiano.AutoSize = true;
            this.madiano.Location = new System.Drawing.Point(18, 54);
            this.madiano.Name = "madiano";
            this.madiano.Size = new System.Drawing.Size(66, 17);
            this.madiano.TabIndex = 2;
            this.madiano.TabStop = true;
            this.madiano.Text = "Mediano";
            this.madiano.UseVisualStyleBackColor = true;
            // 
            // grande
            // 
            this.grande.AutoSize = true;
            this.grande.Location = new System.Drawing.Point(126, 31);
            this.grande.Name = "grande";
            this.grande.Size = new System.Drawing.Size(60, 17);
            this.grande.TabIndex = 3;
            this.grande.TabStop = true;
            this.grande.Text = "Grande";
            this.grande.UseVisualStyleBackColor = true;
            // 
            // multinac
            // 
            this.multinac.AutoSize = true;
            this.multinac.Location = new System.Drawing.Point(126, 54);
            this.multinac.Name = "multinac";
            this.multinac.Size = new System.Drawing.Size(87, 17);
            this.multinac.TabIndex = 4;
            this.multinac.TabStop = true;
            this.multinac.Text = "Multinacional";
            this.multinac.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descuento";
            // 
            // coments
            // 
            this.coments.AutoSize = true;
            this.coments.Location = new System.Drawing.Point(30, 229);
            this.coments.Name = "coments";
            this.coments.Size = new System.Drawing.Size(65, 13);
            this.coments.TabIndex = 0;
            this.coments.Text = "Comentarios";
            // 
            // descuento
            // 
            this.descuento.Location = new System.Drawing.Point(112, 178);
            this.descuento.Name = "descuento";
            this.descuento.Size = new System.Drawing.Size(120, 20);
            this.descuento.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(112, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(497, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Location = new System.Drawing.Point(70, 37);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(31, 13);
            this.logo.TabIndex = 0;
            this.logo.Text = "Logo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(201, 86);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 177);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(130, 34);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(226, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nuevo_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Name = "nuevo_cliente";
            this.Text = "nuevo_cliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox nomRepre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ape1;
        private System.Windows.Forms.Label ciudad;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label di;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.MaskedTextBox cif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox telefono;
        private System.Windows.Forms.ComboBox pais;
        private System.Windows.Forms.Label coments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox cliente;
        private System.Windows.Forms.RadioButton multinac;
        private System.Windows.Forms.RadioButton grande;
        private System.Windows.Forms.RadioButton madiano;
        private System.Windows.Forms.RadioButton peque;
        private System.Windows.Forms.NumericUpDown descuento;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}