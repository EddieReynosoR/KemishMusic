
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
            this.lblID = new System.Windows.Forms.Label();
            this.panelOpciones = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEditarCancion = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarAPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.btnDespues = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarFila = new Guna.UI2.WinForms.Guna2Button();
            this.iconOpciones = new FontAwesome.Sharp.IconButton();
            this.picCancion = new Guna.UI.WinForms.GunaPictureBox();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.panelOpciones.SuspendLayout();
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
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(200, 250);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "label1";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.btnEditarCancion);
            this.panelOpciones.Controls.Add(this.btnAgregarAPlaylist);
            this.panelOpciones.Controls.Add(this.btnDespues);
            this.panelOpciones.Controls.Add(this.btnAgregarFila);
            this.panelOpciones.Location = new System.Drawing.Point(327, 78);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.ShadowDecoration.Parent = this.panelOpciones;
            this.panelOpciones.Size = new System.Drawing.Size(160, 232);
            this.panelOpciones.TabIndex = 12;
            this.panelOpciones.Visible = false;
            this.panelOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpciones_Paint);
            // 
            // btnEditarCancion
            // 
            this.btnEditarCancion.CheckedState.Parent = this.btnEditarCancion;
            this.btnEditarCancion.CustomImages.Parent = this.btnEditarCancion;
            this.btnEditarCancion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarCancion.FillColor = System.Drawing.Color.White;
            this.btnEditarCancion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditarCancion.ForeColor = System.Drawing.Color.Black;
            this.btnEditarCancion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarCancion.HoverState.Parent = this.btnEditarCancion;
            this.btnEditarCancion.Location = new System.Drawing.Point(0, 144);
            this.btnEditarCancion.Name = "btnEditarCancion";
            this.btnEditarCancion.ShadowDecoration.Parent = this.btnEditarCancion;
            this.btnEditarCancion.Size = new System.Drawing.Size(160, 51);
            this.btnEditarCancion.TabIndex = 3;
            this.btnEditarCancion.Text = "Editar cancion";
            this.btnEditarCancion.Visible = false;
            this.btnEditarCancion.Click += new System.EventHandler(this.btnEditarCancion_Click);
            // 
            // btnAgregarAPlaylist
            // 
            this.btnAgregarAPlaylist.CheckedState.Parent = this.btnAgregarAPlaylist;
            this.btnAgregarAPlaylist.CustomImages.Parent = this.btnAgregarAPlaylist;
            this.btnAgregarAPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarAPlaylist.FillColor = System.Drawing.Color.White;
            this.btnAgregarAPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarAPlaylist.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarAPlaylist.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarAPlaylist.HoverState.Parent = this.btnAgregarAPlaylist;
            this.btnAgregarAPlaylist.Location = new System.Drawing.Point(0, 93);
            this.btnAgregarAPlaylist.Name = "btnAgregarAPlaylist";
            this.btnAgregarAPlaylist.ShadowDecoration.Parent = this.btnAgregarAPlaylist;
            this.btnAgregarAPlaylist.Size = new System.Drawing.Size(160, 51);
            this.btnAgregarAPlaylist.TabIndex = 2;
            this.btnAgregarAPlaylist.Text = "Agregar a playlist";
            this.btnAgregarAPlaylist.Click += new System.EventHandler(this.btnAgregarAPlaylist_Click);
            // 
            // btnDespues
            // 
            this.btnDespues.CheckedState.Parent = this.btnDespues;
            this.btnDespues.CustomImages.Parent = this.btnDespues;
            this.btnDespues.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDespues.FillColor = System.Drawing.Color.White;
            this.btnDespues.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDespues.ForeColor = System.Drawing.Color.Black;
            this.btnDespues.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDespues.HoverState.Parent = this.btnDespues;
            this.btnDespues.Location = new System.Drawing.Point(0, 45);
            this.btnDespues.Name = "btnDespues";
            this.btnDespues.ShadowDecoration.Parent = this.btnDespues;
            this.btnDespues.Size = new System.Drawing.Size(160, 48);
            this.btnDespues.TabIndex = 1;
            this.btnDespues.Text = "Reproducir después";
            this.btnDespues.Click += new System.EventHandler(this.picOpciones_Click);
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.CheckedState.Parent = this.btnAgregarFila;
            this.btnAgregarFila.CustomImages.Parent = this.btnAgregarFila;
            this.btnAgregarFila.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarFila.FillColor = System.Drawing.Color.White;
            this.btnAgregarFila.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarFila.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarFila.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarFila.HoverState.Parent = this.btnAgregarFila;
            this.btnAgregarFila.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.ShadowDecoration.Parent = this.btnAgregarFila;
            this.btnAgregarFila.Size = new System.Drawing.Size(160, 45);
            this.btnAgregarFila.TabIndex = 0;
            this.btnAgregarFila.Text = "Agregar a la fila";
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // iconOpciones
            // 
            this.iconOpciones.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconOpciones.IconColor = System.Drawing.Color.Black;
            this.iconOpciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOpciones.Location = new System.Drawing.Point(321, 30);
            this.iconOpciones.Name = "iconOpciones";
            this.iconOpciones.Size = new System.Drawing.Size(52, 49);
            this.iconOpciones.TabIndex = 11;
            this.iconOpciones.UseVisualStyleBackColor = true;
            this.iconOpciones.Click += new System.EventHandler(this.iconOpciones_Click);
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
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(54, 281);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(46, 17);
            this.lblArtista.TabIndex = 13;
            this.lblArtista.Text = "label1";
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(175, 281);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(46, 17);
            this.lblIDUsuario.TabIndex = 14;
            this.lblIDUsuario.Text = "label1";
            this.lblIDUsuario.Visible = false;
            // 
            // CancionSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.iconOpciones);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cancionNombre);
            this.Controls.Add(this.picCancion);
            this.Name = "CancionSelect";
            this.Size = new System.Drawing.Size(490, 379);
            this.Load += new System.EventHandler(this.CancionSelect_Load);
            this.Click += new System.EventHandler(this.CancionSelect_Click);
            this.panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCancion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox picCancion;
        private Guna.UI.WinForms.GunaLabel cancionNombre;
        private System.Windows.Forms.Label lblID;
        private FontAwesome.Sharp.IconButton iconOpciones;
        private Guna.UI2.WinForms.Guna2Panel panelOpciones;
        private Guna.UI2.WinForms.Guna2Button btnAgregarAPlaylist;
        private Guna.UI2.WinForms.Guna2Button btnDespues;
        private Guna.UI2.WinForms.Guna2Button btnAgregarFila;
        private Guna.UI2.WinForms.Guna2Button btnEditarCancion;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblIDUsuario;
    }
}
