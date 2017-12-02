namespace Sinema
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.rbRandevuAl = new System.Windows.Forms.RadioButton();
            this.rbRandevuIptal = new System.Windows.Forms.RadioButton();
            this.rbKoltukNoOgren = new System.Windows.Forms.RadioButton();
            this.cmbKoltukNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIslem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKoltukDurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İşlem Türü";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(109, 130);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(109, 165);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // rbRandevuAl
            // 
            this.rbRandevuAl.AutoSize = true;
            this.rbRandevuAl.Checked = true;
            this.rbRandevuAl.Location = new System.Drawing.Point(107, 95);
            this.rbRandevuAl.Name = "rbRandevuAl";
            this.rbRandevuAl.Size = new System.Drawing.Size(81, 17);
            this.rbRandevuAl.TabIndex = 5;
            this.rbRandevuAl.TabStop = true;
            this.rbRandevuAl.Text = "Randevu Al";
            this.rbRandevuAl.UseVisualStyleBackColor = true;
            this.rbRandevuAl.CheckedChanged += new System.EventHandler(this.rbRandevuAl_CheckedChanged);
            // 
            // rbRandevuIptal
            // 
            this.rbRandevuIptal.AutoSize = true;
            this.rbRandevuIptal.Location = new System.Drawing.Point(232, 95);
            this.rbRandevuIptal.Name = "rbRandevuIptal";
            this.rbRandevuIptal.Size = new System.Drawing.Size(105, 17);
            this.rbRandevuIptal.TabIndex = 6;
            this.rbRandevuIptal.Text = "Randevu İptal Et";
            this.rbRandevuIptal.UseVisualStyleBackColor = true;
            this.rbRandevuIptal.CheckedChanged += new System.EventHandler(this.rbRandevuIptal_CheckedChanged);
            // 
            // rbKoltukNoOgren
            // 
            this.rbKoltukNoOgren.AutoSize = true;
            this.rbKoltukNoOgren.Location = new System.Drawing.Point(365, 95);
            this.rbKoltukNoOgren.Name = "rbKoltukNoOgren";
            this.rbKoltukNoOgren.Size = new System.Drawing.Size(127, 17);
            this.rbKoltukNoOgren.TabIndex = 7;
            this.rbKoltukNoOgren.Text = "Koltuk Numara Öğren";
            this.rbKoltukNoOgren.UseVisualStyleBackColor = true;
            this.rbKoltukNoOgren.CheckedChanged += new System.EventHandler(this.rbKoltukNoOgren_CheckedChanged);
            // 
            // cmbKoltukNo
            // 
            this.cmbKoltukNo.FormattingEnabled = true;
            this.cmbKoltukNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cmbKoltukNo.Location = new System.Drawing.Point(107, 216);
            this.cmbKoltukNo.Name = "cmbKoltukNo";
            this.cmbKoltukNo.Size = new System.Drawing.Size(121, 21);
            this.cmbKoltukNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Koltuk \r\nNumaraları";
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(107, 257);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(75, 23);
            this.btnIslem.TabIndex = 10;
            this.btnIslem.Text = "İşlem Yap";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(29, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "İşlem yapmak için önce işlem türünü seçmelisiniz";
            // 
            // btnKoltukDurum
            // 
            this.btnKoltukDurum.Location = new System.Drawing.Point(232, 256);
            this.btnKoltukDurum.Name = "btnKoltukDurum";
            this.btnKoltukDurum.Size = new System.Drawing.Size(114, 23);
            this.btnKoltukDurum.TabIndex = 11;
            this.btnKoltukDurum.Text = "Koltuk Durum Göster";
            this.btnKoltukDurum.UseVisualStyleBackColor = true;
            this.btnKoltukDurum.Click += new System.EventHandler(this.btnKoltukDurum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 377);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKoltukDurum);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKoltukNo);
            this.Controls.Add(this.rbKoltukNoOgren);
            this.Controls.Add(this.rbRandevuIptal);
            this.Controls.Add(this.rbRandevuAl);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.RadioButton rbRandevuAl;
        private System.Windows.Forms.RadioButton rbRandevuIptal;
        private System.Windows.Forms.RadioButton rbKoltukNoOgren;
        private System.Windows.Forms.ComboBox cmbKoltukNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKoltukDurum;
    }
}

