namespace School
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonStud = new System.Windows.Forms.Button();
            this.buttonPredm = new System.Windows.Forms.Button();
            this.buttonTeatch = new System.Windows.Forms.Button();
            this.buttonBall = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStud
            // 
            this.buttonStud.BackColor = System.Drawing.Color.Salmon;
            this.buttonStud.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStud.Location = new System.Drawing.Point(93, 181);
            this.buttonStud.Name = "buttonStud";
            this.buttonStud.Size = new System.Drawing.Size(318, 53);
            this.buttonStud.TabIndex = 1;
            this.buttonStud.Text = "Ученики";
            this.buttonStud.UseVisualStyleBackColor = false;
            this.buttonStud.Click += new System.EventHandler(this.buttonStud_Click);
            // 
            // buttonPredm
            // 
            this.buttonPredm.BackColor = System.Drawing.Color.Salmon;
            this.buttonPredm.Location = new System.Drawing.Point(93, 259);
            this.buttonPredm.Name = "buttonPredm";
            this.buttonPredm.Size = new System.Drawing.Size(318, 57);
            this.buttonPredm.TabIndex = 2;
            this.buttonPredm.Text = "Предметы";
            this.buttonPredm.UseVisualStyleBackColor = false;
            this.buttonPredm.Click += new System.EventHandler(this.buttonPredm_Click);
            // 
            // buttonTeatch
            // 
            this.buttonTeatch.BackColor = System.Drawing.Color.Salmon;
            this.buttonTeatch.Location = new System.Drawing.Point(93, 338);
            this.buttonTeatch.Name = "buttonTeatch";
            this.buttonTeatch.Size = new System.Drawing.Size(318, 54);
            this.buttonTeatch.TabIndex = 3;
            this.buttonTeatch.Text = "Учителя";
            this.buttonTeatch.UseVisualStyleBackColor = false;
            this.buttonTeatch.Click += new System.EventHandler(this.buttonTeatch_Click);
            // 
            // buttonBall
            // 
            this.buttonBall.BackColor = System.Drawing.Color.Salmon;
            this.buttonBall.Location = new System.Drawing.Point(93, 416);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(318, 53);
            this.buttonBall.TabIndex = 4;
            this.buttonBall.Text = "Оценки";
            this.buttonBall.UseVisualStyleBackColor = false;
            this.buttonBall.Click += new System.EventHandler(this.buttonBall_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(496, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBall);
            this.Controls.Add(this.buttonTeatch);
            this.Controls.Add(this.buttonPredm);
            this.Controls.Add(this.buttonStud);
            this.Name = "Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStud;
        private System.Windows.Forms.Button buttonPredm;
        private System.Windows.Forms.Button buttonTeatch;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

