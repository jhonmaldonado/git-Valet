namespace CapaPresentacion
{
    partial class MenuValet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuValet));
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MenuTop = new System.Windows.Forms.Panel();
            this.LineaSidebarTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton_CasilleroLLaves = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton_ZonasParqueo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.bunifuFlatButton_AdministrarPersonal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelLateral = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton_GestionControl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip_Etiquetas = new System.Windows.Forms.ToolTip(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MenuTop.Controls.Add(this.LineaSidebarTitle);
            this.MenuTop.Controls.Add(this.pLogo);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1200, 59);
            this.MenuTop.TabIndex = 3;
            // 
            // LineaSidebarTitle
            // 
            this.LineaSidebarTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaSidebarTitle.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebarTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineaSidebarTitle.BackgroundImage")));
            this.LineaSidebarTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebarTitle, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebarTitle, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebarTitle.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.LineaSidebarTitle.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(49)))));
            this.LineaSidebarTitle.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(49)))));
            this.LineaSidebarTitle.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LineaSidebarTitle.Location = new System.Drawing.Point(0, 56);
            this.LineaSidebarTitle.Name = "LineaSidebarTitle";
            this.LineaSidebarTitle.Quality = 10;
            this.LineaSidebarTitle.Size = new System.Drawing.Size(1200, 3);
            this.LineaSidebarTitle.TabIndex = 30;
            // 
            // pLogo
            // 
            this.AnimacionSidebar.SetDecoration(this.pLogo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pLogo, BunifuAnimatorNS.DecorationType.None);
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(92, 6);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(120, 50);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogo.TabIndex = 295;
            this.pLogo.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1085, 14);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.toolTip_Etiquetas.SetToolTip(this.Minimizar, "Minimizar");
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1157, 14);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.toolTip_Etiquetas.SetToolTip(this.Salir, "Cerrar");
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(35, 14);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(34, 34);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.toolTip_Etiquetas.SetToolTip(this.MenuSidebar, "Ocultar Menú");
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1121, 14);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.toolTip_Etiquetas.SetToolTip(this.Restaurar, "Restaurar");
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1121, 14);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.toolTip_Etiquetas.SetToolTip(this.Maximizar, "Maximizar");
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this.PanelContenedor;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.AnimacionSidebarBack.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelContenedor.Location = new System.Drawing.Point(6, 10);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(921, 539);
            this.PanelContenedor.TabIndex = 0;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation5;
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 65D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(-3, 467);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(243, 70);
            this.bunifuFlatButton6.TabIndex = 13;
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // bunifuFlatButton_CasilleroLLaves
            // 
            this.bunifuFlatButton_CasilleroLLaves.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_CasilleroLLaves.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_CasilleroLLaves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_CasilleroLLaves.BorderRadius = 0;
            this.bunifuFlatButton_CasilleroLLaves.ButtonText = "       CASILLERO LLAVES";
            this.bunifuFlatButton_CasilleroLLaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton_CasilleroLLaves, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton_CasilleroLLaves, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton_CasilleroLLaves.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_CasilleroLLaves.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_CasilleroLLaves.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_CasilleroLLaves.Iconimage")));
            this.bunifuFlatButton_CasilleroLLaves.Iconimage_right = null;
            this.bunifuFlatButton_CasilleroLLaves.Iconimage_right_Selected = null;
            this.bunifuFlatButton_CasilleroLLaves.Iconimage_Selected = null;
            this.bunifuFlatButton_CasilleroLLaves.IconMarginLeft = 0;
            this.bunifuFlatButton_CasilleroLLaves.IconMarginRight = 0;
            this.bunifuFlatButton_CasilleroLLaves.IconRightVisible = true;
            this.bunifuFlatButton_CasilleroLLaves.IconRightZoom = 0D;
            this.bunifuFlatButton_CasilleroLLaves.IconVisible = true;
            this.bunifuFlatButton_CasilleroLLaves.IconZoom = 50D;
            this.bunifuFlatButton_CasilleroLLaves.IsTab = false;
            this.bunifuFlatButton_CasilleroLLaves.Location = new System.Drawing.Point(-3, 295);
            this.bunifuFlatButton_CasilleroLLaves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton_CasilleroLLaves.Name = "bunifuFlatButton_CasilleroLLaves";
            this.bunifuFlatButton_CasilleroLLaves.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_CasilleroLLaves.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_CasilleroLLaves.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_CasilleroLLaves.selected = false;
            this.bunifuFlatButton_CasilleroLLaves.Size = new System.Drawing.Size(243, 70);
            this.bunifuFlatButton_CasilleroLLaves.TabIndex = 12;
            this.bunifuFlatButton_CasilleroLLaves.Text = "       CASILLERO LLAVES";
            this.bunifuFlatButton_CasilleroLLaves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton_CasilleroLLaves.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton_CasilleroLLaves.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton_CasilleroLLaves.Click += new System.EventHandler(this.bunifuFlatButton_CasilleroLLaves_Click);
            // 
            // bunifuFlatButton_ZonasParqueo
            // 
            this.bunifuFlatButton_ZonasParqueo.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_ZonasParqueo.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_ZonasParqueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_ZonasParqueo.BorderRadius = 0;
            this.bunifuFlatButton_ZonasParqueo.ButtonText = "       ZONAS PARQUEADERO";
            this.bunifuFlatButton_ZonasParqueo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton_ZonasParqueo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton_ZonasParqueo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton_ZonasParqueo.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_ZonasParqueo.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_ZonasParqueo.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_ZonasParqueo.Iconimage")));
            this.bunifuFlatButton_ZonasParqueo.Iconimage_right = null;
            this.bunifuFlatButton_ZonasParqueo.Iconimage_right_Selected = null;
            this.bunifuFlatButton_ZonasParqueo.Iconimage_Selected = null;
            this.bunifuFlatButton_ZonasParqueo.IconMarginLeft = 0;
            this.bunifuFlatButton_ZonasParqueo.IconMarginRight = 0;
            this.bunifuFlatButton_ZonasParqueo.IconRightVisible = true;
            this.bunifuFlatButton_ZonasParqueo.IconRightZoom = 0D;
            this.bunifuFlatButton_ZonasParqueo.IconVisible = true;
            this.bunifuFlatButton_ZonasParqueo.IconZoom = 50D;
            this.bunifuFlatButton_ZonasParqueo.IsTab = false;
            this.bunifuFlatButton_ZonasParqueo.Location = new System.Drawing.Point(-3, 225);
            this.bunifuFlatButton_ZonasParqueo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton_ZonasParqueo.Name = "bunifuFlatButton_ZonasParqueo";
            this.bunifuFlatButton_ZonasParqueo.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_ZonasParqueo.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_ZonasParqueo.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_ZonasParqueo.selected = false;
            this.bunifuFlatButton_ZonasParqueo.Size = new System.Drawing.Size(243, 70);
            this.bunifuFlatButton_ZonasParqueo.TabIndex = 11;
            this.bunifuFlatButton_ZonasParqueo.Text = "       ZONAS PARQUEADERO";
            this.bunifuFlatButton_ZonasParqueo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton_ZonasParqueo.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton_ZonasParqueo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton_ZonasParqueo.Click += new System.EventHandler(this.bunifuFlatButton_ZonasParqueo_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Wrapper.Controls.Add(this.PanelContenedor);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(260, 59);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(940, 561);
            this.Wrapper.TabIndex = 5;
            // 
            // bunifuFlatButton_AdministrarPersonal
            // 
            this.bunifuFlatButton_AdministrarPersonal.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_AdministrarPersonal.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_AdministrarPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_AdministrarPersonal.BorderRadius = 0;
            this.bunifuFlatButton_AdministrarPersonal.ButtonText = "       COORDINAR PERSONAL";
            this.bunifuFlatButton_AdministrarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton_AdministrarPersonal, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton_AdministrarPersonal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton_AdministrarPersonal.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_AdministrarPersonal.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_AdministrarPersonal.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_AdministrarPersonal.Iconimage")));
            this.bunifuFlatButton_AdministrarPersonal.Iconimage_right = null;
            this.bunifuFlatButton_AdministrarPersonal.Iconimage_right_Selected = null;
            this.bunifuFlatButton_AdministrarPersonal.Iconimage_Selected = null;
            this.bunifuFlatButton_AdministrarPersonal.IconMarginLeft = 0;
            this.bunifuFlatButton_AdministrarPersonal.IconMarginRight = 0;
            this.bunifuFlatButton_AdministrarPersonal.IconRightVisible = true;
            this.bunifuFlatButton_AdministrarPersonal.IconRightZoom = 0D;
            this.bunifuFlatButton_AdministrarPersonal.IconVisible = true;
            this.bunifuFlatButton_AdministrarPersonal.IconZoom = 50D;
            this.bunifuFlatButton_AdministrarPersonal.IsTab = false;
            this.bunifuFlatButton_AdministrarPersonal.Location = new System.Drawing.Point(-3, 155);
            this.bunifuFlatButton_AdministrarPersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton_AdministrarPersonal.Name = "bunifuFlatButton_AdministrarPersonal";
            this.bunifuFlatButton_AdministrarPersonal.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_AdministrarPersonal.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_AdministrarPersonal.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_AdministrarPersonal.selected = false;
            this.bunifuFlatButton_AdministrarPersonal.Size = new System.Drawing.Size(243, 70);
            this.bunifuFlatButton_AdministrarPersonal.TabIndex = 9;
            this.bunifuFlatButton_AdministrarPersonal.Text = "       COORDINAR PERSONAL";
            this.bunifuFlatButton_AdministrarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton_AdministrarPersonal.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton_AdministrarPersonal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton_AdministrarPersonal.Click += new System.EventHandler(this.bunifuFlatButton_AdministrarPersonal_Click);
            // 
            // PanelLateral
            // 
            this.PanelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.PanelLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLateral.BackgroundImage")));
            this.PanelLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLateral.Controls.Add(this.LineaSidebar);
            this.PanelLateral.Controls.Add(this.bunifuFlatButton_GestionControl);
            this.PanelLateral.Controls.Add(this.bunifuFlatButton6);
            this.PanelLateral.Controls.Add(this.bunifuFlatButton_CasilleroLLaves);
            this.PanelLateral.Controls.Add(this.bunifuFlatButton_ZonasParqueo);
            this.PanelLateral.Controls.Add(this.bunifuFlatButton_AdministrarPersonal);
            this.PanelLateral.Controls.Add(this.label2);
            this.PanelLateral.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.PanelLateral, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PanelLateral, BunifuAnimatorNS.DecorationType.None);
            this.PanelLateral.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PanelLateral.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PanelLateral.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PanelLateral.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PanelLateral.Location = new System.Drawing.Point(16, 10);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Quality = 10;
            this.PanelLateral.Size = new System.Drawing.Size(240, 539);
            this.PanelLateral.TabIndex = 0;
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineaSidebar.BackgroundImage")));
            this.LineaSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.GradientBottomLeft = System.Drawing.Color.White;
            this.LineaSidebar.GradientBottomRight = System.Drawing.Color.White;
            this.LineaSidebar.GradientTopLeft = System.Drawing.Color.White;
            this.LineaSidebar.GradientTopRight = System.Drawing.Color.White;
            this.LineaSidebar.Location = new System.Drawing.Point(4, 76);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Quality = 10;
            this.LineaSidebar.Size = new System.Drawing.Size(225, 1);
            this.LineaSidebar.TabIndex = 31;
            // 
            // bunifuFlatButton_GestionControl
            // 
            this.bunifuFlatButton_GestionControl.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_GestionControl.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_GestionControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_GestionControl.BorderRadius = 0;
            this.bunifuFlatButton_GestionControl.ButtonText = "       GESTION Y CONTROL";
            this.bunifuFlatButton_GestionControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton_GestionControl, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton_GestionControl, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton_GestionControl.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_GestionControl.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_GestionControl.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_GestionControl.Iconimage")));
            this.bunifuFlatButton_GestionControl.Iconimage_right = null;
            this.bunifuFlatButton_GestionControl.Iconimage_right_Selected = null;
            this.bunifuFlatButton_GestionControl.Iconimage_Selected = null;
            this.bunifuFlatButton_GestionControl.IconMarginLeft = 0;
            this.bunifuFlatButton_GestionControl.IconMarginRight = 0;
            this.bunifuFlatButton_GestionControl.IconRightVisible = true;
            this.bunifuFlatButton_GestionControl.IconRightZoom = 0D;
            this.bunifuFlatButton_GestionControl.IconVisible = true;
            this.bunifuFlatButton_GestionControl.IconZoom = 50D;
            this.bunifuFlatButton_GestionControl.IsTab = false;
            this.bunifuFlatButton_GestionControl.Location = new System.Drawing.Point(-3, 85);
            this.bunifuFlatButton_GestionControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton_GestionControl.Name = "bunifuFlatButton_GestionControl";
            this.bunifuFlatButton_GestionControl.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_GestionControl.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_GestionControl.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_GestionControl.selected = false;
            this.bunifuFlatButton_GestionControl.Size = new System.Drawing.Size(243, 70);
            this.bunifuFlatButton_GestionControl.TabIndex = 8;
            this.bunifuFlatButton_GestionControl.Text = "       GESTION Y CONTROL";
            this.bunifuFlatButton_GestionControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton_GestionControl.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton_GestionControl.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton_GestionControl.Click += new System.EventHandler(this.bunifuFlatButton_GestionControl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "VALET PARKING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SidebarWrapper.Controls.Add(this.PanelLateral);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 59);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(260, 561);
            this.SidebarWrapper.TabIndex = 4;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 1;
            animation6.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation6;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.PanelLateral;
            // 
            // toolTip_Etiquetas
            // 
            this.toolTip_Etiquetas.ShowAlways = true;
            // 
            // MenuValet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 620);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuValet";
            this.Text = "MenuValet";
            this.Load += new System.EventHandler(this.MenuValet_Load);
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.PanelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Panel PanelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_CasilleroLLaves;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_ZonasParqueo;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_AdministrarPersonal;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelLateral;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_GestionControl;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox pLogo;
        private Bunifu.Framework.UI.BunifuGradientPanel LineaSidebarTitle;
        private System.Windows.Forms.ToolTip toolTip_Etiquetas;
        private Bunifu.Framework.UI.BunifuGradientPanel LineaSidebar;
    }
}