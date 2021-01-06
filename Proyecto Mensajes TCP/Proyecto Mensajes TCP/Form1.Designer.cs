namespace Proyecto_Mensajes_TCP
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.txtMensajes = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(467, 8);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(259, 12);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 20);
            this.txtPuerto.TabIndex = 7;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(215, 18);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 6;
            this.lblPuerto.Text = "Puerto";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(14, 15);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 5;
            this.lblHost.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(49, 12);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 4;
            // 
            // txtEscribir
            // 
            this.txtEscribir.Location = new System.Drawing.Point(12, 38);
            this.txtEscribir.Multiline = true;
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(534, 72);
            this.txtEscribir.TabIndex = 8;
            // 
            // txtMensajes
            // 
            this.txtMensajes.Location = new System.Drawing.Point(17, 145);
            this.txtMensajes.Multiline = true;
            this.txtMensajes.Name = "txtMensajes";
            this.txtMensajes.Size = new System.Drawing.Size(534, 184);
            this.txtMensajes.TabIndex = 9;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(467, 116);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 340);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensajes);
            this.Controls.Add(this.txtEscribir);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnConectar);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.TextBox txtMensajes;
        private System.Windows.Forms.Button btnEnviar;
    }
}

