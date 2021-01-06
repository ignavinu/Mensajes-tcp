namespace server_v2
{
    partial class frmServer
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
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.txtMensajes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(48, 12);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 0;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(13, 15);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(214, 18);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 2;
            this.lblPuerto.Text = "Puerto";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(258, 12);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 20);
            this.txtPuerto.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(482, 18);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(611, 18);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 23);
            this.btnFin.TabIndex = 5;
            this.btnFin.Text = "Parar";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // txtMensajes
            // 
            this.txtMensajes.Location = new System.Drawing.Point(16, 47);
            this.txtMensajes.Multiline = true;
            this.txtMensajes.Name = "txtMensajes";
            this.txtMensajes.Size = new System.Drawing.Size(670, 167);
            this.txtMensajes.TabIndex = 6;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 252);
            this.Controls.Add(this.txtMensajes);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.txtHost);
            this.Name = "frmServer";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtMensajes;
    }
}

