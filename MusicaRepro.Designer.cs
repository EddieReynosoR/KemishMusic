
namespace KemishMusic
{
    partial class MusicaRepr
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
            this.lblNombreCancion = new Guna.UI.WinForms.GunaLabel();
            this.lblAutor = new Guna.UI.WinForms.GunaLabel();
            this.picReproduccion = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.MusicaRepro = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picCancionRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReproduccion)).BeginInit();
            this.MusicaRepro.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCancionRep
            // 
            this.picCancionRep.BorderRadius = 10;
            this.picCancionRep.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picCancionRep.Location = new System.Drawing.Point(18, 19);
            this.picCancionRep.Name = "picCancionRep";
            this.picCancionRep.ShadowDecoration.Parent = this.picCancionRep;
            this.picCancionRep.Size = new System.Drawing.Size(70, 70);
            this.picCancionRep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancionRep.TabIndex = 0;
            this.picCancionRep.TabStop = false;
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.Font = new System.Drawing.Font("Circular Std Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCancion.Location = new System.Drawing.Point(120, 29);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(140, 22);
            this.lblNombreCancion.TabIndex = 1;
            this.lblNombreCancion.Text = "NombreCancion";
            this.lblNombreCancion.Click += new System.EventHandler(this.lblNombreCancion_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Circular Std Book", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(121, 63);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(43, 16);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // picReproduccion
            // 
            this.picReproduccion.Location = new System.Drawing.Point(980, 29);
            this.picReproduccion.Name = "picReproduccion";
            this.picReproduccion.ShadowDecoration.Parent = this.picReproduccion;
            this.picReproduccion.Size = new System.Drawing.Size(50, 50);
            this.picReproduccion.TabIndex = 3;
            this.picReproduccion.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(916, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "label1";
            // 
            // MusicaRepro
            // 
            this.MusicaRepro.Controls.Add(this.picCancionRep);
            this.MusicaRepro.Controls.Add(this.picReproduccion);
            this.MusicaRepro.Controls.Add(this.lblID);
            this.MusicaRepro.Controls.Add(this.lblNombreCancion);
            this.MusicaRepro.Controls.Add(this.lblAutor);
            this.MusicaRepro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicaRepro.Location = new System.Drawing.Point(0, 0);
            this.MusicaRepro.Name = "MusicaRepro";
            this.MusicaRepro.ShadowDecoration.Parent = this.MusicaRepro;
            this.MusicaRepro.Size = new System.Drawing.Size(1060, 110);
            this.MusicaRepro.TabIndex = 5;
            this.MusicaRepro.Click += new System.EventHandler(this.MusicaRepro_Click_1);
            this.MusicaRepro.Paint += new System.Windows.Forms.PaintEventHandler(this.MusicaRepro_Paint);
            this.MusicaRepro.MouseLeave += new System.EventHandler(this.MusicaRepro_MouseLeave);
            this.MusicaRepro.MouseHover += new System.EventHandler(this.MusicaRepro_MouseHover);
            // 
            // MusicaRepr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MusicaRepro);
            this.Name = "MusicaRepr";
            this.Size = new System.Drawing.Size(1060, 110);
            this.Load += new System.EventHandler(this.MusicaRepro_Load);
            this.Click += new System.EventHandler(this.MusicaRepro_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picCancionRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReproduccion)).EndInit();
            this.MusicaRepro.ResumeLayout(false);
            this.MusicaRepro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picCancionRep;
        private Guna.UI.WinForms.GunaLabel lblNombreCancion;
        private Guna.UI.WinForms.GunaLabel lblAutor;
        private Guna.UI2.WinForms.Guna2PictureBox picReproduccion;
        private System.Windows.Forms.Label lblID;
        private Guna.UI2.WinForms.Guna2Panel MusicaRepro;
    }
}
