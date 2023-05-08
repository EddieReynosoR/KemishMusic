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
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.panelAgregar = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(49, 38);
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
            // btnAgregar
            // 
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Location = new System.Drawing.Point(110, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(180, 45);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Canciones";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelAgregar
            // 
            this.panelAgregar.Location = new System.Drawing.Point(95, 355);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.ShadowDecoration.Parent = this.panelAgregar;
            this.panelAgregar.Size = new System.Drawing.Size(980, 243);
            this.panelAgregar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Crear_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPlaylist);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Crear_Playlist";
            this.Text = "Crear_Playlist";
            this.Load += new System.EventHandler(this.Crear_Playlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaylist;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Panel panelAgregar;
        private System.Windows.Forms.Label label1;
    }
}