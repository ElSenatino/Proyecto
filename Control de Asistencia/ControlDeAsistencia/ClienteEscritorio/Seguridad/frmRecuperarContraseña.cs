using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEscritorio.Seguridad
{
    public partial class frmRecuperarContraseña : Form
    {
        public frmRecuperarContraseña()
        {
            InitializeComponent();
           
        }

        int TiempoTotal = 5;
        private void frnRecuperarContraseña_Load(object sender, EventArgs e)
        {
            Global.DeshabilitarBotonCerrar(this.Handle.ToInt32());

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                tmCerrar.Enabled = true;
                tmCerrar.Start();

                lblMensaje.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ecepción: " + ex.Message , "Mensaje", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }
        }

        private void tmCerrar_Tick(object sender, EventArgs e)
        {
                if (TiempoTotal > 0)
                {
                    int tiempoDisponible = TiempoTotal;
                    tiempoDisponible = tiempoDisponible - 1;
                    TiempoTotal = tiempoDisponible;
                }
                else
                {
                    this.Close();
                }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
