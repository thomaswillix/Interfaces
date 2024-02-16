namespace Practica1
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.enlace = new System.Windows.Forms.LinkLabel();
            this.usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cuadroUsu = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cuadroCont = new System.Windows.Forms.TextBox();
            this.disclaimer = new System.Windows.Forms.Label();
            this.IblError = new System.Windows.Forms.Label();
            this.btReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.ForeColor = System.Drawing.SystemColors.Menu;
            this.accept.Location = new System.Drawing.Point(374, 187);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 4;
            this.accept.Text = "Aceptar";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.ForeColor = System.Drawing.SystemColors.Menu;
            this.cancel.Location = new System.Drawing.Point(262, 187);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // enlace
            // 
            this.enlace.AutoSize = true;
            this.enlace.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enlace.LinkColor = System.Drawing.Color.White;
            this.enlace.Location = new System.Drawing.Point(36, 150);
            this.enlace.Name = "enlace";
            this.enlace.Size = new System.Drawing.Size(83, 13);
            this.enlace.TabIndex = 6;
            this.enlace.TabStop = true;
            this.enlace.Text = "Enlace a la web";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.usuario.Location = new System.Drawing.Point(213, 98);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(69, 19);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cuadroUsu
            // 
            this.cuadroUsu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cuadroUsu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroUsu.ForeColor = System.Drawing.SystemColors.Window;
            this.cuadroUsu.Location = new System.Drawing.Point(308, 98);
            this.cuadroUsu.Name = "cuadroUsu";
            this.cuadroUsu.Size = new System.Drawing.Size(150, 26);
            this.cuadroUsu.TabIndex = 1;
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clave.ForeColor = System.Drawing.SystemColors.Window;
            this.clave.Location = new System.Drawing.Point(213, 135);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(52, 19);
            this.clave.TabIndex = 6;
            this.clave.Text = "Clave";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(388, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 7;
            // 
            // cuadroCont
            // 
            this.cuadroCont.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cuadroCont.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroCont.ForeColor = System.Drawing.SystemColors.Window;
            this.cuadroCont.Location = new System.Drawing.Point(308, 135);
            this.cuadroCont.Name = "cuadroCont";
            this.cuadroCont.PasswordChar = '*';
            this.cuadroCont.Size = new System.Drawing.Size(150, 26);
            this.cuadroCont.TabIndex = 2;
            // 
            // disclaimer
            // 
            this.disclaimer.AutoSize = true;
            this.disclaimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.disclaimer.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaimer.ForeColor = System.Drawing.SystemColors.Window;
            this.disclaimer.Location = new System.Drawing.Point(192, 295);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(317, 95);
            this.disclaimer.TabIndex = 9;
            this.disclaimer.Text = resources.GetString("disclaimer.Text");
            this.disclaimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IblError
            // 
            this.IblError.AutoSize = true;
            this.IblError.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblError.ForeColor = System.Drawing.Color.Red;
            this.IblError.Location = new System.Drawing.Point(242, 263);
            this.IblError.Name = "IblError";
            this.IblError.Size = new System.Drawing.Size(221, 19);
            this.IblError.TabIndex = 10;
            this.IblError.Text = "Usuario y/o clave incorrecta";
            this.IblError.Visible = false;
            // 
            // btReg
            // 
            this.btReg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btReg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btReg.ForeColor = System.Drawing.SystemColors.Menu;
            this.btReg.Location = new System.Drawing.Point(322, 226);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(75, 23);
            this.btReg.TabIndex = 5;
            this.btReg.Text = "Registrar";
            this.btReg.UseVisualStyleBackColor = false;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(305, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(677, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.IblError);
            this.Controls.Add(this.disclaimer);
            this.Controls.Add(this.cuadroCont);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.cuadroUsu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.enlace);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionaIES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.GestionaIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.LinkLabel enlace;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cuadroUsu;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox cuadroCont;
        private System.Windows.Forms.Label disclaimer;
        private System.Windows.Forms.Label IblError;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.Label label1;
    }
}

