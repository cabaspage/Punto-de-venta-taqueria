namespace Punto_de_venta_taqueria
{
    partial class FormLogin
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
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.cmbusuario = new System.Windows.Forms.ComboBox();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(99, 88);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(244, 20);
            this.txtcontrasena.TabIndex = 0;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(181, 120);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 1;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // cmbusuario
            // 
            this.cmbusuario.FormattingEnabled = true;
            this.cmbusuario.Location = new System.Drawing.Point(99, 47);
            this.cmbusuario.Name = "cmbusuario";
            this.cmbusuario.Size = new System.Drawing.Size(244, 21);
            this.cmbusuario.TabIndex = 2;
            this.cmbusuario.DropDown += new System.EventHandler(this.cmbusuario_DropDown);
            // 
            // btnusuarios
            // 
            this.btnusuarios.Location = new System.Drawing.Point(168, 149);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(109, 23);
            this.btnusuarios.TabIndex = 3;
            this.btnusuarios.Text = "Nuevo Usuario";
            this.btnusuarios.UseVisualStyleBackColor = true;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(99, 28);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "Usuario";
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(99, 72);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(61, 13);
            this.lblcontrasena.TabIndex = 5;
            this.lblcontrasena.Text = "Contraseña";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 198);
            this.Controls.Add(this.lblcontrasena);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnusuarios);
            this.Controls.Add(this.cmbusuario);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontrasena);
            this.Name = "FormLogin";
            this.Text = "POS Taqueria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.ComboBox cmbusuario;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontrasena;
    }
}

