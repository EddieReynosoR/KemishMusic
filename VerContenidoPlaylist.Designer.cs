
namespace KemishMusic
{
    partial class VerContenidoPlaylist
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNombrePlaylist = new Guna.UI.WinForms.GunaLabel();
            this.lblPropietario = new Guna.UI.WinForms.GunaLabel();
            this.btnInsertarCancion = new Guna.UI2.WinForms.Guna2Button();
            this.panelCancionesPlaylist = new Guna.UI2.WinForms.Guna2Panel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.btnReproducirPlaylist = new FontAwesome.Sharp.IconPictureBox();
            this.btnAtras = new FontAwesome.Sharp.IconPictureBox();
            this.picPlaylistSelect = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReproducirPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylistSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblID);
            this.guna2Panel1.Controls.Add(this.btnReproducirPlaylist);
            this.guna2Panel1.Controls.Add(this.btnInsertarCancion);
            this.guna2Panel1.Controls.Add(this.btnAtras);
            this.guna2Panel1.Controls.Add(this.lblPropietario);
            this.guna2Panel1.Controls.Add(this.lblNombrePlaylist);
            this.guna2Panel1.Controls.Add(this.picPlaylistSelect);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1076, 277);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblNombrePlaylist
            // 
            this.lblNombrePlaylist.AutoSize = true;
            this.lblNombrePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePlaylist.Font = new System.Drawing.Font("Circular Std Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlaylist.Location = new System.Drawing.Point(267, 143);
            this.lblNombrePlaylist.Name = "lblNombrePlaylist";
            this.lblNombrePlaylist.Size = new System.Drawing.Size(251, 35);
            this.lblNombrePlaylist.TabIndex = 4;
            this.lblNombrePlaylist.Text = "lblNombrePlaylist";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPropietario.Location = new System.Drawing.Point(269, 191);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(100, 20);
            this.lblPropietario.TabIndex = 6;
            this.lblPropietario.Text = "lblPropietario";
            // 
            // btnInsertarCancion
            // 
            this.btnInsertarCancion.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertarCancion.BorderRadius = 20;
            this.btnInsertarCancion.CheckedState.Parent = this.btnInsertarCancion;
            this.btnInsertarCancion.CustomImages.Parent = this.btnInsertarCancion;
            this.btnInsertarCancion.FillColor = System.Drawing.Color.Black;
            this.btnInsertarCancion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsertarCancion.ForeColor = System.Drawing.Color.White;
            this.btnInsertarCancion.HoverState.Parent = this.btnInsertarCancion;
            this.btnInsertarCancion.Location = new System.Drawing.Point(868, 217);
            this.btnInsertarCancion.Name = "btnInsertarCancion";
            this.btnInsertarCancion.ShadowDecoration.Enabled = true;
            this.btnInsertarCancion.ShadowDecoration.Parent = this.btnInsertarCancion;
            this.btnInsertarCancion.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnInsertarCancion.Size = new System.Drawing.Size(180, 45);
            this.btnInsertarCancion.TabIndex = 8;
            this.btnInsertarCancion.Text = "Añadir canciones";
            this.btnInsertarCancion.Visible = false;
            this.btnInsertarCancion.Click += new System.EventHandler(this.btnInsertarCancion_Click);
            // 
            // panelCancionesPlaylist
            // 
            this.panelCancionesPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCancionesPlaylist.Location = new System.Drawing.Point(0, 277);
            this.panelCancionesPlaylist.Name = "panelCancionesPlaylist";
            this.panelCancionesPlaylist.ShadowDecoration.Parent = this.panelCancionesPlaylist;
            this.panelCancionesPlaylist.Size = new System.Drawing.Size(1076, 275);
            this.panelCancionesPlaylist.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblID.Location = new System.Drawing.Point(269, 230);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 20);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "gunaLabel1";
            this.lblID.Visible = false;
            // 
            // btnReproducirPlaylist
            // 
            this.btnReproducirPlaylist.BackColor = System.Drawing.SystemColors.Control;
            this.btnReproducirPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReproducirPlaylist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReproducirPlaylist.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnReproducirPlaylist.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnReproducirPlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReproducirPlaylist.IconSize = 65;
            this.btnReproducirPlaylist.Location = new System.Drawing.Point(560, 129);
            this.btnReproducirPlaylist.Name = "btnReproducirPlaylist";
            this.btnReproducirPlaylist.Size = new System.Drawing.Size(65, 65);
            this.btnReproducirPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReproducirPlaylist.TabIndex = 9;
            this.btnReproducirPlaylist.TabStop = false;
            this.btnReproducirPlaylist.Click += new System.EventHandler(this.btnReproducirPlaylist_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnAtras.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.IconSize = 40;
            this.btnAtras.Location = new System.Drawing.Point(12, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(40, 40);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 7;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // picPlaylistSelect
            // 
            this.picPlaylistSelect.BorderRadius = 20;
            this.picPlaylistSelect.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picPlaylistSelect.Location = new System.Drawing.Point(35, 62);
            this.picPlaylistSelect.Name = "picPlaylistSelect";
            this.picPlaylistSelect.ShadowDecoration.Parent = this.picPlaylistSelect;
            this.picPlaylistSelect.Size = new System.Drawing.Size(198, 200);
            this.picPlaylistSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlaylistSelect.TabIndex = 0;
            this.picPlaylistSelect.TabStop = false;
            // 
            // VerContenidoPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 552);
            this.Controls.Add(this.panelCancionesPlaylist);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerContenidoPlaylist";
            this.Text = "VerContenidoPlaylist";
            this.Load += new System.EventHandler(this.VerContenidoPlaylist_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReproducirPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylistSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picPlaylistSelect;
        private Guna.UI.WinForms.GunaLabel lblNombrePlaylist;
        private FontAwesome.Sharp.IconPictureBox btnReproducirPlaylist;
        private Guna.UI2.WinForms.Guna2Button btnInsertarCancion;
        private FontAwesome.Sharp.IconPictureBox btnAtras;
        private Guna.UI.WinForms.GunaLabel lblPropietario;
        private Guna.UI2.WinForms.Guna2Panel panelCancionesPlaylist;
        private Guna.UI.WinForms.GunaLabel lblID;
    }
}