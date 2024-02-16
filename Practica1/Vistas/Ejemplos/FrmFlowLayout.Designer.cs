namespace Practica1.Vistas
{
    partial class FrmFlowLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlowLayout));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.puesto = new System.Windows.Forms.ComboBox();
            this.esc = new System.Windows.Forms.Button();
            this.wb = new System.Windows.Forms.PictureBox();
            this.bt2 = new System.Windows.Forms.Button();
            this.come = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numSS = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tlf = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ape2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ape1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cod = new System.Windows.Forms.NumericUpDown();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.dni);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.puesto);
            this.flowLayoutPanel1.Controls.Add(this.esc);
            this.flowLayoutPanel1.Controls.Add(this.wb);
            this.flowLayoutPanel1.Controls.Add(this.bt2);
            this.flowLayoutPanel1.Controls.Add(this.come);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.numSS);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.correo);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.tlf);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.ape2);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.ape1);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.cod);
            this.flowLayoutPanel1.Controls.Add(this.fechaNac);
            this.flowLayoutPanel1.Controls.Add(this.nom);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.label122);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(731, 261);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(17, 3);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "DNI/NIE";
            // 
            // puesto
            // 
            this.puesto.FormattingEnabled = true;
            this.puesto.Items.AddRange(new object[] {
            "comercial",
            "jefe",
            "programador"});
            this.puesto.Location = new System.Drawing.Point(178, 3);
            this.puesto.Name = "puesto";
            this.puesto.Size = new System.Drawing.Size(121, 21);
            this.puesto.TabIndex = 63;
            // 
            // esc
            // 
            this.esc.ForeColor = System.Drawing.Color.Black;
            this.esc.Location = new System.Drawing.Point(305, 3);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(88, 23);
            this.esc.TabIndex = 70;
            this.esc.Text = "Escondelo";
            this.esc.UseVisualStyleBackColor = true;
            // 
            // wb
            // 
            this.wb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wb.BackgroundImage")));
            this.wb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wb.Location = new System.Drawing.Point(399, 3);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(138, 137);
            this.wb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wb.TabIndex = 81;
            this.wb.TabStop = false;
            this.wb.Visible = false;
            // 
            // bt2
            // 
            this.bt2.ForeColor = System.Drawing.Color.Black;
            this.bt2.Location = new System.Drawing.Point(543, 3);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(126, 23);
            this.bt2.TabIndex = 69;
            this.bt2.Text = "Whitebeard Jumpscare";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // come
            // 
            this.come.Location = new System.Drawing.Point(3, 146);
            this.come.Name = "come";
            this.come.Size = new System.Drawing.Size(100, 20);
            this.come.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 143);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Comentarios";
            // 
            // numSS
            // 
            this.numSS.Location = new System.Drawing.Point(180, 146);
            this.numSS.Name = "numSS";
            this.numSS.Size = new System.Drawing.Size(120, 20);
            this.numSS.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 143);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Número de la SS";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(399, 146);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(100, 20);
            this.correo.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 143);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Correo";
            // 
            // tlf
            // 
            this.tlf.Location = new System.Drawing.Point(549, 146);
            this.tlf.Maximum = new decimal(new int[] {
            699999999,
            0,
            0,
            0});
            this.tlf.Minimum = new decimal(new int[] {
            600000000,
            0,
            0,
            0});
            this.tlf.Name = "tlf";
            this.tlf.Size = new System.Drawing.Size(120, 20);
            this.tlf.TabIndex = 64;
            this.tlf.Value = new decimal(new int[] {
            600000000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 143);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Puesto";
            // 
            // ape2
            // 
            this.ape2.Location = new System.Drawing.Point(3, 172);
            this.ape2.Name = "ape2";
            this.ape2.Size = new System.Drawing.Size(100, 20);
            this.ape2.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 169);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Segundo Apellido";
            // 
            // ape1
            // 
            this.ape1.Location = new System.Drawing.Point(205, 172);
            this.ape1.Name = "ape1";
            this.ape1.Size = new System.Drawing.Size(100, 20);
            this.ape1.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 169);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Primer Apellido";
            // 
            // cod
            // 
            this.cod.BackColor = System.Drawing.SystemColors.Window;
            this.cod.Location = new System.Drawing.Point(393, 172);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(120, 20);
            this.cod.TabIndex = 58;
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(519, 172);
            this.fechaNac.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.fechaNac.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(200, 20);
            this.fechaNac.TabIndex = 66;
            this.fechaNac.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(3, 198);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 195);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 195);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(278, 195);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Nombre";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(328, 195);
            this.label122.Name = "label122";
            this.label122.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label122.Size = new System.Drawing.Size(40, 13);
            this.label122.TabIndex = 71;
            this.label122.Text = "Código";
            // 
            // FrmFlowLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmFlowLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFlowLayout";
            this.Load += new System.EventHandler(this.FrmFlowLayout_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox puesto;
        private System.Windows.Forms.Button esc;
        private System.Windows.Forms.PictureBox wb;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.TextBox come;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown tlf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ape2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ape1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cod;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label122;
    }
}