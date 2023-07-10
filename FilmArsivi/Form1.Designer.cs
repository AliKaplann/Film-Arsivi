namespace FilmArsivi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btntema = new System.Windows.Forms.Button();
            this.btnhakkımızda = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfilmad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinema Koltuk Yazılım";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(782, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(279, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 450);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(549, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 479);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film İzleme";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(494, 453);
            this.webBrowser1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.txtlink);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtkategori);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtfilmad);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(2, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 482);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Film";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btncikis);
            this.groupBox4.Controls.Add(this.btntema);
            this.groupBox4.Controls.Add(this.btnhakkımızda);
            this.groupBox4.Location = new System.Drawing.Point(10, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 245);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(28, 146);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(200, 33);
            this.btncikis.TabIndex = 14;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btntema
            // 
            this.btntema.Location = new System.Drawing.Point(26, 107);
            this.btntema.Name = "btntema";
            this.btntema.Size = new System.Drawing.Size(200, 33);
            this.btntema.TabIndex = 13;
            this.btntema.Text = "Tema";
            this.btntema.UseVisualStyleBackColor = true;
            this.btntema.Click += new System.EventHandler(this.btntema_Click);
            // 
            // btnhakkımızda
            // 
            this.btnhakkımızda.Location = new System.Drawing.Point(28, 66);
            this.btnhakkımızda.Name = "btnhakkımızda";
            this.btnhakkımızda.Size = new System.Drawing.Size(200, 33);
            this.btnhakkımızda.TabIndex = 12;
            this.btnhakkımızda.Text = "Hakkımızda";
            this.btnhakkımızda.UseVisualStyleBackColor = true;
            this.btnhakkımızda.Click += new System.EventHandler(this.btnhakkımızda_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(77, 134);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(188, 33);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtlink
            // 
            this.txtlink.Location = new System.Drawing.Point(77, 101);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(188, 27);
            this.txtlink.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Link:";
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(77, 68);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(188, 27);
            this.txtkategori.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // txtfilmad
            // 
            this.txtfilmad.Location = new System.Drawing.Point(77, 35);
            this.txtfilmad.Name = "txtfilmad";
            this.txtfilmad.Size = new System.Drawing.Size(188, 27);
            this.txtfilmad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Film Ad:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1051, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btntema;
        private System.Windows.Forms.Button btnhakkımızda;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfilmad;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

