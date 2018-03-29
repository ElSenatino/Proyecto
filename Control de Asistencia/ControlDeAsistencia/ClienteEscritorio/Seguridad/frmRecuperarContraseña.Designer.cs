namespace ClienteEscritorio.Seguridad
{
    partial class frmRecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarContraseña));
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblDato = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.tsRecuperarCuenta = new System.Windows.Forms.ToolStrip();
            this.btnEnviar = new System.Windows.Forms.ToolStripButton();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.epRecuperarContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmCerrar = new System.Windows.Forms.Timer(this.components);
            this.ssRecuperarCuenta = new System.Windows.Forms.StatusStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.tsRecuperarCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRecuperarContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 41);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(87, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Seleccione Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "CÓDIGO"});
            this.cboTipo.Location = new System.Drawing.Point(116, 38);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(363, 21);
            this.cboTipo.TabIndex = 1;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(12, 68);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(71, 13);
            this.lblDato.TabIndex = 2;
            this.lblDato.Text = "Ingrese Dato:";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(116, 68);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(363, 20);
            this.txtDato.TabIndex = 3;
            // 
            // tsRecuperarCuenta
            // 
            this.tsRecuperarCuenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEnviar,
            this.btnSalir});
            this.tsRecuperarCuenta.Location = new System.Drawing.Point(0, 0);
            this.tsRecuperarCuenta.Name = "tsRecuperarCuenta";
            this.tsRecuperarCuenta.Size = new System.Drawing.Size(510, 25);
            this.tsRecuperarCuenta.TabIndex = 27;
            this.tsRecuperarCuenta.Text = "toolStrip1";
            // 
            // btnEnviar
            // 
            this.btnEnviar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(23, 22);
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.ToolTipText = "Grabar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(12, 91);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(317, 13);
            this.lblMensaje.TabIndex = 28;
            this.lblMensaje.Text = "Mensaje: Se le a enviado un email  donde podra obtener su clave";
            this.lblMensaje.Visible = false;
            // 
            // epRecuperarContraseña
            // 
            this.epRecuperarContraseña.ContainerControl = this;
            // 
            // tmCerrar
            // 
            this.tmCerrar.Interval = 1000;
            this.tmCerrar.Tick += new System.EventHandler(this.tmCerrar_Tick);
            // 
            // ssRecuperarCuenta
            // 
            this.ssRecuperarCuenta.Location = new System.Drawing.Point(0, 121);
            this.ssRecuperarCuenta.Name = "ssRecuperarCuenta";
            this.ssRecuperarCuenta.Size = new System.Drawing.Size(510, 22);
            this.ssRecuperarCuenta.TabIndex = 29;
            this.ssRecuperarCuenta.Text = "statusStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.ToolTipText = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 143);
            this.Controls.Add(this.ssRecuperarCuenta);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.tsRecuperarCuenta);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Contraseña";
            this.Load += new System.EventHandler(this.frnRecuperarContraseña_Load);
            this.tsRecuperarCuenta.ResumeLayout(false);
            this.tsRecuperarCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRecuperarContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ToolStrip tsRecuperarCuenta;
        private System.Windows.Forms.ToolStripButton btnEnviar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ErrorProvider epRecuperarContraseña;
        private System.Windows.Forms.Timer tmCerrar;
        private System.Windows.Forms.StatusStrip ssRecuperarCuenta;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}