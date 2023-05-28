namespace KemishMusic.Formularios
{
    partial class CancionesShow
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
            this.panelCancion = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNombreUsuario = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panelPlaylist = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMensajeCancionBiblio = new System.Windows.Forms.Label();
            this.lblMensajePlaylistBiblio = new System.Windows.Forms.Label();
            this.panelCancion.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCancion
            // 
            this.panelCancion.AutoScroll = true;
            this.panelCancion.Controls.Add(this.lblMensajeCancionBiblio);
            this.panelCancion.Location = new System.Drawing.Point(0, 61);
            this.panelCancion.Name = "panelCancion";
            this.panelCancion.ShadowDecoration.Parent = this.panelCancion;
            this.panelCancion.Size = new System.Drawing.Size(925, 305);
            this.panelCancion.TabIndex = 0;
            this.panelCancion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCancion_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblNombreUsuario);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(925, 61);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Circular Std Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 14);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(200, 35);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Tus canciones";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.gunaLabel1);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 366);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(925, 61);
            this.guna2Panel2.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Circular Std Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(175, 35);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Tus playlists";
            // 
            // panelPlaylist
            // 
            this.panelPlaylist.AutoScroll = true;
            this.panelPlaylist.Controls.Add(this.lblMensajePlaylistBiblio);
            this.panelPlaylist.Location = new System.Drawing.Point(3, 426);
            this.panelPlaylist.Name = "panelPlaylist";
            this.panelPlaylist.ShadowDecoration.Parent = this.panelPlaylist;
            this.panelPlaylist.Size = new System.Drawing.Size(922, 429);
            this.panelPlaylist.TabIndex = 1;
            // 
            // lblMensajeCancionBiblio
            // 
            this.lblMensajeCancionBiblio.AutoSize = true;
            this.lblMensajeCancionBiblio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeCancionBiblio.Location = new System.Drawing.Point(299, 138);
            this.lblMensajeCancionBiblio.Name = "lblMensajeCancionBiblio";
            this.lblMensajeCancionBiblio.Size = new System.Drawing.Size(357, 29);
            this.lblMensajeCancionBiblio.TabIndex = 2;
            this.lblMensajeCancionBiblio.Text = "No tienes canciones registradas";
            this.lblMensajeCancionBiblio.Visible = false;
            // 
            // lblMensajePlaylistBiblio
            // 
            this.lblMensajePlaylistBiblio.AutoSize = true;
            this.lblMensajePlaylistBiblio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajePlaylistBiblio.Location = new System.Drawing.Point(298, 200);
            this.lblMensajePlaylistBiblio.Name = "lblMensajePlaylistBiblio";
            this.lblMensajePlaylistBiblio.Size = new System.Drawing.Size(334, 29);
            this.lblMensajePlaylistBiblio.TabIndex = 3;
            this.lblMensajePlaylistBiblio.Text = "No tienes playlists registradas";
            this.lblMensajePlaylistBiblio.Visible = false;
            // 
            // CancionesShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 515);
            this.Controls.Add(this.panelPlaylist);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelCancion);
            this.Name = "CancionesShow";
            this.Text = "CancionesShow";
            this.Load += new System.EventHandler(this.CancionesShow_Load);
            this.panelCancion.ResumeLayout(false);
            this.panelCancion.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panelPlaylist.ResumeLayout(false);
            this.panelPlaylist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelCancion;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panelPlaylist;
        private Guna.UI.WinForms.GunaLabel lblNombreUsuario;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label lblMensajeCancionBiblio;
        private System.Windows.Forms.Label lblMensajePlaylistBiblio;
    }
}