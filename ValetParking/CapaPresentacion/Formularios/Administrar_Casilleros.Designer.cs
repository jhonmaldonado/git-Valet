namespace CapaPresentacion.Formularios
{
    partial class Administrar_Casilleros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar_Casilleros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ltxtNombres = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SwitchPersonal = new Bunifu.Framework.UI.BunifuSwitch();
            this.pIzquierda = new System.Windows.Forms.Panel();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DGCuposLlaves = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.VP_Id_CupoLlave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTituloIzquierda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lTituloDerecha = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SwitchEstado = new Bunifu.Framework.UI.BunifuSwitch();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pDerecha = new System.Windows.Forms.Panel();
            this.pIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCuposLlaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pDerecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltxtNombres
            // 
            this.ltxtNombres.AutoSize = true;
            this.ltxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ltxtNombres.Location = new System.Drawing.Point(193, 143);
            this.ltxtNombres.Name = "ltxtNombres";
            this.ltxtNombres.Size = new System.Drawing.Size(73, 16);
            this.ltxtNombres.TabIndex = 30;
            this.ltxtNombres.Text = "Nombre *";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 0;
            this.btnNuevo.ButtonText = "   NUEVO";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Iconimage")));
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 60D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(180, 14);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(130, 50);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "   NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Textcolor = System.Drawing.Color.LightGray;
            this.btnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // SwitchPersonal
            // 
            this.SwitchPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchPersonal.BorderRadius = 0;
            this.SwitchPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchPersonal.Location = new System.Drawing.Point(270, 69);
            this.SwitchPersonal.Name = "SwitchPersonal";
            this.SwitchPersonal.Oncolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(49)))));
            this.SwitchPersonal.Onoffcolor = System.Drawing.Color.DarkGray;
            this.SwitchPersonal.Size = new System.Drawing.Size(51, 19);
            this.SwitchPersonal.TabIndex = 0;
            this.SwitchPersonal.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchPersonal.Value = true;
            this.SwitchPersonal.Click += new System.EventHandler(this.SwitchPersonal_Click);
            // 
            // pIzquierda
            // 
            this.pIzquierda.Controls.Add(this.btnNuevo);
            this.pIzquierda.Controls.Add(this.btnEditar);
            this.pIzquierda.Controls.Add(this.DGCuposLlaves);
            this.pIzquierda.Controls.Add(this.lTituloIzquierda);
            this.pIzquierda.Controls.Add(this.label1);
            this.pIzquierda.Controls.Add(this.SwitchPersonal);
            this.pIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pIzquierda.Location = new System.Drawing.Point(0, 0);
            this.pIzquierda.Margin = new System.Windows.Forms.Padding(2);
            this.pIzquierda.Name = "pIzquierda";
            this.pIzquierda.Size = new System.Drawing.Size(455, 502);
            this.pIzquierda.TabIndex = 7;
            this.pIzquierda.SizeChanged += new System.EventHandler(this.pIzquierda_SizeChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "   EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 50D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(318, 14);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(130, 50);
            this.btnEditar.TabIndex = 315;
            this.btnEditar.Text = "   EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.LightGray;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // DGCuposLlaves
            // 
            this.DGCuposLlaves.AllowUserToAddRows = false;
            this.DGCuposLlaves.AllowUserToDeleteRows = false;
            this.DGCuposLlaves.AllowUserToResizeColumns = false;
            this.DGCuposLlaves.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGCuposLlaves.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGCuposLlaves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGCuposLlaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCuposLlaves.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGCuposLlaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGCuposLlaves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCuposLlaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGCuposLlaves.ColumnHeadersHeight = 40;
            this.DGCuposLlaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGCuposLlaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VP_Id_CupoLlave,
            this.Cupo,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGCuposLlaves.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGCuposLlaves.DoubleBuffered = true;
            this.DGCuposLlaves.EnableHeadersVisualStyles = false;
            this.DGCuposLlaves.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.DGCuposLlaves.HeaderForeColor = System.Drawing.Color.White;
            this.DGCuposLlaves.Location = new System.Drawing.Point(8, 94);
            this.DGCuposLlaves.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.DGCuposLlaves.MultiSelect = false;
            this.DGCuposLlaves.Name = "DGCuposLlaves";
            this.DGCuposLlaves.ReadOnly = true;
            this.DGCuposLlaves.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCuposLlaves.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGCuposLlaves.RowHeadersVisible = false;
            this.DGCuposLlaves.RowHeadersWidth = 10;
            this.DGCuposLlaves.RowTemplate.Height = 40;
            this.DGCuposLlaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGCuposLlaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCuposLlaves.Size = new System.Drawing.Size(440, 398);
            this.DGCuposLlaves.TabIndex = 314;
            this.DGCuposLlaves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCuposLlaves_CellClick);
            // 
            // VP_Id_CupoLlave
            // 
            this.VP_Id_CupoLlave.DataPropertyName = "VP_Id_CupoLlave";
            this.VP_Id_CupoLlave.HeaderText = "VP_Id_CupoLlave";
            this.VP_Id_CupoLlave.Name = "VP_Id_CupoLlave";
            this.VP_Id_CupoLlave.ReadOnly = true;
            this.VP_Id_CupoLlave.Visible = false;
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "Cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // lTituloIzquierda
            // 
            this.lTituloIzquierda.AutoSize = true;
            this.lTituloIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTituloIzquierda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lTituloIzquierda.Location = new System.Drawing.Point(11, 40);
            this.lTituloIzquierda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTituloIzquierda.Name = "lTituloIzquierda";
            this.lTituloIzquierda.Size = new System.Drawing.Size(349, 24);
            this.lTituloIzquierda.TabIndex = 7;
            this.lTituloIzquierda.Text = "ADMINISTRAR CASILLERO LLAVES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOSTRAR SOLO CUPOS ACTIVOS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lTituloDerecha
            // 
            this.lTituloDerecha.AutoSize = true;
            this.lTituloDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTituloDerecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lTituloDerecha.Location = new System.Drawing.Point(11, 40);
            this.lTituloDerecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTituloDerecha.Name = "lTituloDerecha";
            this.lTituloDerecha.Size = new System.Drawing.Size(216, 24);
            this.lTituloDerecha.TabIndex = 28;
            this.lTituloDerecha.Text = "NUEVO CUPO LLAVE";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(4, 505);
            this.bunifuSeparator1.TabIndex = 27;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "   GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 50D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(312, 194);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(130, 50);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "   GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.LightGray;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(12, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Estado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // SwitchEstado
            // 
            this.SwitchEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchEstado.BorderRadius = 0;
            this.SwitchEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchEstado.Location = new System.Drawing.Point(75, 69);
            this.SwitchEstado.Name = "SwitchEstado";
            this.SwitchEstado.Oncolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(49)))));
            this.SwitchEstado.Onoffcolor = System.Drawing.Color.DarkGray;
            this.SwitchEstado.Size = new System.Drawing.Size(51, 19);
            this.SwitchEstado.TabIndex = 17;
            this.SwitchEstado.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchEstado.Value = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(212)))), ((int)(((byte)(91)))));
            this.txtNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.txtNombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(212)))), ((int)(((byte)(91)))));
            this.txtNombre.BorderThickness = 1;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNombre.isPassword = false;
            this.txtNombre.Location = new System.Drawing.Point(196, 163);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 22);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // pDerecha
            // 
            this.pDerecha.Controls.Add(this.txtNombre);
            this.pDerecha.Controls.Add(this.ltxtNombres);
            this.pDerecha.Controls.Add(this.lTituloDerecha);
            this.pDerecha.Controls.Add(this.bunifuSeparator1);
            this.pDerecha.Controls.Add(this.btnGuardar);
            this.pDerecha.Controls.Add(this.label11);
            this.pDerecha.Controls.Add(this.pictureBox1);
            this.pDerecha.Controls.Add(this.SwitchEstado);
            this.pDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDerecha.Location = new System.Drawing.Point(455, 0);
            this.pDerecha.Margin = new System.Windows.Forms.Padding(2);
            this.pDerecha.Name = "pDerecha";
            this.pDerecha.Size = new System.Drawing.Size(452, 502);
            this.pDerecha.TabIndex = 6;
            // 
            // Administrar_Casilleros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 502);
            this.Controls.Add(this.pIzquierda);
            this.Controls.Add(this.pDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrar_Casilleros";
            this.Text = "Administrar_Casilleros";
            this.Load += new System.EventHandler(this.Administrar_Casilleros_Load);
            this.pIzquierda.ResumeLayout(false);
            this.pIzquierda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCuposLlaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pDerecha.ResumeLayout(false);
            this.pDerecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ltxtNombres;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private Bunifu.Framework.UI.BunifuSwitch SwitchPersonal;
        private System.Windows.Forms.Panel pIzquierda;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid DGCuposLlaves;
        private System.Windows.Forms.Label lTituloIzquierda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lTituloDerecha;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSwitch SwitchEstado;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        private System.Windows.Forms.Panel pDerecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn VP_Id_CupoLlave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}