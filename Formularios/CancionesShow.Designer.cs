namespace KemishMusic.Formularios
{
    partial class CancionesShow
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
            this.panelCancion = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // panelCancion
            // 
            this.panelCancion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCancion.Location = new System.Drawing.Point(0, 0);
            this.panelCancion.Name = "panelCancion";
            this.panelCancion.ShadowDecoration.Parent = this.panelCancion;
            this.panelCancion.Size = new System.Drawing.Size(952, 515);
            this.panelCancion.TabIndex = 0;
            // 
            // CancionesShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 515);
            this.Controls.Add(this.panelCancion);
            this.Name = "CancionesShow";
            this.Text = "CancionesShow";
            this.Load += new System.EventHandler(this.CancionesShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelCancion;
    }
}