namespace yazılımYapımı
{
    partial class UserControlTest
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTest));
            this.panel4 = new System.Windows.Forms.Panel();
            this.Soru = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.Soru);
            this.panel4.Location = new System.Drawing.Point(0, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(726, 84);
            this.panel4.TabIndex = 18;
            // 
            // Soru
            // 
            this.Soru.AutoSize = true;
            this.Soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soru.ForeColor = System.Drawing.Color.White;
            this.Soru.Location = new System.Drawing.Point(130, 19);
            this.Soru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Soru.Name = "Soru";
            this.Soru.Size = new System.Drawing.Size(40, 16);
            this.Soru.TabIndex = 4;
            this.Soru.Text = "Soru";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FloralWhite;
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 61);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(234, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "İngilizce-Türkçe Sözlük Test Ekranı";
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Teal;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C.ForeColor = System.Drawing.Color.White;
            this.C.Location = new System.Drawing.Point(133, 260);
            this.C.Margin = new System.Windows.Forms.Padding(4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(112, 28);
            this.C.TabIndex = 14;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.Teal;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.D.ForeColor = System.Drawing.Color.White;
            this.D.Location = new System.Drawing.Point(457, 260);
            this.D.Margin = new System.Windows.Forms.Padding(4);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(112, 28);
            this.D.TabIndex = 13;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Teal;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B.ForeColor = System.Drawing.Color.White;
            this.B.Location = new System.Drawing.Point(457, 184);
            this.B.Margin = new System.Windows.Forms.Padding(4);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(112, 28);
            this.B.TabIndex = 12;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Teal;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(133, 185);
            this.A.Margin = new System.Windows.Forms.Padding(4);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(112, 28);
            this.A.TabIndex = 11;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "A)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "C)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "B)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "D)";
            // 
            // UserControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.C);
            this.Controls.Add(this.D);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "UserControlTest";
            this.Size = new System.Drawing.Size(727, 335);
            this.Load += new System.EventHandler(this.UserControlTest_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Soru;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
