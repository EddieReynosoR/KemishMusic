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
            this.lblNombre = new Guna.UI.WinForms.GunaLabel();
            this.txtPlaylist = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.Location = new System.Drawing.Point(423, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(151, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre de la Playlist";
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
            this.txtPlaylist.Location = new System.Drawing.Point(344, 87);
            this.txtPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtPlaylist.PasswordChar = '\0';
            this.txtPlaylist.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtPlaylist.PlaceholderText = "";
            this.txtPlaylist.SelectedText = "";
            this.txtPlaylist.ShadowDecoration.Parent = this.txtPlaylist;
            this.txtPlaylist.Size = new System.Drawing.Size(314, 40);
            this.txtPlaylist.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.CheckedState.Parent = this.btnCrear;
            this.btnCrear.CustomImages.Parent = this.btnCrear;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.HoverState.Parent = this.btnCrear;
            this.btnCrear.Location = new System.Drawing.Point(417, 134);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.ShadowDecoration.Parent = this.btnCrear;
            this.btnCrear.Size = new System.Drawing.Size(175, 37);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear Playlist";
            this.btnCrear.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Crear_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 591);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtPlaylist);
            this.Controls.Add(this.lblNombre);
            this.Name = "Crear_Playlist";
            this.Text = "Crear_Playlist";
            this.Load += new System.EventHandler(this.Crear_Playlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaylist;
        private Guna.UI2.WinForms.Guna2Button btnCrear;
    }
}