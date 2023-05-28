
namespace KemishMusic
{
    partial class CancionParaPlaylist
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
            this.picCancionAPlaylist = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNombreCancion = new Guna.UI.WinForms.GunaLabel();
            this.lblAutor = new Guna.UI.WinForms.GunaLabel();
            this.btnAgregarCancionAPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picCancionAPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // picCancionAPlaylist
            // 
            this.picCancionAPlaylist.BorderRadius = 10;
            this.picCancionAPlaylist.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picCancionAPlaylist.Location = new System.Drawing.Point(25, 23);
            this.picCancionAPlaylist.Name = "picCancionAPlaylist";
            this.picCancionAPlaylist.ShadowDecoration.Parent = this.picCancionAPlaylist;
            this.picCancionAPlaylist.Size = new System.Drawing.Size(68, 66);
            this.picCancionAPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancionAPlaylist.TabIndex = 0;
            this.picCancionAPlaylist.TabStop = false;
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.Font = new System.Drawing.Font("Circular Std Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCancion.Location = new System.Drawing.Point(111, 23);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(140, 22);
            this.lblNombreCancion.TabIndex = 3;
            this.lblNombreCancion.Text = "NombreCancion";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Circular Std Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(112, 57);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(45, 18);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor";
            // 
            // btnAgregarCancionAPlaylist
            // 
            this.btnAgregarCancionAPlaylist.BorderRadius = 20;
            this.btnAgregarCancionAPlaylist.CheckedState.Parent = this.btnAgregarCancionAPlaylist;
            this.btnAgregarCancionAPlaylist.CustomImages.Parent = this.btnAgregarCancionAPlaylist;
            this.btnAgregarCancionAPlaylist.FillColor = System.Drawing.Color.Gold;
            this.btnAgregarCancionAPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarCancionAPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCancionAPlaylist.HoverState.Parent = this.btnAgregarCancionAPlaylist;
            this.btnAgregarCancionAPlaylist.Location = new System.Drawing.Point(376, 30);
            this.btnAgregarCancionAPlaylist.Name = "btnAgregarCancionAPlaylist";
            this.btnAgregarCancionAPlaylist.ShadowDecoration.Parent = this.btnAgregarCancionAPlaylist;
            this.btnAgregarCancionAPlaylist.Size = new System.Drawing.Size(163, 45);
            this.btnAgregarCancionAPlaylist.TabIndex = 20;
            this.btnAgregarCancionAPlaylist.Text = "Agregar canción";
            this.btnAgregarCancionAPlaylist.Click += new System.EventHandler(this.btnAgregarCancionAPlaylist_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Circular Std Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(112, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // CancionParaPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAgregarCancionAPlaylist);
            this.Controls.Add(this.lblNombreCancion);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.picCancionAPlaylist);
            this.Name = "CancionParaPlaylist";
            this.Size = new System.Drawing.Size(583, 112);
            this.Load += new System.EventHandler(this.CancionParaPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCancionAPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picCancionAPlaylist;
        private Guna.UI.WinForms.GunaLabel lblNombreCancion;
        private Guna.UI.WinForms.GunaLabel lblAutor;
        private Guna.UI2.WinForms.Guna2Button btnAgregarCancionAPlaylist;
        private Guna.UI.WinForms.GunaLabel lblID;
    }
}
