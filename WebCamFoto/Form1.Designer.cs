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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWebCam));
            this.cmbSelectCam = new System.Windows.Forms.ComboBox();
            this.btmStartCam = new System.Windows.Forms.Button();
            this.imgWebCam = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPhotoImg = new System.Windows.Forms.Button();
            this.imgForSave = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForSave)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectCam
            // 
            this.cmbSelectCam.FormattingEnabled = true;
            this.cmbSelectCam.Location = new System.Drawing.Point(20, 20);
            this.cmbSelectCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSelectCam.Name = "cmbSelectCam";
            this.cmbSelectCam.Size = new System.Drawing.Size(200, 28);
            this.cmbSelectCam.TabIndex = 0;
            this.cmbSelectCam.Text = "Виберіть камеру";
            // 
            // btmStartCam
            // 
            this.btmStartCam.Location = new System.Drawing.Point(255, 20);
            this.btmStartCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmStartCam.Name = "btmStartCam";
            this.btmStartCam.Size = new System.Drawing.Size(150, 35);
            this.btmStartCam.TabIndex = 1;
            this.btmStartCam.Text = "Відкрити камеру";
            this.btmStartCam.UseVisualStyleBackColor = true;
            this.btmStartCam.Click += new System.EventHandler(this.BtmStartCam_Click);
            // 
            // imgWebCam
            // 
            this.imgWebCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgWebCam.Location = new System.Drawing.Point(20, 89);
            this.imgWebCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgWebCam.Name = "imgWebCam";
            this.imgWebCam.Size = new System.Drawing.Size(386, 557);
            this.imgWebCam.TabIndex = 2;
            this.imgWebCam.TabStop = false;
            this.imgWebCam.Click += new System.EventHandler(this.ImgWebCam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(435, 666);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФІО:";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(504, 666);
            this.tbFIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(314, 26);
            this.tbFIO.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(572, 717);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Зберегти ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(708, 717);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnPhotoImg
            // 
            this.btnPhotoImg.Location = new System.Drawing.Point(435, 717);
            this.btnPhotoImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPhotoImg.Name = "btnPhotoImg";
            this.btnPhotoImg.Size = new System.Drawing.Size(112, 35);
            this.btnPhotoImg.TabIndex = 7;
            this.btnPhotoImg.Text = "Фото";
            this.btnPhotoImg.UseVisualStyleBackColor = true;
            this.btnPhotoImg.Click += new System.EventHandler(this.BtnPhotoImg_Click);
            // 
            // imgForSave
            // 
            this.imgForSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgForSave.Location = new System.Drawing.Point(435, 89);
            this.imgForSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgForSave.Name = "imgForSave";
            this.imgForSave.Size = new System.Drawing.Size(386, 557);
            this.imgForSave.TabIndex = 8;
            this.imgForSave.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Зображення WEB-камери";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Зафіксоване фото для збереження";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 743);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "© Андрій Симоненко";
            // 
            // FormWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 772);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgForSave);
            this.Controls.Add(this.btnPhotoImg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgWebCam);
            this.Controls.Add(this.btmStartCam);
            this.Controls.Add(this.cmbSelectCam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormWebCam";
            this.Text = "ФотоПропуск";
            this.Load += new System.EventHandler(this.FormWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectCam;
        private System.Windows.Forms.Button btmStartCam;
        private System.Windows.Forms.PictureBox imgWebCam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPhotoImg;
        private System.Windows.Forms.PictureBox imgForSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

