
namespace KemishMusic
{
    partial class PlaylistRepro
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
            this.picCancionRep = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombreCancion = new Guna.UI.WinForms.GunaLabel();
            this.lblAutor = new Guna.UI.WinForms.GunaLabel();
            this.btnEliminarDEPlaylist = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCancionRep)).BeginInit();
            this.SuspendLayout();
            // 
            // picCancionRep
            // 
            this.picCancionRep.BorderRadius = 10;
            this.picCancionRep.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picCancionRep.Location = new System.Drawing.Point(23, 20);
            this.picCancionRep.Name = "picCancionRep";
            this.picCancionRep.ShadowDecoration.Parent = this.picCancionRep;
            this.picCancionRep.Size = new System.Drawing.Size(70, 70);
            this.picCancionRep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancionRep.TabIndex = 5;
            this.picCancionRep.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(991, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "label1";
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.Font = new System.Drawing.Font("Circular Std Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCancion.Location = new System.Drawing.Point(125, 30);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(140, 22);
            this.lblNombreCancion.TabIndex = 6;
            this.lblNombreCancion.Text = "NombreCancion";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Circular Std Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(126, 64);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(45, 18);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "Autor";
            // 
            // btnEliminarDEPlaylist
            // 
            this.btnEliminarDEPlaylist.BorderRadius = 20;
            this.btnEliminarDEPlaylist.CheckedState.Parent = this.btnEliminarDEPlaylist;
            this.btnEliminarDEPlaylist.CustomImages.Parent = this.btnEliminarDEPlaylist;
            this.btnEliminarDEPlaylist.FillColor = System.Drawing.Color.Red;
            this.btnEliminarDEPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminarDEPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDEPlaylist.HoverState.Parent = this.btnEliminarDEPlaylist;
            this.btnEliminarDEPlaylist.Location = new System.Drawing.Point(733, 30);
            this.btnEliminarDEPlaylist.Name = "btnEliminarDEPlaylist";
            this.btnEliminarDEPlaylist.ShadowDecoration.Parent = this.btnEliminarDEPlaylist;
            this.btnEliminarDEPlaylist.Size = new System.Drawing.Size(225, 45);
            this.btnEliminarDEPlaylist.TabIndex = 23;
            this.btnEliminarDEPlaylist.Text = "Eliminar de la playlist";
            this.btnEliminarDEPlaylist.Visible = false;
            this.btnEliminarDEPlaylist.Click += new System.EventHandler(this.btnEliminarDEPlaylist_Click);
            // 
            // PlaylistRepro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminarDEPlaylist);
            this.Controls.Add(this.picCancionRep);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNombreCancion);
            this.Controls.Add(this.lblAutor);
            this.Name = "PlaylistRepro";
            this.Size = new System.Drawing.Size(1060, 110);
            this.Load += new System.EventHandler(this.PlaylistRepro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCancionRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picCancionRep;
        private System.Windows.Forms.Label lblID;
        private Guna.UI.WinForms.GunaLabel lblNombreCancion;
        private Guna.UI.WinForms.GunaLabel lblAutor;
        private Guna.UI2.WinForms.Guna2Button btnEliminarDEPlaylist;
    }
}
