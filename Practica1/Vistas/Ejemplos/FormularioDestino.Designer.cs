namespace EjemploPasarParametros
{
    partial class FormularioDestino
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
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.textBoxMensaje2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Location = new System.Drawing.Point(195, 140);
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(358, 20);
            this.textBoxMensaje.TabIndex = 0;
            // 
            // textBoxMensaje2
            // 
            this.textBoxMensaje2.Location = new System.Drawing.Point(195, 196);
            this.textBoxMensaje2.Name = "textBoxMensaje2";
            this.textBoxMensaje2.Size = new System.Drawing.Size(358, 20);
            this.textBoxMensaje2.TabIndex = 1;
            // 
            // FormularioDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMensaje2);
            this.Controls.Add(this.textBoxMensaje);
            this.Name = "FormularioDestino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioDestino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.TextBox textBoxMensaje2;
    }
}