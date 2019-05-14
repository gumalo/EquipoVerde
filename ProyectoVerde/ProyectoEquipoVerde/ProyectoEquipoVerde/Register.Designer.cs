namespace ProyectoEquipoVerde
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.ptrLogo2 = new System.Windows.Forms.PictureBox();
            this.txtNuevaContrasenya = new System.Windows.Forms.TextBox();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.lblNuevaContrasenya = new System.Windows.Forms.Label();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.txtRepetirContrasenya = new System.Windows.Forms.TextBox();
            this.lblRepetirContrasenya = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnDarseDeAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrLogo2
            // 
            this.ptrLogo2.Image = ((System.Drawing.Image)(resources.GetObject("ptrLogo2.Image")));
            this.ptrLogo2.Location = new System.Drawing.Point(113, 12);
            this.ptrLogo2.Name = "ptrLogo2";
            this.ptrLogo2.Size = new System.Drawing.Size(177, 155);
            this.ptrLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrLogo2.TabIndex = 1;
            this.ptrLogo2.TabStop = false;
            // 
            // txtNuevaContrasenya
            // 
            this.txtNuevaContrasenya.Location = new System.Drawing.Point(129, 235);
            this.txtNuevaContrasenya.Name = "txtNuevaContrasenya";
            this.txtNuevaContrasenya.Size = new System.Drawing.Size(161, 20);
            this.txtNuevaContrasenya.TabIndex = 8;
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(129, 202);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(161, 20);
            this.txtNuevoUsuario.TabIndex = 7;
            // 
            // lblNuevaContrasenya
            // 
            this.lblNuevaContrasenya.AutoSize = true;
            this.lblNuevaContrasenya.Location = new System.Drawing.Point(59, 238);
            this.lblNuevaContrasenya.Name = "lblNuevaContrasenya";
            this.lblNuevaContrasenya.Size = new System.Drawing.Size(64, 13);
            this.lblNuevaContrasenya.TabIndex = 6;
            this.lblNuevaContrasenya.Text = "Contraseña:";
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(77, 205);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblNuevoUsuario.TabIndex = 5;
            this.lblNuevoUsuario.Text = "Usuario:";
            // 
            // txtRepetirContrasenya
            // 
            this.txtRepetirContrasenya.Location = new System.Drawing.Point(129, 270);
            this.txtRepetirContrasenya.Name = "txtRepetirContrasenya";
            this.txtRepetirContrasenya.Size = new System.Drawing.Size(161, 20);
            this.txtRepetirContrasenya.TabIndex = 10;
            // 
            // lblRepetirContrasenya
            // 
            this.lblRepetirContrasenya.AutoSize = true;
            this.lblRepetirContrasenya.Location = new System.Drawing.Point(22, 273);
            this.lblRepetirContrasenya.Name = "lblRepetirContrasenya";
            this.lblRepetirContrasenya.Size = new System.Drawing.Size(101, 13);
            this.lblRepetirContrasenya.TabIndex = 9;
            this.lblRepetirContrasenya.Text = "Repetir Contraseña:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(85, 308);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnDarseDeAlta
            // 
            this.btnDarseDeAlta.Location = new System.Drawing.Point(80, 350);
            this.btnDarseDeAlta.Name = "btnDarseDeAlta";
            this.btnDarseDeAlta.Size = new System.Drawing.Size(229, 67);
            this.btnDarseDeAlta.TabIndex = 13;
            this.btnDarseDeAlta.Text = "DARSE DE ALTA";
            this.btnDarseDeAlta.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.btnDarseDeAlta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtRepetirContrasenya);
            this.Controls.Add(this.lblRepetirContrasenya);
            this.Controls.Add(this.txtNuevaContrasenya);
            this.Controls.Add(this.txtNuevoUsuario);
            this.Controls.Add(this.lblNuevaContrasenya);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Controls.Add(this.ptrLogo2);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrLogo2;
        private System.Windows.Forms.TextBox txtNuevaContrasenya;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Label lblNuevaContrasenya;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.TextBox txtRepetirContrasenya;
        private System.Windows.Forms.Label lblRepetirContrasenya;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnDarseDeAlta;
    }
}