
namespace KemishMusic
{
    partial class AgregarAPlaylist
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new Guna.UI.WinForms.GunaLabel();
            this.panelPlaylistNOAsignadas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMensajeCancion = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.panelPlaylistNOAsignadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.gunaControlBox3);
            this.guna2Panel1.Controls.Add(this.gunaControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(802, 43);
            this.guna2Panel1.TabIndex = 4;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(697, 7);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 2;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 30F;
            this.gunaControlBox1.Location = new System.Drawing.Point(745, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Circular Std Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agregar cancion a playlist";
            // 
            // panelPlaylistNOAsignadas
            // 
            this.panelPlaylistNOAsignadas.AutoScroll = true;
            this.panelPlaylistNOAsignadas.Controls.Add(this.lblMensajeCancion);
            this.panelPlaylistNOAsignadas.Location = new System.Drawing.Point(64, 135);
            this.panelPlaylistNOAsignadas.Name = "panelPlaylistNOAsignadas";
            this.panelPlaylistNOAsignadas.ShadowDecoration.Parent = this.panelPlaylistNOAsignadas;
            this.panelPlaylistNOAsignadas.Size = new System.Drawing.Size(583, 302);
            this.panelPlaylistNOAsignadas.TabIndex = 5;
            // 
            // lblMensajeCancion
            // 
            this.lblMensajeCancion.AutoSize = true;
            this.lblMensajeCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeCancion.Location = new System.Drawing.Point(141, 138);
            this.lblMensajeCancion.Name = "lblMensajeCancion";
            this.lblMensajeCancion.Size = new System.Drawing.Size(299, 29);
            this.lblMensajeCancion.TabIndex = 3;
            this.lblMensajeCancion.Text = "No hay playlist disponibles";
            this.lblMensajeCancion.Visible = false;
            // 
            // AgregarAPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPlaylistNOAsignadas);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAPlaylist";
            this.Text = "AgregarAPlaylist";
            this.Load += new System.EventHandler(this.AgregarAPlaylist_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelPlaylistNOAsignadas.ResumeLayout(false);
            this.panelPlaylistNOAsignadas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel label1;
        private Guna.UI2.WinForms.Guna2Panel panelPlaylistNOAsignadas;
        private System.Windows.Forms.Label lblMensajeCancion;
    }
}