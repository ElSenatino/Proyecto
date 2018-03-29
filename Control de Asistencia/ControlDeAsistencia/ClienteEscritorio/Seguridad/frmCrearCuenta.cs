using ClienteEscritorio;
using ClienteEscritorio.PersonaService;
using Entidad;
using Entidad.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEscritorio.Seguridad
{
    public partial class frmCrearCuenta : Form
    {
        #region  variables 
        string rMensaje = "Ocurrio un error:";
        #endregion

        #region Constructor
        public frmCrearCuenta()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos del Sistema
        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {
            Global.DeshabilitarBotonCerrar(this.Handle.ToInt32());
            LLenarCombo();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("¿Desea Registrar Cuenta?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Validar())
                    {
                        Byte[] b = new Byte[10];
                        PersonaService.CPersonaClient x = new PersonaService.CPersonaClient();
                        EPersona customer = new EPersona
                        {

                            NombreGenerado = txtApellidos.Text + " " + txtNombre.Text,
                            Nombre = txtNombre.Text,
                            Apellidos = txtApellidos.Text,
                            NroDocumento = txtNroDocumento.Text,
                            Nacimiento = dtpNacimiento.Value,
                            Imagen = b,
                            TipoDocumento = cboTipoDocumento.SelectedIndex,
                            TipoSexo = cboSexo.SelectedIndex,
                            Habilitado = false,
                            Codigo = txtNombre.Text.Trim().Substring(0, 2).ToUpper() + txtNroDocumento.Text.Trim().Substring(0, 3),
                            Acutalizacion = DateTime.Now
                        };


                        bool success = x.CrearCuenta(customer);
                        MessageBox.Show("Cuenta creda correctamente , Debe comunicarse con el administrador para habilitarla correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(rMensaje + " " + ex.Message , "Mensaje de Error" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos Creados 
        private void LLenarCombo()
        {
            try
            {
                foreach (var item in Enum.GetValues(typeof(Entidad.Enumeradores.DocumentoTipo)))
                {
                    cboTipoDocumento.Items.Add(item);
                }

                foreach (var item in Enum.GetValues(typeof(Entidad.Enumeradores.SexoTipo)))
                {
                    cboSexo.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(rMensaje + " " + ex.Message);
            }
        }
        private bool Validar()
        {
            if (txtNombre.Text.Trim().Length >= 100)
            {
                epCrearCuenta.SetError(txtNombre, "Debe ingresar un nombre válido");
                return false;
            }
            else
            {
                epCrearCuenta.SetError(txtNombre, null);
            }

            if (txtApellidos.Text.Trim().Length >= 100)
            {
                epCrearCuenta.SetError(txtApellidos, "Debe ingresar apellidos válido");
                return false;
            }
            else
            {
                epCrearCuenta.SetError(txtApellidos, null);
            }

            if (cboTipoDocumento.SelectedIndex < 0)
            {
                epCrearCuenta.SetError(cboTipoDocumento, "Debe seleccionar un tipo de documento válido");
                return false;
            }
            else
            {
                epCrearCuenta.SetError(cboTipoDocumento, null);
            }

            if (txtNroDocumento.Text.Trim().Length >= 15)
            {
                epCrearCuenta.SetError(txtNroDocumento, "Debe ingresar un número de documento válido");
                return false;
            }
            else
            {
                epCrearCuenta.SetError(txtNroDocumento, null);
            }

            if (cboSexo.SelectedIndex < 0)
            {
                epCrearCuenta.SetError(cboSexo, "Debe seleccionar un tipo de sexo válido");
                return false;
            }
            else
            {
                epCrearCuenta.SetError(cboSexo, null);
            }

            if (Global.CalcularEdad(dtpNacimiento.Value) < 18)
            {
                epCrearCuenta.SetError(dtpNacimiento, "Fecha ingresada no es válida");
                return false;
            }
            else
            {
                epCrearCuenta.SetError(dtpNacimiento, null);
            }

            return true;
        }

        #endregion

       
    }
}
