namespace Application_about_print
{
    partial class OsuRun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsuRun));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mamesakatsuki = new System.Windows.Forms.Button();
            this.official = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.replayMoves = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mamesosu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // mamesakatsuki
            // 
            this.mamesakatsuki.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mamesakatsuki.Location = new System.Drawing.Point(37, 340);
            this.mamesakatsuki.Name = "mamesakatsuki";
            this.mamesakatsuki.Size = new System.Drawing.Size(261, 65);
            this.mamesakatsuki.TabIndex = 2;
            this.mamesakatsuki.Text = "Run osu! Mames server";
            this.mamesakatsuki.UseVisualStyleBackColor = true;
            this.mamesakatsuki.Click += new System.EventHandler(this.mames_Click);
            // 
            // official
            // 
            this.official.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.official.Location = new System.Drawing.Point(37, 197);
            this.official.Name = "official";
            this.official.Size = new System.Drawing.Size(261, 65);
            this.official.TabIndex = 3;
            this.official.Text = "Run osu! official server";
            this.official.UseVisualStyleBackColor = true;
            this.official.Click += new System.EventHandler(this.official_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(615, 370);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(137, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Replay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // replayMoves
            // 
            this.replayMoves.AutoSize = true;
            this.replayMoves.BackColor = System.Drawing.Color.White;
            this.replayMoves.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.replayMoves.Location = new System.Drawing.Point(24, 37);
            this.replayMoves.Name = "replayMoves";
            this.replayMoves.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.replayMoves.Size = new System.Drawing.Size(210, 28);
            this.replayMoves.TabIndex = 5;
            this.replayMoves.Text = "Move Replay files";
            this.replayMoves.UseVisualStyleBackColor = false;
            this.replayMoves.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mamesosu
            // 
            this.mamesosu.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mamesosu.Location = new System.Drawing.Point(37, 268);
            this.mamesosu.Name = "mamesosu";
            this.mamesosu.Size = new System.Drawing.Size(261, 65);
            this.mamesosu.TabIndex = 7;
            this.mamesosu.Text = "Run osu! Mames server";
            this.mamesosu.UseVisualStyleBackColor = true;
            this.mamesosu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(166, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 12);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "with Akatsuki Patcher";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(723, 12);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // OsuRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(764, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mamesosu);
            this.Controls.Add(this.replayMoves);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.official);
            this.Controls.Add(this.mamesakatsuki);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OsuRun";
            this.Text = "osu! loader";
            this.Load += new System.EventHandler(this.OsuRun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mamesakatsuki;
        private System.Windows.Forms.Button official;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox replayMoves;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button mamesosu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

