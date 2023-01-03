namespace ArabaKiralama
{
    partial class frmAraclistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraclistele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btniptal = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yakitcombo = new System.Windows.Forms.ComboBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.ucrettxt = new System.Windows.Forms.TextBox();
            this.kmtxt = new System.Windows.Forms.TextBox();
            this.renktxt = new System.Windows.Forms.TextBox();
            this.modeltxt = new System.Windows.Forms.TextBox();
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraclar
            // 
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Aracçlar"});
            this.comboAraclar.Location = new System.Drawing.Point(830, 63);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(157, 21);
            this.comboAraclar.TabIndex = 1;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboAraclar_SelectedIndexChanged);
            // 
            // btnResim
            // 
            this.btnResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.ImageList = this.ımageList1;
            this.btnResim.Location = new System.Drawing.Point(52, 166);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(163, 28);
            this.btnResim.TabIndex = 25;
            this.btnResim.Text = "Resim Değiştir";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptal.png");
            this.ımageList1.Images.SetKeyName(1, "güncelle.png");
            this.ımageList1.Images.SetKeyName(2, "pital.png");
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.Snow;
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniptal.ImageKey = "iptal.png";
            this.btniptal.ImageList = this.ımageList1;
            this.btniptal.Location = new System.Drawing.Point(155, 460);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(76, 37);
            this.btniptal.TabIndex = 24;
            this.btniptal.Text = "İptal";
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageKey = "güncelle.png";
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(17, 460);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(103, 37);
            this.btnguncelle.TabIndex = 23;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kira Ücreti :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Yakıt :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Km :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Renk :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Marka :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Plaka :";
            // 
            // yakitcombo
            // 
            this.yakitcombo.FormattingEnabled = true;
            this.yakitcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "LPG"});
            this.yakitcombo.Location = new System.Drawing.Point(107, 347);
            this.yakitcombo.Name = "yakitcombo";
            this.yakitcombo.Size = new System.Drawing.Size(151, 21);
            this.yakitcombo.TabIndex = 13;
            // 
            // markacombo
            // 
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Items.AddRange(new object[] {
            "Fiat",
            "Ford",
            "Renault",
            "Mercedes",
            "Hundai"});
            this.markacombo.Location = new System.Drawing.Point(106, 236);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(151, 21);
            this.markacombo.TabIndex = 11;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.markacombo_SelectedIndexChanged);
            // 
            // ucrettxt
            // 
            this.ucrettxt.Location = new System.Drawing.Point(107, 374);
            this.ucrettxt.Name = "ucrettxt";
            this.ucrettxt.Size = new System.Drawing.Size(150, 20);
            this.ucrettxt.TabIndex = 9;
            // 
            // kmtxt
            // 
            this.kmtxt.Location = new System.Drawing.Point(107, 321);
            this.kmtxt.Name = "kmtxt";
            this.kmtxt.Size = new System.Drawing.Size(150, 20);
            this.kmtxt.TabIndex = 8;
            // 
            // renktxt
            // 
            this.renktxt.Location = new System.Drawing.Point(107, 295);
            this.renktxt.Name = "renktxt";
            this.renktxt.Size = new System.Drawing.Size(150, 20);
            this.renktxt.TabIndex = 7;
            // 
            // modeltxt
            // 
            this.modeltxt.Location = new System.Drawing.Point(107, 269);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(150, 20);
            this.modeltxt.TabIndex = 10;
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(106, 210);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(150, 20);
            this.plakatxt.TabIndex = 6;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageKey = "pital.png";
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(875, 516);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(62, 37);
            this.btnsil.TabIndex = 24;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraclistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 566);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yakitcombo);
            this.Controls.Add(this.markacombo);
            this.Controls.Add(this.ucrettxt);
            this.Controls.Add(this.kmtxt);
            this.Controls.Add(this.renktxt);
            this.Controls.Add(this.modeltxt);
            this.Controls.Add(this.plakatxt);
            this.Controls.Add(this.comboAraclar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAraclistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Listeleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAraclistele_FormClosing);
            this.Load += new System.EventHandler(this.frmAraclistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboAraclar;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yakitcombo;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.TextBox ucrettxt;
        private System.Windows.Forms.TextBox kmtxt;
        private System.Windows.Forms.TextBox renktxt;
        private System.Windows.Forms.TextBox modeltxt;
        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}