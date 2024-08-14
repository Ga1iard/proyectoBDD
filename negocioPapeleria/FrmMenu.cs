using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negocioPapeleria
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void abrirFormHija(object formhija)
        {
            if (this.pnlFondo.Controls.Count > 0)
                this.pnlFondo.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlFondo.Controls.Add(fh);
            this.pnlFondo.Tag = fh;
            fh.Show();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmRegistrarVentas());
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmRegistro());
        }

        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmProductosExistentes());
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
