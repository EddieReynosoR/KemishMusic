namespace KemishMusic.Formularios
{
    partial class Crear_Playlist
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtPlaylist = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.picPlaylistNueva = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnInsertarPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeleccionarImagenPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.lblRutaImagen = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylistNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(59, 43);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(151, 20);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Nombre de la Playlist";
            // 
            // txtPlaylist
            // 
            this.txtPlaylist.BorderRadius = 26;
            this.txtPlaylist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaylist.DefaultText = "";
            this.txtPlaylist.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaylist.DisabledState.Parent = this.txtPlaylist;
            this.txtPlaylist.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaylist.FillColor = System.Drawing.Color.Gainsboro;
            this.txtPlaylist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaylist.FocusedState.Parent = this.txtPlaylist;
            this.txtPlaylist.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaylist.HoverState.Parent = this.txtPlaylist;
            this.txtPlaylist.Location = new System.Drawing.Point(63, 78);
            this.txtPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtPlaylist.PasswordChar = '\0';
            this.txtPlaylist.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtPlaylist.PlaceholderText = "";
            this.txtPlaylist.SelectedText = "";
            this.txtPlaylist.ShadowDecoration.Parent = this.txtPlaylist;
            this.txtPlaylist.Size = new System.Drawing.Size(330, 55);
            this.txtPlaylist.TabIndex = 9;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(59, 169);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(150, 20);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "Imagen de la playlist:";
            // 
            // picPlaylistNueva
            // 
            this.picPlaylistNueva.Location = new System.Drawing.Point(63, 192);
            this.picPlaylistNueva.Name = "picPlaylistNueva";
            this.picPlaylistNueva.ShadowDecoration.Parent = this.picPlaylistNueva;
            this.picPlaylistNueva.Size = new System.Drawing.Size(278, 242);
            this.picPlaylistNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlaylistNueva.TabIndex = 11;
            this.picPlaylistNueva.TabStop = false;
            // 
            // btnInsertarPlaylist
            // 
            this.btnInsertarPlaylist.BorderRadius = 20;
            this.btnInsertarPlaylist.CheckedState.Parent = this.btnInsertarPlaylist;
            this.btnInsertarPlaylist.CustomImages.Parent = this.btnInsertarPlaylist;
            this.btnInsertarPlaylist.FillColor = System.Drawing.Color.Gold;
            this.btnInsertarPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInsertarPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnInsertarPlaylist.HoverState.Parent = this.btnInsertarPlaylist;
            this.btnInsertarPlaylist.Location = new System.Drawing.Point(433, 456);
            this.btnInsertarPlaylist.Name = "btnInsertarPlaylist";
            this.btnInsertarPlaylist.ShadowDecoration.Parent = this.btnInsertarPlaylist;
            this.btnInsertarPlaylist.Size = new System.Drawing.Size(225, 45);
            this.btnInsertarPlaylist.TabIndex = 12;
            this.btnInsertarPlaylist.Text = "Agregar playlist";
            this.btnInsertarPlaylist.Click += new System.EventHandler(this.btnInsertarPlaylist_Click);
            // 
            // btnSeleccionarImagenPlaylist
            // 
            this.btnSeleccionarImagenPlaylist.BorderRadius = 20;
            this.btnSeleccionarImagenPlaylist.CheckedState.Parent = this.btnSeleccionarImagenPlaylist;
            this.btnSeleccionarImagenPlaylist.CustomImages.Parent = this.btnSeleccionarImagenPlaylist;
            this.btnSeleccionarImagenPlaylist.FillColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarImagenPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionarImagenPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarImagenPlaylist.HoverState.Parent = this.btnSeleccionarImagenPlaylist;
            this.btnSeleccionarImagenPlaylist.Location = new System.Drawing.Point(88, 456);
            this.btnSeleccionarImagenPlaylist.Name = "btnSeleccionarImagenPlaylist";
            this.btnSeleccionarImagenPlaylist.ShadowDecoration.Parent = this.btnSeleccionarImagenPlaylist;
            this.btnSeleccionarImagenPlaylist.Size = new System.Drawing.Size(225, 45);
            this.btnSeleccionarImagenPlaylist.TabIndex = 13;
            this.btnSeleccionarImagenPlaylist.Text = "Seleccionar nueva imágen";
            this.btnSeleccionarImagenPlaylist.Click += new System.EventHandler(this.btnSeleccionarImagenPlaylist_Click);
            // 
            // lblRutaImagen
            // 
            this.lblRutaImagen.AutoSize = true;
            this.lblRutaImagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRutaImagen.Location = new System.Drawing.Point(418, 274);
            this.lblRutaImagen.Name = "lblRutaImagen";
            this.lblRutaImagen.Size = new System.Drawing.Size(86, 20);
            this.lblRutaImagen.TabIndex = 14;
            this.lblRutaImagen.Text = "gunaLabel3";
            // 
            // Crear_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 532);
            this.Controls.Add(this.lblRutaImagen);
            this.Controls.Add(this.btnSeleccionarImagenPlaylist);
            this.Controls.Add(this.btnInsertarPlaylist);
            this.Controls.Add(this.picPlaylistNueva);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtPlaylist);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Crear_Playlist";
            this.Text = "Crear_Playlist";
            this.Load += new System.EventHandler(this.Crear_Playlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylistNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaylist;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox picPlaylistNueva;
        private Guna.UI2.WinForms.Guna2Button btnInsertarPlaylist;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarImagenPlaylist;
        private Guna.UI.WinForms.GunaLabel lblRutaImagen;
    }
}