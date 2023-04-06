
namespace KemishMusic
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHomeRepro = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelReproduccion = new Guna.UI2.WinForms.Guna2Panel();
            this.pbBar = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2TrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnPausaPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.timerBarraMusic = new System.Windows.Forms.Timer(this.components);
            this.guna2MouseStateHandler1 = new Guna.UI2.WinForms.Guna2MouseStateHandler(this.components);
            this.guna2Panel1.SuspendLayout();
            this.panelReproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBar)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnHomeRepro);
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Controls.Add(this.gunaControlBox3);
            this.guna2Panel1.Controls.Add(this.gunaControlBox2);
            this.guna2Panel1.Controls.Add(this.gunaControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(171, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1076, 43);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnHomeRepro
            // 
            this.btnHomeRepro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHomeRepro.FlatAppearance.BorderSize = 0;
            this.btnHomeRepro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeRepro.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHomeRepro.IconColor = System.Drawing.Color.Black;
            this.btnHomeRepro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHomeRepro.Location = new System.Drawing.Point(300, 0);
            this.btnHomeRepro.Name = "btnHomeRepro";
            this.btnHomeRepro.Size = new System.Drawing.Size(75, 43);
            this.btnHomeRepro.TabIndex = 4;
            this.btnHomeRepro.UseVisualStyleBackColor = true;
            this.btnHomeRepro.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = global::KemishMusic.Properties.Resources._3031293;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearch.PlaceholderText = "Buscar...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(300, 43);
            this.txtSearch.TabIndex = 3;
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
            this.gunaControlBox3.Location = new System.Drawing.Point(917, 7);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox2.Enabled = false;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(968, 7);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 1;
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
            this.gunaControlBox1.Location = new System.Drawing.Point(1019, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            // 
            // panelReproduccion
            // 
            this.panelReproduccion.BackColor = System.Drawing.Color.DarkGray;
            this.panelReproduccion.Controls.Add(this.pbBar);
            this.panelReproduccion.Controls.Add(this.guna2TrackBar2);
            this.panelReproduccion.Controls.Add(this.btnPausaPlay);
            this.panelReproduccion.Controls.Add(this.label2);
            this.panelReproduccion.Controls.Add(this.guna2TrackBar1);
            this.panelReproduccion.Controls.Add(this.label1);
            this.panelReproduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReproduccion.Location = new System.Drawing.Point(0, 555);
            this.panelReproduccion.Name = "panelReproduccion";
            this.panelReproduccion.ShadowDecoration.BorderRadius = 0;
            this.panelReproduccion.ShadowDecoration.Depth = 35;
            this.panelReproduccion.ShadowDecoration.Enabled = true;
            this.panelReproduccion.ShadowDecoration.Parent = this.panelReproduccion;
            this.panelReproduccion.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelReproduccion.Size = new System.Drawing.Size(1247, 128);
            this.panelReproduccion.TabIndex = 1;
            // 
            // pbBar
            // 
            this.pbBar.BackColor = System.Drawing.Color.DarkGray;
            this.pbBar.BaseColor = System.Drawing.Color.Transparent;
            this.pbBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBar.Location = new System.Drawing.Point(52, 21);
            this.pbBar.Name = "pbBar";
            this.pbBar.Radius = 10;
            this.pbBar.Size = new System.Drawing.Size(90, 90);
            this.pbBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBar.TabIndex = 14;
            this.pbBar.TabStop = false;
            this.pbBar.Click += new System.EventHandler(this.pbBar_Click);
            // 
            // guna2TrackBar2
            // 
            this.guna2TrackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TrackBar2.FillColor = System.Drawing.Color.White;
            this.guna2TrackBar2.HoverState.Parent = this.guna2TrackBar2;
            this.guna2TrackBar2.Location = new System.Drawing.Point(899, 68);
            this.guna2TrackBar2.Name = "guna2TrackBar2";
            this.guna2TrackBar2.Size = new System.Drawing.Size(275, 25);
            this.guna2TrackBar2.TabIndex = 13;
            this.guna2TrackBar2.ThumbColor = System.Drawing.Color.Black;
            this.guna2TrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar2_Scroll);
            // 
            // btnPausaPlay
            // 
            this.btnPausaPlay.CheckedState.Parent = this.btnPausaPlay;
            this.btnPausaPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausaPlay.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPausaPlay.HoverState.Parent = this.btnPausaPlay;
            this.btnPausaPlay.Image = global::KemishMusic.Properties.Resources._16427;
            this.btnPausaPlay.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPausaPlay.Location = new System.Drawing.Point(738, 56);
            this.btnPausaPlay.Name = "btnPausaPlay";
            this.btnPausaPlay.PressedState.Parent = this.btnPausaPlay;
            this.btnPausaPlay.Size = new System.Drawing.Size(55, 55);
            this.btnPausaPlay.TabIndex = 12;
            this.btnPausaPlay.Click += new System.EventHandler(this.btnPausaPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1185, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 11;
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TrackBar1.FillColor = System.Drawing.Color.White;
            this.guna2TrackBar1.HoverState.Parent = this.guna2TrackBar1;
            this.guna2TrackBar1.Location = new System.Drawing.Point(387, 25);
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(787, 25);
            this.guna2TrackBar1.TabIndex = 9;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.Black;
            this.guna2TrackBar1.Value = 0;
            this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.gunaPictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShadowDecoration.BorderRadius = 0;
            this.panelMenu.ShadowDecoration.Depth = 5;
            this.panelMenu.ShadowDecoration.Enabled = true;
            this.panelMenu.ShadowDecoration.Parent = this.panelMenu;
            this.panelMenu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelMenu.Size = new System.Drawing.Size(171, 555);
            this.panelMenu.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Spotify;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 35;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 45);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Library";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 35;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 45);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::KemishMusic.Properties.Resources._330634344_1228671984728501_5317193639878804641_n;
            this.gunaPictureBox1.Location = new System.Drawing.Point(22, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(6, 6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(82, 25);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Para ti...";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(135, 256);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 25);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "BRRR";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(136, 281);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(78, 20);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Anuel AA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(439, 256);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(61, 25);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "AMG";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(386, 281);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(179, 32);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Natanael Cano, Peso Pluma,\r\nGabito Ballesteros\r\n";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.gunaPictureBox3);
            this.panelDesktop.Controls.Add(this.gunaLabel5);
            this.panelDesktop.Controls.Add(this.gunaLabel4);
            this.panelDesktop.Controls.Add(this.gunaLabel1);
            this.panelDesktop.Controls.Add(this.gunaPictureBox2);
            this.panelDesktop.Controls.Add(this.gunaLabel2);
            this.panelDesktop.Controls.Add(this.gunaLabel3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(171, 43);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.ShadowDecoration.Parent = this.panelDesktop;
            this.panelDesktop.Size = new System.Drawing.Size(1076, 512);
            this.panelDesktop.TabIndex = 12;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaPictureBox3.Image = global::KemishMusic.Properties.Resources.AMG;
            this.gunaPictureBox3.Location = new System.Drawing.Point(355, 43);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Radius = 10;
            this.gunaPictureBox3.Size = new System.Drawing.Size(210, 210);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox3.TabIndex = 9;
            this.gunaPictureBox3.TabStop = false;
            this.gunaPictureBox3.Click += new System.EventHandler(this.gunaPictureBox3_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaPictureBox2.Image = global::KemishMusic.Properties.Resources.anuel_aa_las_leyendas_nunca_mueren_2_portada;
            this.gunaPictureBox2.Location = new System.Drawing.Point(70, 43);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(210, 210);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 6;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // timerBarraMusic
            // 
            this.timerBarraMusic.Interval = 1;
            this.timerBarraMusic.Tick += new System.EventHandler(this.timerBarraMusic_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 683);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelReproduccion);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kemish Music";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelReproduccion.ResumeLayout(false);
            this.panelReproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panelReproduccion;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2ImageButton btnPausaPlay;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar2;
        private Guna.UI.WinForms.GunaPictureBox pbBar;
        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Timer timerBarraMusic;
        private Guna.UI2.WinForms.Guna2MouseStateHandler guna2MouseStateHandler1;
        private FontAwesome.Sharp.IconButton btnHomeRepro;
    }
}

