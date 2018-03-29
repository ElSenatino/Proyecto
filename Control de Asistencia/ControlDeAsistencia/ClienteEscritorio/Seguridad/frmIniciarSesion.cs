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
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
            tmIniciarSesion.Enabled = true;
            tmIniciarSesion.Start();
        }

        int TiempoTotal = 50;

        private void lblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearCuenta _crearCuenta = new frmCrearCuenta();
            _crearCuenta.ShowDialog();
        }

        private void lblOlvideMiContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContraseña _recuperarContraseña = new frmRecuperarContraseña();
            _recuperarContraseña.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            tmIniciarSesion.Stop();
        }

        private void tmIniciarSesion_Tick(object sender, EventArgs e)
        {

            if (TiempoTotal > 0)
            {
                int tiempoC = TiempoTotal;
                tiempoC = tiempoC - 1;

                TiempoTotal = tiempoC;
            }
            else
            {
                this.Close();
            }
        }
    }
}
