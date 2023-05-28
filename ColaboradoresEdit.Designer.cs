
namespace KemishMusic
{
    partial class ColaboradoresEdit
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
            this.lblNombreColab = new Guna.UI.WinForms.GunaLabel();
            this.btnEliminarColab = new Guna.UI2.WinForms.Guna2Button();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lblNombreColab
            // 
            this.lblNombreColab.AutoSize = true;
            this.lblNombreColab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombreColab.Location = new System.Drawing.Point(20, 23);
            this.lblNombreColab.Name = "lblNombreColab";
            this.lblNombreColab.Size = new System.Drawing.Size(165, 20);
            this.lblNombreColab.TabIndex = 0;
            this.lblNombreColab.Text = "lblNombreColaborador";
            // 
            // btnEliminarColab
            // 
            this.btnEliminarColab.CheckedState.Parent = this.btnEliminarColab;
            this.btnEliminarColab.CustomImages.Parent = this.btnEliminarColab;
            this.btnEliminarColab.FillColor = System.Drawing.Color.Red;
            this.btnEliminarColab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminarColab.ForeColor = System.Drawing.Color.White;
            this.btnEliminarColab.HoverState.Parent = this.btnEliminarColab;
            this.btnEliminarColab.Location = new System.Drawing.Point(255, 16);
            this.btnEliminarColab.Name = "btnEliminarColab";
            this.btnEliminarColab.ShadowDecoration.Parent = this.btnEliminarColab;
            this.btnEliminarColab.Size = new System.Drawing.Size(121, 35);
            this.btnEliminarColab.TabIndex = 1;
            this.btnEliminarColab.Text = "Eliminar";
            this.btnEliminarColab.Click += new System.EventHandler(this.btnEliminarColab_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblID.Location = new System.Drawing.Point(20, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // ColaboradoresEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnEliminarColab);
            this.Controls.Add(this.lblNombreColab);
            this.Name = "ColaboradoresEdit";
            this.Size = new System.Drawing.Size(395, 67);
            this.Load += new System.EventHandler(this.ColaboradoresEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblNombreColab;
        private Guna.UI2.WinForms.Guna2Button btnEliminarColab;
        private Guna.UI.WinForms.GunaLabel lblID;
    }
}
