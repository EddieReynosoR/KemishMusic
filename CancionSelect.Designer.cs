
namespace KemishMusic
{
    partial class CancionSelect
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
            this.cancionNombre = new Guna.UI.WinForms.GunaLabel();
            this.picCancion = new Guna.UI.WinForms.GunaPictureBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCancion)).BeginInit();
            this.SuspendLayout();
            // 
            // cancionNombre
            // 
            this.cancionNombre.AutoSize = true;
            this.cancionNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancionNombre.Location = new System.Drawing.Point(52, 243);
            this.cancionNombre.Name = "cancionNombre";
            this.cancionNombre.Size = new System.Drawing.Size(87, 25);
            this.cancionNombre.TabIndex = 8;
            this.cancionNombre.Text = "Nombre";
            // 
            // picCancion
            // 
            this.picCancion.BackColor = System.Drawing.Color.Transparent;
            this.picCancion.BaseColor = System.Drawing.Color.White;
            this.picCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCancion.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picCancion.Location = new System.Drawing.Point(57, 30);
            this.picCancion.Name = "picCancion";
            this.picCancion.Radius = 10;
            this.picCancion.Size = new System.Drawing.Size(210, 210);
            this.picCancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancion.TabIndex = 7;
            this.picCancion.TabStop = false;
            this.picCancion.Click += new System.EventHandler(this.picCancion_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(200, 250);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "label1";
            // 
            // CancionSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cancionNombre);
            this.Controls.Add(this.picCancion);
            this.Name = "CancionSelect";
            this.Size = new System.Drawing.Size(310, 304);
            this.Load += new System.EventHandler(this.CancionSelect_Load);
            this.Click += new System.EventHandler(this.CancionSelect_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picCancion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox picCancion;
        private Guna.UI.WinForms.GunaLabel cancionNombre;
        private System.Windows.Forms.Label lblID;
    }
}
