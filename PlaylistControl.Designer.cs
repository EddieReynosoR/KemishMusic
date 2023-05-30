
namespace KemishMusic
{
    partial class PlaylistControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOpcionesPlaylist = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEditarPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.iconOpcionesPlaylist = new FontAwesome.Sharp.IconButton();
            this.playlistNombre = new Guna.UI.WinForms.GunaLabel();
            this.picPlaylist = new Guna.UI.WinForms.GunaPictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.playlistUsuarioID = new System.Windows.Forms.Label();
            this.panelOpcionesPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpcionesPlaylist
            // 
            this.panelOpcionesPlaylist.Controls.Add(this.btnEditarPlaylist);
            this.panelOpcionesPlaylist.Location = new System.Drawing.Point(287, 95);
            this.panelOpcionesPlaylist.Name = "panelOpcionesPlaylist";
            this.panelOpcionesPlaylist.ShadowDecoration.Parent = this.panelOpcionesPlaylist;
            this.panelOpcionesPlaylist.Size = new System.Drawing.Size(160, 85);
            this.panelOpcionesPlaylist.TabIndex = 16;
            this.panelOpcionesPlaylist.Visible = false;
            // 
            // btnEditarPlaylist
            // 
            this.btnEditarPlaylist.CheckedState.Parent = this.btnEditarPlaylist;
            this.btnEditarPlaylist.CustomImages.Parent = this.btnEditarPlaylist;
            this.btnEditarPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarPlaylist.FillColor = System.Drawing.Color.White;
            this.btnEditarPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditarPlaylist.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPlaylist.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarPlaylist.HoverState.Parent = this.btnEditarPlaylist;
            this.btnEditarPlaylist.Location = new System.Drawing.Point(0, 0);
            this.btnEditarPlaylist.Name = "btnEditarPlaylist";
            this.btnEditarPlaylist.ShadowDecoration.Parent = this.btnEditarPlaylist;
            this.btnEditarPlaylist.Size = new System.Drawing.Size(160, 51);
            this.btnEditarPlaylist.TabIndex = 3;
            this.btnEditarPlaylist.Text = "Editar playlist";
            this.btnEditarPlaylist.Visible = false;
            this.btnEditarPlaylist.Click += new System.EventHandler(this.btnEditarPlaylist_Click);
            // 
            // iconOpcionesPlaylist
            // 
            this.iconOpcionesPlaylist.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconOpcionesPlaylist.IconColor = System.Drawing.Color.Black;
            this.iconOpcionesPlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOpcionesPlaylist.Location = new System.Drawing.Point(276, 47);
            this.iconOpcionesPlaylist.Name = "iconOpcionesPlaylist";
            this.iconOpcionesPlaylist.Size = new System.Drawing.Size(52, 49);
            this.iconOpcionesPlaylist.TabIndex = 15;
            this.iconOpcionesPlaylist.UseVisualStyleBackColor = true;
            this.iconOpcionesPlaylist.Click += new System.EventHandler(this.iconOpcionesPlaylist_Click);
            // 
            // playlistNombre
            // 
            this.playlistNombre.AutoSize = true;
            this.playlistNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistNombre.Location = new System.Drawing.Point(12, 260);
            this.playlistNombre.Name = "playlistNombre";
            this.playlistNombre.Size = new System.Drawing.Size(87, 25);
            this.playlistNombre.TabIndex = 14;
            this.playlistNombre.Text = "Nombre";
            // 
            // picPlaylist
            // 
            this.picPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.picPlaylist.BaseColor = System.Drawing.Color.White;
            this.picPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlaylist.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picPlaylist.Location = new System.Drawing.Point(17, 47);
            this.picPlaylist.Name = "picPlaylist";
            this.picPlaylist.Radius = 10;
            this.picPlaylist.Size = new System.Drawing.Size(210, 210);
            this.picPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlaylist.TabIndex = 13;
            this.picPlaylist.TabStop = false;
            this.picPlaylist.Click += new System.EventHandler(this.picPlaylist_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(154, 279);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // playlistUsuarioID
            // 
            this.playlistUsuarioID.AutoSize = true;
            this.playlistUsuarioID.Location = new System.Drawing.Point(24, 311);
            this.playlistUsuarioID.Name = "playlistUsuarioID";
            this.playlistUsuarioID.Size = new System.Drawing.Size(46, 17);
            this.playlistUsuarioID.TabIndex = 18;
            this.playlistUsuarioID.Text = "label1";
            this.playlistUsuarioID.Visible = false;
            // 
            // PlaylistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.playlistUsuarioID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panelOpcionesPlaylist);
            this.Controls.Add(this.iconOpcionesPlaylist);
            this.Controls.Add(this.playlistNombre);
            this.Controls.Add(this.picPlaylist);
            this.Name = "PlaylistControl";
            this.Size = new System.Drawing.Size(486, 414);
            this.Load += new System.EventHandler(this.PlaylistControl_Load);
            this.panelOpcionesPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelOpcionesPlaylist;
        private Guna.UI2.WinForms.Guna2Button btnEditarPlaylist;
        private FontAwesome.Sharp.IconButton iconOpcionesPlaylist;
        private Guna.UI.WinForms.GunaLabel playlistNombre;
        private Guna.UI.WinForms.GunaPictureBox picPlaylist;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label playlistUsuarioID;
    }
}
