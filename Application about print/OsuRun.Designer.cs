namespace Application_about_print
{
    partial class osuLancher
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osuLancher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.third = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // third
            // 
            this.third.Cursor = System.Windows.Forms.Cursors.Default;
            this.third.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.third.Location = new System.Drawing.Point(37, 340);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(261, 65);
            this.third.TabIndex = 2;
            this.third.UseVisualStyleBackColor = true;
            this.third.Click += new System.EventHandler(this.third_Click);
            // 
            // first
            // 
            this.first.Cursor = System.Windows.Forms.Cursors.Default;
            this.first.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.first.Location = new System.Drawing.Point(37, 197);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(261, 65);
            this.first.TabIndex = 3;
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // second
            // 
            this.second.Cursor = System.Windows.Forms.Cursors.Default;
            this.second.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.second.Location = new System.Drawing.Point(37, 268);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(261, 65);
            this.second.TabIndex = 7;
            this.second.UseVisualStyleBackColor = true;
            this.second.Click += new System.EventHandler(this.second_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackgroundImage = global::Application_about_print.Properties.Resources._26565;
            this.settingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.settingButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.settingButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingButton.Location = new System.Drawing.Point(723, 12);
            this.settingButton.Name = "settingButton";
            this.settingButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingButton.Size = new System.Drawing.Size(35, 34);
            this.settingButton.TabIndex = 9;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // reload
            // 
            this.reload.BackgroundImage = global::Application_about_print.Properties.Resources.reload1;
            this.reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reload.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reload.Location = new System.Drawing.Point(723, 52);
            this.reload.Name = "reload";
            this.reload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reload.Size = new System.Drawing.Size(35, 34);
            this.reload.TabIndex = 10;
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Visible = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // osuLancher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Application_about_print.Properties.Resources.BGImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 431);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.third);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "osuLancher";
            this.Text = "osu! Launcher";
            this.Activated += new System.EventHandler(this.reload_Click);
            this.Load += new System.EventHandler(this.OsuRun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button reload;
        public System.Windows.Forms.Button first;
        public System.Windows.Forms.Button third;
        public System.Windows.Forms.Button second;
    }
}

