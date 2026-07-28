namespace Punto_de_venta_taqueria
{
    partial class LoginPermisos
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
            this.cmbusuarios = new System.Windows.Forms.ComboBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbusuarios
            // 
            this.cmbusuarios.FormattingEnabled = true;
            this.cmbusuarios.Location = new System.Drawing.Point(58, 36);
            this.cmbusuarios.Name = "cmbusuarios";
            this.cmbusuarios.Size = new System.Drawing.Size(121, 21);
            this.cmbusuarios.TabIndex = 0;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(58, 89);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(121, 20);
            this.txtcontrasena.TabIndex = 1;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(82, 125);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // LoginPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 165);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.cmbusuarios);
            this.Name = "LoginPermisos";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbusuarios;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Button btningresar;
    }
}