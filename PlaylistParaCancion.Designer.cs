
namespace KemishMusic
{
    partial class PlaylistParaCancion
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
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.btnAgregarAPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.lblNombrePlaylist = new Guna.UI.WinForms.GunaLabel();
            this.lblAutorPlaylist = new Guna.UI.WinForms.GunaLabel();
            this.picCancionAPlaylist = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCancionAPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Circular Std Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(113, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnAgregarAPlaylist
            // 
            this.btnAgregarAPlaylist.BorderRadius = 20;
            this.btnAgregarAPlaylist.CheckedState.Parent = this.btnAgregarAPlaylist;
            this.btnAgregarAPlaylist.CustomImages.Parent = this.btnAgregarAPlaylist;
            this.btnAgregarAPlaylist.FillColor = System.Drawing.Color.Gold;
            this.btnAgregarAPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarAPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAPlaylist.HoverState.Parent = this.btnAgregarAPlaylist;
            this.btnAgregarAPlaylist.Location = new System.Drawing.Point(347, 27);
            this.btnAgregarAPlaylist.Name = "btnAgregarAPlaylist";
            this.btnAgregarAPlaylist.ShadowDecoration.Parent = this.btnAgregarAPlaylist;
            this.btnAgregarAPlaylist.Size = new System.Drawing.Size(200, 45);
            this.btnAgregarAPlaylist.TabIndex = 25;
            this.btnAgregarAPlaylist.Text = "Agregar a esta playlist";
            this.btnAgregarAPlaylist.Click += new System.EventHandler(this.btnAgregarAPlaylist_Click);
            // 
            // lblNombrePlaylist
            // 
            this.lblNombrePlaylist.AutoSize = true;
            this.lblNombrePlaylist.Font = new System.Drawing.Font("Circular Std Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlaylist.Location = new System.Drawing.Point(112, 20);
            this.lblNombrePlaylist.Name = "lblNombrePlaylist";
            this.lblNombrePlaylist.Size = new System.Drawing.Size(140, 22);
            this.lblNombrePlaylist.TabIndex = 23;
            this.lblNombrePlaylist.Text = "NombreCancion";
            // 
            // lblAutorPlaylist
            // 
            this.lblAutorPlaylist.AutoSize = true;
            this.lblAutorPlaylist.Font = new System.Drawing.Font("Circular Std Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorPlaylist.Location = new System.Drawing.Point(113, 54);
            this.lblAutorPlaylist.Name = "lblAutorPlaylist";
            this.lblAutorPlaylist.Size = new System.Drawing.Size(45, 18);
            this.lblAutorPlaylist.TabIndex = 24;
            this.lblAutorPlaylist.Text = "Autor";
            // 
            // picCancionAPlaylist
            // 
            this.picCancionAPlaylist.BorderRadius = 10;
            this.picCancionAPlaylist.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picCancionAPlaylist.Location = new System.Drawing.Point(26, 20);
            this.picCancionAPlaylist.Name = "picCancionAPlaylist";
            this.picCancionAPlaylist.ShadowDecoration.Parent = this.picCancionAPlaylist;
            this.picCancionAPlaylist.Size = new System.Drawing.Size(68, 66);
            this.picCancionAPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancionAPlaylist.TabIndex = 22;
            this.picCancionAPlaylist.TabStop = false;
            // 
            // PlaylistParaCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAgregarAPlaylist);
            this.Controls.Add(this.lblNombrePlaylist);
            this.Controls.Add(this.lblAutorPlaylist);
            this.Controls.Add(this.picCancionAPlaylist);
            this.Name = "PlaylistParaCancion";
            this.Size = new System.Drawing.Size(583, 112);
            this.Load += new System.EventHandler(this.PlaylistParaCancion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCancionAPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI2.WinForms.Guna2Button btnAgregarAPlaylist;
        private Guna.UI.WinForms.GunaLabel lblNombrePlaylist;
        private Guna.UI.WinForms.GunaLabel lblAutorPlaylist;
        private Guna.UI2.WinForms.Guna2PictureBox picCancionAPlaylist;
    }
}
