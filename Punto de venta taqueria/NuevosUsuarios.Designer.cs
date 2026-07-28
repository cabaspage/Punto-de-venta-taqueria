namespace Punto_de_venta_taqueria
{
    partial class NuevosUsuarios
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidop = new System.Windows.Forms.TextBox();
            this.txtapellidom = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellidop = new System.Windows.Forms.Label();
            this.lblapellidom = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(71, 62);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(151, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtapellidop
            // 
            this.txtapellidop.Location = new System.Drawing.Point(287, 61);
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(151, 20);
            this.txtapellidop.TabIndex = 1;
            this.txtapellidop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidop_KeyPress);
            // 
            // txtapellidom
            // 
            this.txtapellidom.Location = new System.Drawing.Point(495, 61);
            this.txtapellidom.Name = "txtapellidom";
            this.txtapellidom.Size = new System.Drawing.Size(162, 20);
            this.txtapellidom.TabIndex = 2;
            this.txtapellidom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidom_KeyPress);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(154, 132);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(159, 20);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(401, 131);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(194, 20);
            this.txtcontraseña.TabIndex = 4;
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(71, 43);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(55, 13);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Nombre(s)";
            // 
            // lblapellidop
            // 
            this.lblapellidop.AutoSize = true;
            this.lblapellidop.Location = new System.Drawing.Point(287, 42);
            this.lblapellidop.Name = "lblapellidop";
            this.lblapellidop.Size = new System.Drawing.Size(84, 13);
            this.lblapellidop.TabIndex = 6;
            this.lblapellidop.Text = "Apellido Paterno";
            // 
            // lblapellidom
            // 
            this.lblapellidom.AutoSize = true;
            this.lblapellidom.Location = new System.Drawing.Point(495, 41);
            this.lblapellidom.Name = "lblapellidom";
            this.lblapellidom.Size = new System.Drawing.Size(86, 13);
            this.lblapellidom.TabIndex = 7;
            this.lblapellidom.Text = "Apellido Materno";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(154, 113);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 8;
            this.lblusuario.Text = "Usuario";
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(401, 112);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(61, 13);
            this.lblcontrasena.TabIndex = 9;
            this.lblcontrasena.Text = "Contraseña";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(323, 173);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // NuevosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 217);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblcontrasena);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblapellidom);
            this.Controls.Add(this.lblapellidop);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtapellidom);
            this.Controls.Add(this.txtapellidop);
            this.Controls.Add(this.txtnombre);
            this.Name = "NuevosUsuarios";
            this.Text = "Nuevos Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidop;
        private System.Windows.Forms.TextBox txtapellidom;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellidop;
        private System.Windows.Forms.Label lblapellidom;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.Button btnregistrar;
    }
}