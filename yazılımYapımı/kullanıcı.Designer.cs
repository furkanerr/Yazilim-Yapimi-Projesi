namespace yazılımYapımı
{
    partial class kullanıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanıcı));
            this.Ogrenilen_btn = new System.Windows.Forms.Button();
            this.Test_btn = new System.Windows.Forms.Button();
            this.Ogrenilmis_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.userControl11 = new yazılımYapımı.UserControl1();
            this.userControlİstatistik1 = new yazılımYapımı.UserControlİstatistik();
            this.userControlOgrenilmis1 = new yazılımYapımı.UserControlOgrenilmis();
            this.userControlTest1 = new yazılımYapımı.UserControlTest();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ogrenilen_btn
            // 
            this.Ogrenilen_btn.FlatAppearance.BorderSize = 0;
            this.Ogrenilen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ogrenilen_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrenilen_btn.ForeColor = System.Drawing.Color.White;
            this.Ogrenilen_btn.Image = ((System.Drawing.Image)(resources.GetObject("Ogrenilen_btn.Image")));
            this.Ogrenilen_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ogrenilen_btn.Location = new System.Drawing.Point(12, 30);
            this.Ogrenilen_btn.Name = "Ogrenilen_btn";
            this.Ogrenilen_btn.Size = new System.Drawing.Size(127, 72);
            this.Ogrenilen_btn.TabIndex = 0;
            this.Ogrenilen_btn.Text = "Öğrenilen Kelimeler";
            this.Ogrenilen_btn.UseVisualStyleBackColor = true;
            this.Ogrenilen_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test_btn
            // 
            this.Test_btn.FlatAppearance.BorderSize = 0;
            this.Test_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Test_btn.ForeColor = System.Drawing.Color.White;
            this.Test_btn.Image = ((System.Drawing.Image)(resources.GetObject("Test_btn.Image")));
            this.Test_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Test_btn.Location = new System.Drawing.Point(12, 120);
            this.Test_btn.Name = "Test_btn";
            this.Test_btn.Size = new System.Drawing.Size(127, 72);
            this.Test_btn.TabIndex = 1;
            this.Test_btn.Text = "Testler";
            this.Test_btn.UseVisualStyleBackColor = true;
            this.Test_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ogrenilmis_btn
            // 
            this.Ogrenilmis_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ogrenilmis_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ogrenilmis_btn.FlatAppearance.BorderSize = 0;
            this.Ogrenilmis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ogrenilmis_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrenilmis_btn.ForeColor = System.Drawing.Color.White;
            this.Ogrenilmis_btn.Image = ((System.Drawing.Image)(resources.GetObject("Ogrenilmis_btn.Image")));
            this.Ogrenilmis_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ogrenilmis_btn.Location = new System.Drawing.Point(12, 198);
            this.Ogrenilmis_btn.Name = "Ogrenilmis_btn";
            this.Ogrenilmis_btn.Size = new System.Drawing.Size(127, 72);
            this.Ogrenilmis_btn.TabIndex = 2;
            this.Ogrenilmis_btn.Text = "Öğrenilmiş Kelimeler";
            this.Ogrenilmis_btn.UseVisualStyleBackColor = false;
            this.Ogrenilmis_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.Ogrenilen_btn);
            this.panel1.Controls.Add(this.Test_btn);
            this.panel1.Controls.Add(this.Ogrenilmis_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 363);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 72);
            this.button2.TabIndex = 6;
            this.button2.Text = "İstatistik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 30);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(11, 72);
            this.SidePanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(138, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 34);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(684, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userControlTest1);
            this.panel6.Controls.Add(this.userControlOgrenilmis1);
            this.panel6.Controls.Add(this.userControlİstatistik1);
            this.panel6.Controls.Add(this.userControl11);
            this.panel6.Location = new System.Drawing.Point(139, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(720, 336);
            this.panel6.TabIndex = 5;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Silver;
            this.userControl11.Location = new System.Drawing.Point(-1, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(723, 333);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userControlİstatistik1
            // 
            this.userControlİstatistik1.Location = new System.Drawing.Point(-1, 0);
            this.userControlİstatistik1.Name = "userControlİstatistik1";
            this.userControlİstatistik1.Size = new System.Drawing.Size(723, 333);
            this.userControlİstatistik1.TabIndex = 1;
            // 
            // userControlOgrenilmis1
            // 
            this.userControlOgrenilmis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControlOgrenilmis1.Location = new System.Drawing.Point(-1, 1);
            this.userControlOgrenilmis1.Name = "userControlOgrenilmis1";
            this.userControlOgrenilmis1.Size = new System.Drawing.Size(723, 333);
            this.userControlOgrenilmis1.TabIndex = 2;
            // 
            // userControlTest1
            // 
            this.userControlTest1.Location = new System.Drawing.Point(-1, -1);
            this.userControlTest1.Name = "userControlTest1";
            this.userControlTest1.Size = new System.Drawing.Size(723, 333);
            this.userControlTest1.TabIndex = 3;
            // 
            // kullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 363);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kullanıcı";
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.kullanıcı_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ogrenilen_btn;
        private System.Windows.Forms.Button Test_btn;
        private System.Windows.Forms.Button Ogrenilmis_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControlTest userControlTest1;
        private UserControlOgrenilmis userControlOgrenilmis1;
        private UserControlİstatistik userControlİstatistik1;
    }
}