
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
            System.Windows.Forms.Label label3;
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNav = new Guna.UI2.WinForms.Guna2Button();
            this.btnHomeRepro = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelReproduccion = new Guna.UI2.WinForms.Guna2Panel();
            this.picMostrarCola = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbBar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnPausaPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCancion = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.panelOpciones = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarse = new Guna.UI2.WinForms.Guna2Button();
            this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.panelMusicaRe = new Guna.UI2.WinForms.Guna2Panel();
            this.timerBarraMusic = new System.Windows.Forms.Timer(this.components);
            this.guna2MouseStateHandler1 = new Guna.UI2.WinForms.Guna2MouseStateHandler(this.components);
            this.timerReproduccion = new System.Windows.Forms.Timer(this.components);
            label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.panelReproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBar)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelOpciones.SuspendLayout();
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
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(label3);
            this.guna2Panel1.Controls.Add(this.btnNav);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(452, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 16);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // btnNav
            // 
            this.btnNav.BorderRadius = 12;
            this.btnNav.CheckedState.Parent = this.btnNav;
            this.btnNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNav.CustomImages.Parent = this.btnNav;
            this.btnNav.FillColor = System.Drawing.Color.Gray;
            this.btnNav.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNav.ForeColor = System.Drawing.Color.White;
            this.btnNav.HoverState.Parent = this.btnNav;
            this.btnNav.Location = new System.Drawing.Point(684, 7);
            this.btnNav.Name = "btnNav";
            this.btnNav.ShadowDecoration.Parent = this.btnNav;
            this.btnNav.Size = new System.Drawing.Size(192, 29);
            this.btnNav.TabIndex = 5;
            this.btnNav.Text = "Sesión no iniciada";
            this.btnNav.Click += new System.EventHandler(this.btnNav_Click);
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
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
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            // 
            // panelReproduccion
            // 
            this.panelReproduccion.BackColor = System.Drawing.Color.DarkGray;
            this.panelReproduccion.Controls.Add(this.picMostrarCola);
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
            // picMostrarCola
            // 
            this.picMostrarCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMostrarCola.Image = global::KemishMusic.Properties.Resources._4419530;
            this.picMostrarCola.Location = new System.Drawing.Point(1198, 6);
            this.picMostrarCola.Name = "picMostrarCola";
            this.picMostrarCola.ShadowDecoration.Parent = this.picMostrarCola;
            this.picMostrarCola.Size = new System.Drawing.Size(37, 35);
            this.picMostrarCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMostrarCola.TabIndex = 15;
            this.picMostrarCola.TabStop = false;
            this.picMostrarCola.Click += new System.EventHandler(this.picMostrarCola_Click);
            // 
            // pbBar
            // 
            this.pbBar.BorderRadius = 5;
            this.pbBar.Location = new System.Drawing.Point(92, 21);
            this.pbBar.Name = "pbBar";
            this.pbBar.ShadowDecoration.Parent = this.pbBar;
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
            this.panelMenu.Controls.Add(this.btnAgregar);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnCancion);
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
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Gray;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 35;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 300);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 45);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Mis Playlist";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 255);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(171, 45);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Text = "Crear Playlist";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // btnCancion
            // 
            this.btnCancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCancion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancion.FlatAppearance.BorderSize = 0;
            this.btnCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancion.IconChar = FontAwesome.Sharp.IconChar.Spotify;
            this.btnCancion.IconColor = System.Drawing.Color.Black;
            this.btnCancion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancion.IconSize = 35;
            this.btnCancion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancion.Location = new System.Drawing.Point(0, 210);
            this.btnCancion.Name = "btnCancion";
            this.btnCancion.Size = new System.Drawing.Size(171, 45);
            this.btnCancion.TabIndex = 14;
            this.btnCancion.Text = "Tu Musica";
            this.btnCancion.UseVisualStyleBackColor = false;
            this.btnCancion.Click += new System.EventHandler(this.btnCancion_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btnSearch.Text = "Añadir música";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPictureBox1.Image = global::KemishMusic.Properties.Resources._330634344_1228671984728501_5317193639878804641_n;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(171, 120);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelOpciones);
            this.panelDesktop.Controls.Add(this.panelMusicaRe);
            this.panelDesktop.Controls.Add(this.gunaLabel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(171, 43);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.ShadowDecoration.Parent = this.panelDesktop;
            this.panelDesktop.Size = new System.Drawing.Size(1076, 512);
            this.panelDesktop.TabIndex = 12;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.btnCerrarSesion);
            this.panelOpciones.Controls.Add(this.btnRegistrarse);
            this.panelOpciones.Controls.Add(this.btnIniciarSesion);
            this.panelOpciones.Location = new System.Drawing.Point(684, 3);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.ShadowDecoration.Parent = this.panelOpciones;
            this.panelOpciones.Size = new System.Drawing.Size(200, 144);
            this.panelOpciones.TabIndex = 1;
            this.panelOpciones.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.CheckedState.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.CustomImages.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FillColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCerrarSesion.HoverState.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 93);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.ShadowDecoration.Parent = this.btnCerrarSesion;
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 48);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.CheckedState.Parent = this.btnRegistrarse;
            this.btnRegistrarse.CustomImages.Parent = this.btnRegistrarse;
            this.btnRegistrarse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarse.FillColor = System.Drawing.Color.White;
            this.btnRegistrarse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrarse.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarse.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrarse.HoverState.Parent = this.btnRegistrarse;
            this.btnRegistrarse.Location = new System.Drawing.Point(0, 45);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.ShadowDecoration.Parent = this.btnRegistrarse;
            this.btnRegistrarse.Size = new System.Drawing.Size(200, 48);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.CheckedState.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.CustomImages.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciarSesion.FillColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIniciarSesion.HoverState.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.ShadowDecoration.Parent = this.btnIniciarSesion;
            this.btnIniciarSesion.Size = new System.Drawing.Size(200, 45);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // panelMusicaRe
            // 
            this.panelMusicaRe.AutoScroll = true;
            this.panelMusicaRe.BackColor = System.Drawing.Color.LightGray;
            this.panelMusicaRe.Location = new System.Drawing.Point(0, 30);
            this.panelMusicaRe.Name = "panelMusicaRe";
            this.panelMusicaRe.ShadowDecoration.Parent = this.panelMusicaRe;
            this.panelMusicaRe.Size = new System.Drawing.Size(1076, 482);
            this.panelMusicaRe.TabIndex = 13;
            this.panelMusicaRe.Visible = false;
            this.panelMusicaRe.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // timerBarraMusic
            // 
            this.timerBarraMusic.Interval = 1;
            this.timerBarraMusic.Tick += new System.EventHandler(this.timerBarraMusic_Tick);
            // 
            // timerReproduccion
            // 
            this.timerReproduccion.Tick += new System.EventHandler(this.timerReproduccion_Tick);
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
            this.guna2Panel1.PerformLayout();
            this.panelReproduccion.ResumeLayout(false);
            this.panelReproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnPausaPlay;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar2;
        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Timer timerBarraMusic;
        private Guna.UI2.WinForms.Guna2MouseStateHandler guna2MouseStateHandler1;
        private FontAwesome.Sharp.IconButton btnHomeRepro;
        private Guna.UI2.WinForms.Guna2Panel panelMusicaRe;
        private Guna.UI2.WinForms.Guna2PictureBox pbBar;
        private FontAwesome.Sharp.IconButton btnCancion;
        private Guna.UI2.WinForms.Guna2Panel panelOpciones;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarse;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2Button btnNav;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
        private Guna.UI2.WinForms.Guna2PictureBox picMostrarCola;
        private System.Windows.Forms.Timer timerReproduccion;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label label4;
    }
}

