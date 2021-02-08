namespace CapaPresentacion.Formularios
{
    partial class MessageSiNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageSiNo));
            this.pTitulo = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.pCuerpo = new System.Windows.Forms.Panel();
            this.btnNo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSi = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.pTitulo.Size = new System.Drawing.Size(354, 36);
            this.pTitulo.TabIndex = 1;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(321, 3);
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
            this.pCuerpo.Controls.Add(this.btnNo);
            this.pCuerpo.Controls.Add(this.btnSi);
            this.pCuerpo.Controls.Add(this.lMessage);
            this.pCuerpo.Controls.Add(this.pictureBox1);
            this.pCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCuerpo.Location = new System.Drawing.Point(0, 36);
            this.pCuerpo.Name = "pCuerpo";
            this.pCuerpo.Size = new System.Drawing.Size(354, 170);
            this.pCuerpo.TabIndex = 2;
            // 
            // btnNo
            // 
            this.btnNo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNo.BorderRadius = 0;
            this.btnNo.ButtonText = "NO";
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNo.Iconimage = null;
            this.btnNo.Iconimage_right = null;
            this.btnNo.Iconimage_right_Selected = null;
            this.btnNo.Iconimage_Selected = null;
            this.btnNo.IconMarginLeft = 0;
            this.btnNo.IconMarginRight = 0;
            this.btnNo.IconRightVisible = true;
            this.btnNo.IconRightZoom = 0D;
            this.btnNo.IconVisible = true;
            this.btnNo.IconZoom = 50D;
            this.btnNo.IsTab = false;
            this.btnNo.Location = new System.Drawing.Point(122, 122);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnNo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnNo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNo.selected = false;
            this.btnNo.Size = new System.Drawing.Size(110, 40);
            this.btnNo.TabIndex = 23;
            this.btnNo.Text = "NO";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.Textcolor = System.Drawing.Color.LightGray;
            this.btnNo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSi.BorderRadius = 0;
            this.btnSi.ButtonText = "SI";
            this.btnSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSi.DisabledColor = System.Drawing.Color.Gray;
            this.btnSi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSi.Iconimage = null;
            this.btnSi.Iconimage_right = null;
            this.btnSi.Iconimage_right_Selected = null;
            this.btnSi.Iconimage_Selected = null;
            this.btnSi.IconMarginLeft = 0;
            this.btnSi.IconMarginRight = 0;
            this.btnSi.IconRightVisible = true;
            this.btnSi.IconRightZoom = 0D;
            this.btnSi.IconVisible = true;
            this.btnSi.IconZoom = 50D;
            this.btnSi.IsTab = false;
            this.btnSi.Location = new System.Drawing.Point(240, 122);
            this.btnSi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSi.Name = "btnSi";
            this.btnSi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnSi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnSi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSi.selected = false;
            this.btnSi.Size = new System.Drawing.Size(110, 40);
            this.btnSi.TabIndex = 22;
            this.btnSi.Text = "SI";
            this.btnSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSi.Textcolor = System.Drawing.Color.LightGray;
            this.btnSi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // lMessage
            // 
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(128, 21);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(222, 96);
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
            // MessageSiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 206);
            this.Controls.Add(this.pCuerpo);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageSiNo";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageSiNo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessageSiNo_Load);
            this.pTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.pCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel pCuerpo;
        private Bunifu.Framework.UI.BunifuFlatButton btnNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnSi;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.Timer TimerClose;
    }
}