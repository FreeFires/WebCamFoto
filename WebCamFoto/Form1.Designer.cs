namespace WebCamFoto
{
    partial class FormWebCam
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSelectCam = new System.Windows.Forms.ComboBox();
            this.btmStartCam = new System.Windows.Forms.Button();
            this.imgWebCam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectCam
            // 
            this.cmbSelectCam.FormattingEnabled = true;
            this.cmbSelectCam.Location = new System.Drawing.Point(13, 13);
            this.cmbSelectCam.Name = "cmbSelectCam";
            this.cmbSelectCam.Size = new System.Drawing.Size(135, 21);
            this.cmbSelectCam.TabIndex = 0;
            this.cmbSelectCam.Text = "Виберіть камеру";
            // 
            // btmStartCam
            // 
            this.btmStartCam.Location = new System.Drawing.Point(170, 13);
            this.btmStartCam.Name = "btmStartCam";
            this.btmStartCam.Size = new System.Drawing.Size(100, 23);
            this.btmStartCam.TabIndex = 1;
            this.btmStartCam.Text = "Відкрити камеру";
            this.btmStartCam.UseVisualStyleBackColor = true;
            this.btmStartCam.Click += new System.EventHandler(this.BtmStartCam_Click);
            // 
            // imgWebCam
            // 
            this.imgWebCam.Location = new System.Drawing.Point(13, 58);
            this.imgWebCam.Name = "imgWebCam";
            this.imgWebCam.Size = new System.Drawing.Size(257, 362);
            this.imgWebCam.TabIndex = 2;
            this.imgWebCam.TabStop = false;
            this.imgWebCam.Click += new System.EventHandler(this.ImgWebCam_Click);
            // 
            // FormWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 502);
            this.Controls.Add(this.imgWebCam);
            this.Controls.Add(this.btmStartCam);
            this.Controls.Add(this.cmbSelectCam);
            this.Name = "FormWebCam";
            this.Text = "FormWebCam";
            this.Load += new System.EventHandler(this.FormWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgWebCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectCam;
        private System.Windows.Forms.Button btmStartCam;
        private System.Windows.Forms.PictureBox imgWebCam;
    }
}

