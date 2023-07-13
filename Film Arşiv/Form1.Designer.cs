namespace Film_Arşiv
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilmEkle = new System.Windows.Forms.Button();
            this.textBoxFilmLink = new System.Windows.Forms.TextBox();
            this.comboBoxKatFilm = new System.Windows.Forms.ComboBox();
            this.textBoxFilmAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonçık = new System.Windows.Forms.Button();
            this.buttonrnkdgs = new System.Windows.Forms.Button();
            this.buttonhak = new System.Windows.Forms.Button();
            this.buttontamekran = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonFilmEkle);
            this.groupBox2.Controls.Add(this.textBoxFilmLink);
            this.groupBox2.Controls.Add(this.comboBoxKatFilm);
            this.groupBox2.Controls.Add(this.textBoxFilmAd);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Film Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad";
            // 
            // buttonFilmEkle
            // 
            this.buttonFilmEkle.Location = new System.Drawing.Point(77, 120);
            this.buttonFilmEkle.Name = "buttonFilmEkle";
            this.buttonFilmEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonFilmEkle.TabIndex = 3;
            this.buttonFilmEkle.Text = "Ekle";
            this.buttonFilmEkle.UseVisualStyleBackColor = true;
            this.buttonFilmEkle.Click += new System.EventHandler(this.buttonFilmEkle_Click);
            // 
            // textBoxFilmLink
            // 
            this.textBoxFilmLink.Location = new System.Drawing.Point(64, 66);
            this.textBoxFilmLink.Name = "textBoxFilmLink";
            this.textBoxFilmLink.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilmLink.TabIndex = 2;
            // 
            // comboBoxKatFilm
            // 
            this.comboBoxKatFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKatFilm.FormattingEnabled = true;
            this.comboBoxKatFilm.Location = new System.Drawing.Point(64, 92);
            this.comboBoxKatFilm.Name = "comboBoxKatFilm";
            this.comboBoxKatFilm.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKatFilm.TabIndex = 1;
            // 
            // textBoxFilmAd
            // 
            this.textBoxFilmAd.Location = new System.Drawing.Point(64, 40);
            this.textBoxFilmAd.Name = "textBoxFilmAd";
            this.textBoxFilmAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilmAd.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonçık);
            this.groupBox3.Controls.Add(this.buttonrnkdgs);
            this.groupBox3.Controls.Add(this.buttonhak);
            this.groupBox3.Controls.Add(this.buttontamekran);
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // buttonçık
            // 
            this.buttonçık.Location = new System.Drawing.Point(13, 106);
            this.buttonçık.Name = "buttonçık";
            this.buttonçık.Size = new System.Drawing.Size(151, 23);
            this.buttonçık.TabIndex = 7;
            this.buttonçık.Text = "Çıkış";
            this.buttonçık.UseVisualStyleBackColor = true;
            this.buttonçık.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonrnkdgs
            // 
            this.buttonrnkdgs.Location = new System.Drawing.Point(13, 77);
            this.buttonrnkdgs.Name = "buttonrnkdgs";
            this.buttonrnkdgs.Size = new System.Drawing.Size(151, 23);
            this.buttonrnkdgs.TabIndex = 6;
            this.buttonrnkdgs.Text = "Renk Değiştir";
            this.buttonrnkdgs.UseVisualStyleBackColor = true;
            this.buttonrnkdgs.Click += new System.EventHandler(this.buttonrnkdgs_Click);
            // 
            // buttonhak
            // 
            this.buttonhak.Location = new System.Drawing.Point(13, 48);
            this.buttonhak.Name = "buttonhak";
            this.buttonhak.Size = new System.Drawing.Size(151, 23);
            this.buttonhak.TabIndex = 5;
            this.buttonhak.Text = "Hakkımızda";
            this.buttonhak.UseVisualStyleBackColor = true;
            this.buttonhak.Click += new System.EventHandler(this.buttonhak_Click);
            // 
            // buttontamekran
            // 
            this.buttontamekran.Location = new System.Drawing.Point(13, 19);
            this.buttontamekran.Name = "buttontamekran";
            this.buttontamekran.Size = new System.Drawing.Size(151, 23);
            this.buttontamekran.TabIndex = 4;
            this.buttontamekran.Text = "Detay";
            this.buttontamekran.UseVisualStyleBackColor = true;
            this.buttontamekran.Click += new System.EventHandler(this.buttontamekran_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(224, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 294);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(189, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.webBrowser1);
            this.groupBox5.Location = new System.Drawing.Point(441, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 294);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(281, 275);
            this.webBrowser1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonFilmEkle;
        private System.Windows.Forms.TextBox textBoxFilmLink;
        private System.Windows.Forms.ComboBox comboBoxKatFilm;
        private System.Windows.Forms.TextBox textBoxFilmAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonçık;
        private System.Windows.Forms.Button buttonrnkdgs;
        private System.Windows.Forms.Button buttonhak;
        private System.Windows.Forms.Button buttontamekran;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

