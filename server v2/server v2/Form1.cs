using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace server_v2
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void frmServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //enter
            server.StringEncoder = Encoding.UTF8; //encoding en 8-bits
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtMensajes.Invoke((MethodInvoker)delegate ()
            {
                txtMensajes.Text += e.MessageString;
                e.ReplyLine(string.Format("Mensaje: {0}", e.MessageString));
            });
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            txtMensajes.Text += "Iniciando servidor...";
            System.Net.IPAddress miIp = System.Net.IPAddress.Parse(txtHost.Text);
            server.Start(miIp, Convert.ToInt32(txtPuerto.Text));
            txtMensajes.Text += "Servidor listo";
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
