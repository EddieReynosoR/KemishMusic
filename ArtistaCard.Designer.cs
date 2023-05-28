
namespace KemishMusic
{
    partial class ArtistaCard
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
            this.picArtistaCarta = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblArtistaNombre = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picArtistaCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // picArtistaCarta
            // 
            this.picArtistaCarta.Image = global::KemishMusic.Properties.Resources._8c65e43892fda4e0836122115304e20b29334eac_hq;
            this.picArtistaCarta.Location = new System.Drawing.Point(95, 31);
            this.picArtistaCarta.Name = "picArtistaCarta";
            this.picArtistaCarta.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picArtistaCarta.ShadowDecoration.Parent = this.picArtistaCarta;
            this.picArtistaCarta.Size = new System.Drawing.Size(200, 200);
            this.picArtistaCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArtistaCarta.TabIndex = 0;
            this.picArtistaCarta.TabStop = false;
            this.picArtistaCarta.Click += new System.EventHandler(this.picArtistaCarta_Click);
            // 
            // lblArtistaNombre
            // 
            this.lblArtistaNombre.AutoSize = true;
            this.lblArtistaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistaNombre.Location = new System.Drawing.Point(143, 247);
            this.lblArtistaNombre.Name = "lblArtistaNombre";
            this.lblArtistaNombre.Size = new System.Drawing.Size(87, 25);
            this.lblArtistaNombre.TabIndex = 9;
            this.lblArtistaNombre.Text = "Nombre";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Circular Std Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(158, 290);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 21);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Artista";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Circular Std Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(53, 252);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(53, 21);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Artista";
            this.lblID.Visible = false;
            // 
            // ArtistaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblArtistaNombre);
            this.Controls.Add(this.picArtistaCarta);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ArtistaCard";
            this.Size = new System.Drawing.Size(378, 311);
            this.Load += new System.EventHandler(this.ArtistaCard_Load);
            this.Click += new System.EventHandler(this.ArtistaCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picArtistaCarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picArtistaCarta;
        private Guna.UI.WinForms.GunaLabel lblArtistaNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblID;
    }
}
