
namespace KemishMusic
{
    partial class Perfil
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
            this.picFotoPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEditarPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.panelPlaylist = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.panelCanciones = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblDescripcion = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblNombreUsuario = new Guna.UI.WinForms.GunaLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.lblMensajeCancion = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panelPlaylist.SuspendLayout();
            this.panelCanciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // picFotoPerfil
            // 
            this.picFotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.picFotoPerfil.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picFotoPerfil.Location = new System.Drawing.Point(12, 0);
            this.picFotoPerfil.Name = "picFotoPerfil";
            this.picFotoPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picFotoPerfil.ShadowDecoration.Parent = this.picFotoPerfil;
            this.picFotoPerfil.Size = new System.Drawing.Size(200, 200);
            this.picFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfil.TabIndex = 1;
            this.picFotoPerfil.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.Controls.Add(this.btnEditarPerfil);
            this.guna2Panel1.Controls.Add(this.panelPlaylist);
            this.guna2Panel1.Controls.Add(this.gunaLabel4);
            this.guna2Panel1.Controls.Add(this.panelCanciones);
            this.guna2Panel1.Controls.Add(this.gunaLabel3);
            this.guna2Panel1.Controls.Add(this.lblDescripcion);
            this.guna2Panel1.Controls.Add(this.gunaLabel2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 200);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1062, 368);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.CheckedState.Parent = this.btnEditarPerfil;
            this.btnEditarPerfil.CustomImages.Parent = this.btnEditarPerfil;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEditarPerfil.HoverState.Parent = this.btnEditarPerfil;
            this.btnEditarPerfil.Location = new System.Drawing.Point(779, 12);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.ShadowDecoration.Parent = this.btnEditarPerfil;
            this.btnEditarPerfil.Size = new System.Drawing.Size(180, 45);
            this.btnEditarPerfil.TabIndex = 9;
            this.btnEditarPerfil.Text = "Editar perfil";
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // panelPlaylist
            // 
            this.panelPlaylist.AutoScroll = true;
            this.panelPlaylist.Controls.Add(this.lblPlaylist);
            this.panelPlaylist.Location = new System.Drawing.Point(12, 481);
            this.panelPlaylist.Name = "panelPlaylist";
            this.panelPlaylist.ShadowDecoration.Parent = this.panelPlaylist;
            this.panelPlaylist.Size = new System.Drawing.Size(987, 395);
            this.panelPlaylist.TabIndex = 8;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Circular Std Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(12, 443);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(123, 35);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Playlists";
            // 
            // panelCanciones
            // 
            this.panelCanciones.AutoScroll = true;
            this.panelCanciones.Controls.Add(this.lblMensajeCancion);
            this.panelCanciones.Location = new System.Drawing.Point(1, 136);
            this.panelCanciones.Name = "panelCanciones";
            this.panelCanciones.ShadowDecoration.Parent = this.panelCanciones;
            this.panelCanciones.Size = new System.Drawing.Size(992, 271);
            this.panelCanciones.TabIndex = 7;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Circular Std Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(12, 98);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(153, 35);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Canciones";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.Location = new System.Drawing.Point(26, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "lblDescripcion";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Circular Std Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 12);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(174, 35);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Descripción";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Circular Std Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(218, 139);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(257, 35);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "lblNombreUsuario";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblID.Location = new System.Drawing.Point(220, 80);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 20);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "lblID";
            // 
            // lblMensajeCancion
            // 
            this.lblMensajeCancion.AutoSize = true;
            this.lblMensajeCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeCancion.Location = new System.Drawing.Point(325, 126);
            this.lblMensajeCancion.Name = "lblMensajeCancion";
            this.lblMensajeCancion.Size = new System.Drawing.Size(353, 29);
            this.lblMensajeCancion.TabIndex = 2;
            this.lblMensajeCancion.Text = "Este usuario no tiene canciones";
            this.lblMensajeCancion.Visible = false;
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.Location = new System.Drawing.Point(330, 183);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(318, 29);
            this.lblPlaylist.TabIndex = 2;
            this.lblPlaylist.Text = "Este usuario no tiene playlist";
            this.lblPlaylist.Visible = false;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 568);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.picFotoPerfil);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelPlaylist.ResumeLayout(false);
            this.panelPlaylist.PerformLayout();
            this.panelCanciones.ResumeLayout(false);
            this.panelCanciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picFotoPerfil;
        private Guna.UI.WinForms.GunaLabel lblNombreUsuario;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelPlaylist;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblDescripcion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI2.WinForms.Guna2Button btnEditarPerfil;
        private Guna.UI2.WinForms.Guna2Panel panelCanciones;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblMensajeCancion;
    }
}