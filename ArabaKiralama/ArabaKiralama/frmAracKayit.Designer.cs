namespace ArabaKiralama
{
    partial class frmAracKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracKayit));
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.modeltxt = new System.Windows.Forms.TextBox();
            this.renktxt = new System.Windows.Forms.TextBox();
            this.kmtxt = new System.Windows.Forms.TextBox();
            this.yakitcombo = new System.Windows.Forms.ComboBox();
            this.ücrettxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resimBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.resimBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(126, 79);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(150, 20);
            this.plakatxt.TabIndex = 0;
            // 
            // markacombo
            // 
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Location = new System.Drawing.Point(126, 105);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(151, 21);
            this.markacombo.TabIndex = 1;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // modeltxt
            // 
            this.modeltxt.Location = new System.Drawing.Point(127, 132);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(150, 20);
            this.modeltxt.TabIndex = 0;
            // 
            // renktxt
            // 
            this.renktxt.Location = new System.Drawing.Point(127, 158);
            this.renktxt.Name = "renktxt";
            this.renktxt.Size = new System.Drawing.Size(150, 20);
            this.renktxt.TabIndex = 0;
            // 
            // kmtxt
            // 
            this.kmtxt.Location = new System.Drawing.Point(127, 184);
            this.kmtxt.Name = "kmtxt";
            this.kmtxt.Size = new System.Drawing.Size(150, 20);
            this.kmtxt.TabIndex = 0;
            // 
            // yakitcombo
            // 
            this.yakitcombo.FormattingEnabled = true;
            this.yakitcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "LPG"});
            this.yakitcombo.Location = new System.Drawing.Point(127, 210);
            this.yakitcombo.Name = "yakitcombo";
            this.yakitcombo.Size = new System.Drawing.Size(151, 21);
            this.yakitcombo.TabIndex = 1;
            // 
            // ücrettxt
            // 
            this.ücrettxt.Location = new System.Drawing.Point(127, 237);
            this.ücrettxt.Name = "ücrettxt";
            this.ücrettxt.Size = new System.Drawing.Size(150, 20);
            this.ücrettxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Renk :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Km :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Yakıt :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(35, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kira Ücreti :";
            // 
            // resimBox1
            // 
            this.resimBox1.Location = new System.Drawing.Point(298, 63);
            this.resimBox1.Name = "resimBox1";
            this.resimBox1.Size = new System.Drawing.Size(130, 115);
            this.resimBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimBox1.TabIndex = 4;
            this.resimBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "tik2.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(91, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptal.png");
            this.ımageList1.Images.SetKeyName(1, "pital.png");
            this.ımageList1.Images.SetKeyName(2, "tik.jpg");
            this.ımageList1.Images.SetKeyName(3, "+.png");
            this.ımageList1.Images.SetKeyName(4, "tik2.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "pital.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(227, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResim
            // 
            this.btnResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResim.ImageKey = "+.png";
            this.btnResim.ImageList = this.ımageList1;
            this.btnResim.Location = new System.Drawing.Point(310, 212);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(114, 37);
            this.btnResim.TabIndex = 5;
            this.btnResim.Text = "Resim Ekle";
            this.btnResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 417);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resimBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yakitcombo);
            this.Controls.Add(this.markacombo);
            this.Controls.Add(this.ücrettxt);
            this.Controls.Add(this.kmtxt);
            this.Controls.Add(this.renktxt);
            this.Controls.Add(this.modeltxt);
            this.Controls.Add(this.plakatxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAracKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAracKayit_FormClosing);
            this.Load += new System.EventHandler(this.frmAracKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resimBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.TextBox modeltxt;
        private System.Windows.Forms.TextBox renktxt;
        private System.Windows.Forms.TextBox kmtxt;
        private System.Windows.Forms.ComboBox yakitcombo;
        private System.Windows.Forms.TextBox ücrettxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox resimBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}