namespace WindowsFormsApplication15
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tümMetinDosyalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBul = new System.Windows.Forms.Panel();
            this.btX = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbBuyukKucuk = new System.Windows.Forms.RadioButton();
            this.rbTamSozcuk = new System.Windows.Forms.RadioButton();
            this.rbSondan = new System.Windows.Forms.RadioButton();
            this.rbBastan = new System.Windows.Forms.RadioButton();
            this.cbAramaSurdur = new System.Windows.Forms.CheckBox();
            this.btnTumu = new System.Windows.Forms.Button();
            this.btnSay = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblAranan = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.panelBul.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(755, 429);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-321, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "bul";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 8F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.biçimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.toolStripSeparator2,
            this.tümMetinDosyalarıToolStripMenuItem,
            this.toolStripSeparator1,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.yeniToolStripMenuItem.Text = "Yeni                   Ctrl+N";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.açToolStripMenuItem.Text = "Aç...                  Ctrl+O";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet              Ctrl+S";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(248, 6);
            // 
            // tümMetinDosyalarıToolStripMenuItem
            // 
            this.tümMetinDosyalarıToolStripMenuItem.Name = "tümMetinDosyalarıToolStripMenuItem";
            this.tümMetinDosyalarıToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.tümMetinDosyalarıToolStripMenuItem.Text = "Tüm Metin Dosyaları*";
            this.tümMetinDosyalarıToolStripMenuItem.Click += new System.EventHandler(this.tümMetinDosyalarıToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(248, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulToolStripMenuItem,
            this.değiştirToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            this.düzenToolStripMenuItem.Click += new System.EventHandler(this.düzenToolStripMenuItem_Click);
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.bulToolStripMenuItem.Text = "Bul                  Ctrl+F";
            this.bulToolStripMenuItem.Click += new System.EventHandler(this.bulToolStripMenuItem_Click);
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.değiştirToolStripMenuItem.Text = "Değiştir            Ctrl+H";
            // 
            // biçimToolStripMenuItem
            // 
            this.biçimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıTipiToolStripMenuItem});
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.biçimToolStripMenuItem.Text = "Biçim";
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);
            // 
            // panelBul
            // 
            this.panelBul.BackColor = System.Drawing.Color.White;
            this.panelBul.Controls.Add(this.btX);
            this.panelBul.Controls.Add(this.tabControl1);
            this.panelBul.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBul.Location = new System.Drawing.Point(755, 24);
            this.panelBul.Name = "panelBul";
            this.panelBul.Size = new System.Drawing.Size(227, 429);
            this.panelBul.TabIndex = 0;
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.White;
            this.btX.FlatAppearance.BorderSize = 0;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btX.ForeColor = System.Drawing.Color.Maroon;
            this.btX.Location = new System.Drawing.Point(202, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(25, 25);
            this.btX.TabIndex = 50;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(227, 429);
            this.tabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbBuyukKucuk);
            this.tabPage1.Controls.Add(this.rbTamSozcuk);
            this.tabPage1.Controls.Add(this.rbSondan);
            this.tabPage1.Controls.Add(this.rbBastan);
            this.tabPage1.Controls.Add(this.cbAramaSurdur);
            this.tabPage1.Controls.Add(this.btnTumu);
            this.tabPage1.Controls.Add(this.btnSay);
            this.tabPage1.Controls.Add(this.btnSonraki);
            this.tabPage1.Controls.Add(this.txtAranan);
            this.tabPage1.Controls.Add(this.lblAranan);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(219, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bul";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbBuyukKucuk
            // 
            this.rbBuyukKucuk.AutoSize = true;
            this.rbBuyukKucuk.Location = new System.Drawing.Point(5, 255);
            this.rbBuyukKucuk.Name = "rbBuyukKucuk";
            this.rbBuyukKucuk.Size = new System.Drawing.Size(208, 21);
            this.rbBuyukKucuk.TabIndex = 13;
            this.rbBuyukKucuk.Text = "Büyük/küçük harf eşleştir";
            this.rbBuyukKucuk.UseVisualStyleBackColor = true;
            // 
            // rbTamSozcuk
            // 
            this.rbTamSozcuk.AutoSize = true;
            this.rbTamSozcuk.Location = new System.Drawing.Point(5, 228);
            this.rbTamSozcuk.Name = "rbTamSozcuk";
            this.rbTamSozcuk.Size = new System.Drawing.Size(186, 21);
            this.rbTamSozcuk.TabIndex = 13;
            this.rbTamSozcuk.Text = "Tam sözcükleri eşleştir";
            this.rbTamSozcuk.UseVisualStyleBackColor = true;
            // 
            // rbSondan
            // 
            this.rbSondan.AutoSize = true;
            this.rbSondan.Location = new System.Drawing.Point(6, 201);
            this.rbSondan.Name = "rbSondan";
            this.rbSondan.Size = new System.Drawing.Size(204, 21);
            this.rbSondan.TabIndex = 13;
            this.rbSondan.Text = "Belgenin sonundan başla";
            this.rbSondan.UseVisualStyleBackColor = true;
            this.rbSondan.CheckedChanged += new System.EventHandler(this.rbSondan_CheckedChanged);
            // 
            // rbBastan
            // 
            this.rbBastan.AutoSize = true;
            this.rbBastan.Checked = true;
            this.rbBastan.Location = new System.Drawing.Point(6, 174);
            this.rbBastan.Name = "rbBastan";
            this.rbBastan.Size = new System.Drawing.Size(197, 21);
            this.rbBastan.TabIndex = 13;
            this.rbBastan.TabStop = true;
            this.rbBastan.Text = "Belgenin başından başla";
            this.rbBastan.UseVisualStyleBackColor = true;
            this.rbBastan.CheckedChanged += new System.EventHandler(this.rbBastan_CheckedChanged);
            // 
            // cbAramaSurdur
            // 
            this.cbAramaSurdur.AutoSize = true;
            this.cbAramaSurdur.Checked = true;
            this.cbAramaSurdur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAramaSurdur.Location = new System.Drawing.Point(6, 292);
            this.cbAramaSurdur.Name = "cbAramaSurdur";
            this.cbAramaSurdur.Size = new System.Drawing.Size(138, 21);
            this.cbAramaSurdur.TabIndex = 12;
            this.cbAramaSurdur.Text = "Aramayı sürdür";
            this.cbAramaSurdur.UseVisualStyleBackColor = true;
            // 
            // btnTumu
            // 
            this.btnTumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTumu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumu.ForeColor = System.Drawing.Color.White;
            this.btnTumu.Location = new System.Drawing.Point(5, 90);
            this.btnTumu.Name = "btnTumu";
            this.btnTumu.Size = new System.Drawing.Size(206, 29);
            this.btnTumu.TabIndex = 10;
            this.btnTumu.Text = "Tümünü Bul";
            this.btnTumu.UseVisualStyleBackColor = false;
            this.btnTumu.Click += new System.EventHandler(this.btnTumu_Click);
            // 
            // btnSay
            // 
            this.btnSay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSay.ForeColor = System.Drawing.Color.White;
            this.btnSay.Location = new System.Drawing.Point(5, 125);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(206, 29);
            this.btnSay.TabIndex = 11;
            this.btnSay.Text = "Say";
            this.btnSay.UseVisualStyleBackColor = false;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSonraki.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonraki.ForeColor = System.Drawing.Color.White;
            this.btnSonraki.Location = new System.Drawing.Point(5, 49);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(206, 35);
            this.btnSonraki.TabIndex = 9;
            this.btnSonraki.Text = "Sonrakini Bul";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(65, 20);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(146, 23);
            this.txtAranan.TabIndex = 8;
            // 
            // lblAranan
            // 
            this.lblAranan.AutoSize = true;
            this.lblAranan.Location = new System.Drawing.Point(2, 23);
            this.lblAranan.Name = "lblAranan";
            this.lblAranan.Size = new System.Drawing.Size(64, 17);
            this.lblAranan.TabIndex = 7;
            this.lblAranan.Text = "Aranan:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(219, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Değiştir*";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelBul);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adsız - Netzwerk\'s Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBul.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümMetinDosyalarıToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelBul;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbAramaSurdur;
        private System.Windows.Forms.Button btnTumu;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblAranan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.RadioButton rbBuyukKucuk;
        private System.Windows.Forms.RadioButton rbTamSozcuk;
        private System.Windows.Forms.RadioButton rbSondan;
        private System.Windows.Forms.RadioButton rbBastan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

