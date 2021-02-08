namespace CapaPresentacion.Formularios
{
    partial class MessageErrorOk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageErrorOk));
            this.pTitulo = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.pCuerpo = new System.Windows.Forms.Panel();
            this.pAdvertencia = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lMessage = new System.Windows.Forms.Label();
            this.pOk = new System.Windows.Forms.PictureBox();
            this.pError = new System.Windows.Forms.PictureBox();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TimerClose = new System.Windows.Forms.Timer(this.components);
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.pCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAdvertencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).BeginInit();
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
            this.pTitulo.TabIndex = 2;
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
            this.pCuerpo.Controls.Add(this.pAdvertencia);
            this.pCuerpo.Controls.Add(this.btnAceptar);
            this.pCuerpo.Controls.Add(this.lMessage);
            this.pCuerpo.Controls.Add(this.pOk);
            this.pCuerpo.Controls.Add(this.pError);
            this.pCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCuerpo.Location = new System.Drawing.Point(0, 36);
            this.pCuerpo.Name = "pCuerpo";
            this.pCuerpo.Size = new System.Drawing.Size(354, 135);
            this.pCuerpo.TabIndex = 3;
            // 
            // pAdvertencia
            // 
            this.pAdvertencia.Image = ((System.Drawing.Image)(resources.GetObject("pAdvertencia.Image")));
            this.pAdvertencia.Location = new System.Drawing.Point(12, 21);
            this.pAdvertencia.Name = "pAdvertencia";
            this.pAdvertencia.Size = new System.Drawing.Size(110, 96);
            this.pAdvertencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pAdvertencia.TabIndex = 24;
            this.pAdvertencia.TabStop = false;
            this.pAdvertencia.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.BorderRadius = 0;
            this.btnAceptar.ButtonText = "Aceptar";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.Iconimage = null;
            this.btnAceptar.Iconimage_right = null;
            this.btnAceptar.Iconimage_right_Selected = null;
            this.btnAceptar.Iconimage_Selected = null;
            this.btnAceptar.IconMarginLeft = 0;
            this.btnAceptar.IconMarginRight = 0;
            this.btnAceptar.IconRightVisible = true;
            this.btnAceptar.IconRightZoom = 0D;
            this.btnAceptar.IconVisible = true;
            this.btnAceptar.IconZoom = 50D;
            this.btnAceptar.IsTab = false;
            this.btnAceptar.Location = new System.Drawing.Point(240, 89);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnAceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(110, 40);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Textcolor = System.Drawing.Color.LightGray;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lMessage
            // 
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(128, 21);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(222, 63);
            this.lMessage.TabIndex = 20;
            // 
            // pOk
            // 
            this.pOk.Image = ((System.Drawing.Image)(resources.GetObject("pOk.Image")));
            this.pOk.Location = new System.Drawing.Point(12, 21);
            this.pOk.Name = "pOk";
            this.pOk.Size = new System.Drawing.Size(110, 96);
            this.pOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pOk.TabIndex = 23;
            this.pOk.TabStop = false;
            this.pOk.Visible = false;
            // 
            // pError
            // 
            this.pError.Image = ((System.Drawing.Image)(resources.GetObject("pError.Image")));
            this.pError.Location = new System.Drawing.Point(12, 21);
            this.pError.Name = "pError";
            this.pError.Size = new System.Drawing.Size(110, 96);
            this.pError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pError.TabIndex = 19;
            this.pError.TabStop = false;
            this.pError.Visible = false;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TimerClose
            // 
            this.TimerClose.Enabled = true;
            this.TimerClose.Interval = 10000;
            this.TimerClose.Tick += new System.EventHandler(this.TimerClose_Tick);
            // 
            // MessageErrorOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 171);
            this.Controls.Add(this.pCuerpo);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageErrorOk";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageAdv";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessageAdv_Load);
            this.pTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.pCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pAdvertencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel pCuerpo;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.PictureBox pError;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pOk;
        private System.Windows.Forms.Timer TimerClose;
        private System.Windows.Forms.PictureBox pAdvertencia;
    }
}