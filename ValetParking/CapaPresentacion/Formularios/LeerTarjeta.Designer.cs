namespace CapaPresentacion.Formularios
{
    partial class LeerTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeerTarjeta));
            this.pTitulo = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.pCuerpo = new System.Windows.Forms.Panel();
            this.bunifuFlatButton_GestionControl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ltjuso = new System.Windows.Forms.Label();
            this.lMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.TimerClose = new System.Windows.Forms.Timer(this.components);
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.pCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pTitulo.Controls.Add(this.Salir);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(370, 36);
            this.pTitulo.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(337, 3);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 3;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pCuerpo
            // 
            this.pCuerpo.BackColor = System.Drawing.Color.White;
            this.pCuerpo.Controls.Add(this.bunifuFlatButton_GestionControl);
            this.pCuerpo.Controls.Add(this.ltjuso);
            this.pCuerpo.Controls.Add(this.lMessage);
            this.pCuerpo.Controls.Add(this.pictureBox1);
            this.pCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCuerpo.Location = new System.Drawing.Point(0, 36);
            this.pCuerpo.Name = "pCuerpo";
            this.pCuerpo.Size = new System.Drawing.Size(370, 174);
            this.pCuerpo.TabIndex = 1;
            // 
            // bunifuFlatButton_GestionControl
            // 
            this.bunifuFlatButton_GestionControl.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.bunifuFlatButton_GestionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.bunifuFlatButton_GestionControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_GestionControl.BorderRadius = 0;
            this.bunifuFlatButton_GestionControl.ButtonText = "CANCELAR";
            this.bunifuFlatButton_GestionControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton_GestionControl.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_GestionControl.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_GestionControl.Iconimage = null;
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
            this.bunifuFlatButton_GestionControl.Location = new System.Drawing.Point(183, 122);
            this.bunifuFlatButton_GestionControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton_GestionControl.Name = "bunifuFlatButton_GestionControl";
            this.bunifuFlatButton_GestionControl.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.bunifuFlatButton_GestionControl.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.bunifuFlatButton_GestionControl.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_GestionControl.selected = false;
            this.bunifuFlatButton_GestionControl.Size = new System.Drawing.Size(110, 40);
            this.bunifuFlatButton_GestionControl.TabIndex = 22;
            this.bunifuFlatButton_GestionControl.Text = "CANCELAR";
            this.bunifuFlatButton_GestionControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton_GestionControl.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton_GestionControl.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton_GestionControl.Click += new System.EventHandler(this.bunifuFlatButton_GestionControl_Click);
            // 
            // ltjuso
            // 
            this.ltjuso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltjuso.ForeColor = System.Drawing.Color.Red;
            this.ltjuso.Location = new System.Drawing.Point(128, 89);
            this.ltjuso.Name = "ltjuso";
            this.ltjuso.Size = new System.Drawing.Size(230, 28);
            this.ltjuso.TabIndex = 21;
            this.ltjuso.Text = "Tarjeta en uso.";
            this.ltjuso.Visible = false;
            // 
            // lMessage
            // 
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(128, 43);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(230, 46);
            this.lMessage.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // TimerClose
            // 
            this.TimerClose.Enabled = true;
            this.TimerClose.Interval = 10000;
            this.TimerClose.Tick += new System.EventHandler(this.TimerClose_Tick);
            // 
            // LeerTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 210);
            this.Controls.Add(this.pCuerpo);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LeerTarjeta";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeerTarjeta";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LeerTarjeta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LeerTarjeta_KeyDown);
            this.pTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.pCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pCuerpo;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Label ltjuso;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_GestionControl;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.Timer TimerClose;
    }
}