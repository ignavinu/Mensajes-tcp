using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Mensajes_TCP
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        SimpleTcpClient cliente;

        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = false;
            cliente.Connect(txtHost.Text, Convert.ToInt32(txtPuerto.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cliente = new SimpleTcpClient();
            cliente.StringEncoder = Encoding.UTF8;
            cliente.DataReceived += Cliente_DataReceived;
        }

        private void Cliente_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtMensajes.Invoke((MethodInvoker)delegate ()
            {
                txtMensajes.Text += e.MessageString;
            });
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            cliente.WriteLineAndGetReply(txtEscribir.Text + "\n", TimeSpan.FromSeconds(3));
        }
    }
}
