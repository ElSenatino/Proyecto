namespace ClienteEscritorio.Seguridad
{
    partial class frmIniciarSesion
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
            this.components = new System.ComponentModel.Container();
            this.ssBarra = new System.Windows.Forms.StatusStrip();
            this.tsslNombreEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOlvideMiContrasena = new System.Windows.Forms.LinkLabel();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.lblNoTieneCuenta = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.tmIniciarSesion = new System.Windows.Forms.Timer(this.components);
            this.ssBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssBarra
            // 
            this.ssBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNombreEmpresa});
            this.ssBarra.Location = new System.Drawing.Point(0, 295);
            this.ssBarra.Name = "ssBarra";
            this.ssBarra.Size = new System.Drawing.Size(297, 22);
            this.ssBarra.TabIndex = 25;
            this.ssBarra.Text = "statusStrip1";
            // 
            // tsslNombreEmpresa
            // 
            this.tsslNombreEmpresa.Name = "tsslNombreEmpresa";
            this.tsslNombreEmpresa.Size = new System.Drawing.Size(282, 17);
            this.tsslNombreEmpresa.Spring = true;
            // 
            // lblOlvideMiContrasena
            // 
            this.lblOlvideMiContrasena.AutoSize = true;
            this.lblOlvideMiContrasena.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvideMiContrasena.Location = new System.Drawing.Point(64, 232);
            this.lblOlvideMiContrasena.Name = "lblOlvideMiContrasena";
            this.lblOlvideMiContrasena.Size = new System.Drawing.Size(159, 13);
            this.lblOlvideMiContrasena.TabIndex = 32;
            this.lblOlvideMiContrasena.TabStop = true;
            this.lblOlvideMiContrasena.Text = "He olvidado mi contraseña";
            this.lblOlvideMiContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvideMiContrasena_LinkClicked);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(80, 10);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(118, 18);
            this.lblIniciarSesion.TabIndex = 31;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(160, 189);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(85, 13);
            this.lblCrearCuenta.TabIndex = 30;
            this.lblCrearCuenta.TabStop = true;
            this.lblCrearCuenta.Text = "Crear Cuenta";
            this.lblCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCrearCuenta_LinkClicked);
            // 
            // lblNoTieneCuenta
            // 
            this.lblNoTieneCuenta.AutoSize = true;
            this.lblNoTieneCuenta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTieneCuenta.Location = new System.Drawing.Point(40, 189);
            this.lblNoTieneCuenta.Name = "lblNoTieneCuenta";
            this.lblNoTieneCuenta.Size = new System.Drawing.Size(114, 13);
            this.lblNoTieneCuenta.TabIndex = 29;
            this.lblNoTieneCuenta.Text = "¿No Tiene Cuenta?";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(20, 140);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(252, 28);
            this.btnIniciarSesion.TabIndex = 28;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(20, 92);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(252, 21);
            this.txtContrasena.TabIndex = 27;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(20, 57);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(252, 21);
            this.txtUsuario.TabIndex = 26;
            // 
            // tmIniciarSesion
            // 
            this.tmIniciarSesion.Interval = 1000;
            this.tmIniciarSesion.Tick += new System.EventHandler(this.tmIniciarSesion_Tick);
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 317);
            this.Controls.Add(this.ssBarra);
            this.Controls.Add(this.lblOlvideMiContrasena);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.lblCrearCuenta);
            this.Controls.Add(this.lblNoTieneCuenta);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIniciarSesion";
            this.ssBarra.ResumeLayout(false);
            this.ssBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssBarra;
        private System.Windows.Forms.ToolStripStatusLabel tsslNombreEmpresa;
        private System.Windows.Forms.LinkLabel lblOlvideMiContrasena;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.LinkLabel lblCrearCuenta;
        private System.Windows.Forms.Label lblNoTieneCuenta;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Timer tmIniciarSesion;
    }
}