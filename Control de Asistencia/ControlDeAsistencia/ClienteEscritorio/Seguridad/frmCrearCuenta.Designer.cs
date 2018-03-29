namespace ClienteEscritorio.Seguridad
{
    partial class frmCrearCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearCuenta));
            this.sSCrearCuenta = new System.Windows.Forms.StatusStrip();
            this.btnRegistrar = new System.Windows.Forms.ToolStripButton();
            this.tsCrearCuenta = new System.Windows.Forms.ToolStrip();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.epCrearCuenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tsCrearCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCrearCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // sSCrearCuenta
            // 
            this.sSCrearCuenta.Location = new System.Drawing.Point(0, 301);
            this.sSCrearCuenta.Name = "sSCrearCuenta";
            this.sSCrearCuenta.Size = new System.Drawing.Size(425, 22);
            this.sSCrearCuenta.TabIndex = 27;
            this.sSCrearCuenta.Text = "statusStrip1";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(23, 22);
            this.btnRegistrar.Text = "Grabar";
            this.btnRegistrar.ToolTipText = "Grabar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tsCrearCuenta
            // 
            this.tsCrearCuenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrar,
            this.btnCancelar});
            this.tsCrearCuenta.Location = new System.Drawing.Point(0, 0);
            this.tsCrearCuenta.Name = "tsCrearCuenta";
            this.tsCrearCuenta.Size = new System.Drawing.Size(425, 25);
            this.tsCrearCuenta.TabIndex = 26;
            this.tsCrearCuenta.Text = "toolStrip1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTipText = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epCrearCuenta
            // 
            this.epCrearCuenta.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCrearCuenta.ContainerControl = this;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(110, 251);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(115, 20);
            this.dtpNacimiento.TabIndex = 25;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(20, 258);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(63, 13);
            this.lblNacimiento.TabIndex = 24;
            this.lblNacimiento.Text = "Nacimiento:";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(110, 206);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(121, 21);
            this.cboSexo.TabIndex = 23;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(20, 214);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 22;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(110, 162);
            this.txtNroDocumento.MaxLength = 15;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtNroDocumento.TabIndex = 21;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(20, 169);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(70, 13);
            this.lblNumeroDocumento.TabIndex = 20;
            this.lblNumeroDocumento.Text = "Numero Doc:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(110, 117);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDocumento.TabIndex = 19;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(20, 125);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(54, 13);
            this.lblTipoDocumento.TabIndex = 18;
            this.lblTipoDocumento.Text = "Tipo Doc:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(110, 79);
            this.txtApellidos.MaxLength = 100;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(236, 20);
            this.txtApellidos.TabIndex = 17;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(20, 86);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 16;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 47);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 323);
            this.Controls.Add(this.sSCrearCuenta);
            this.Controls.Add(this.tsCrearCuenta);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCrearCuenta";
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.frmCrearCuenta_Load);
            this.tsCrearCuenta.ResumeLayout(false);
            this.tsCrearCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCrearCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sSCrearCuenta;
        private System.Windows.Forms.ToolStripButton btnRegistrar;
        private System.Windows.Forms.ToolStrip tsCrearCuenta;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ErrorProvider epCrearCuenta;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}