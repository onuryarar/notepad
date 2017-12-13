using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication15
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.WhiteSmoke; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.WhiteSmoke; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return  Color.WhiteSmoke; }
            }
            public override Color MenuItemBorder
            {
                get
                {
                    return Color.FromArgb(50,50,50);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panelBul.Visible = false;
            
        }

//BUTTON'S CLICK
        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open.FileName == "" && saveAs.FileName == "" && richTextBox1.Text != "")
                yeniSoru();
            else if (open.FileName != "")
            {
                if (textKayit != richTextBox1.Text)
                    yeniSoru();
                else
                    yeniAc();
            }
            else if (saveAs.FileName != "")
            {
                if (textKayit != richTextBox1.Text)
                    yeniSoru();
                else
                    yeniAc();
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acilsusamacil();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farklikaydet();
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBul.Visible = true;
            txtAranan.Select();
        }

        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                bulToolStripMenuItem.Enabled = true;
                değiştirToolStripMenuItem.Enabled = true;
            }
            else
            {
                bulToolStripMenuItem.Enabled = false;
                değiştirToolStripMenuItem.Enabled = false;
            }
        }

        private void tümMetinDosyalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtList tl = new TxtList();
            if (tl.ShowDialog() == DialogResult.OK)
            {
                dosyayiAc(tl.dosyaAdi);
            }
        }

        private void btX_Click(object sender, EventArgs e)
        {
            panelBul.Visible = false;
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            bul(txtAranan.Text,rbBastan.Checked,rbSondan.Checked,rbTamSozcuk.Checked,rbBuyukKucuk.Checked,cbAramaSurdur.Checked);        //tüm checkboxların checked durumunu kontrol ediyore
        }
        private void btnTumu_Click(object sender, EventArgs e)
        {
            if (btnTumu.Text == "Tümünü Bul")
            {
                btnTumu.Text = "İptal";
                btnTumu.ForeColor = Color.Red;
                tumunuBul(txtAranan.Text, rbBastan.Checked, rbSondan.Checked, rbTamSozcuk.Checked, rbBuyukKucuk.Checked, true,false);
            }
            else
            {
                btnTumu.Text = "Tümünü Bul";
                btnTumu.ForeColor = Color.White;
                tumunuBul(txtAranan.Text, rbBastan.Checked, rbSondan.Checked, rbTamSozcuk.Checked, rbBuyukKucuk.Checked, false,false);
            }

        }
        private void btnSay_Click(object sender, EventArgs e)
        {
            if (btnTumu.Text == "Tümünü Bul")
            {
                tumunuBul(txtAranan.Text, rbBastan.Checked, rbSondan.Checked, rbTamSozcuk.Checked, rbBuyukKucuk.Checked, false, true);
                MessageBox.Show("Toplam "+sayac.ToString()+" adet bulundu.");
            }
            else
            {
                tumunuBul(txtAranan.Text, rbBastan.Checked, rbSondan.Checked, rbTamSozcuk.Checked, rbBuyukKucuk.Checked, true, true);
                MessageBox.Show("Toplam " + sayac.ToString() + " adet bulundu.");
            }
        }


        


//METODS
        void yeniSoru()
        {
            string[] baslik = this.Text.Split('-');
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(baslik[0] + "için olan değişiklikleri kaydetmek istiyor musunuz?", baslik[1], MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                if (open.FileName != "" || saveAs.FileName != "")
                {
                    kaydet();
                    yeniAc();
                }
                else
                { 
                    farklikaydet();
                    yeniAc();
                }
            }
            else if (dr == DialogResult.No)
            {
                yeniAc();
            }
        }

        void yeniAc()
        {
            richTextBox1.Text = "";
            this.Text = "Adsız - Netzwerk's Book";
            open.FileName = "";
            saveAs.FileName = "";
        }

        OpenFileDialog open = new OpenFileDialog();
        string textKayit = "";
        void acilsusamacil()
        {
            open.Filter = "Metin Dosyaları (*.txt) |*.txt|Tüm Dosyalar|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader okur = new StreamReader(open.FileName, Encoding.Default);
                if (okur.EndOfStream)           //açılan dosyanın içi boş...
                    richTextBox1.Text = "";
                else                            //açılan dosyanın içi dolu
                    while (!okur.EndOfStream)
                    {
                        string text = okur.ReadToEnd();
                        richTextBox1.Text = text;
                    }
                textKayit = richTextBox1.Text;
                okur.Close();
                FileInfo dosyaBilgi = new FileInfo(open.FileName);
                this.Text = dosyaBilgi.Name + " - Netzwerk's Book";
            }
        }

        void kaydet()
        {
            if (open.FileName == "" && saveAs.FileName == "")
            {
                farklikaydet();
            }
            else if (open.FileName != "")
            {
                StreamWriter yazar = new StreamWriter(open.FileName);
                yazar.Write(richTextBox1.Text);
                yazar.Close();
            }
            else if (saveAs.FileName != "")
            {
                StreamWriter yazar = new StreamWriter(saveAs.FileName);
                yazar.Write(richTextBox1.Text);
                yazar.Close();
            }
        }


        SaveFileDialog saveAs = new SaveFileDialog();
        void farklikaydet()
        {
            saveAs.FileName = "*.txt";
            saveAs.Filter = "Metin Belgesi (*.txt)|*.txt|Zengin Metin Belgesi (*.rtf)|*.rtf|Tüm Dosyalar (*.*)|*.*";
            if (saveAs.ShowDialog() == DialogResult.OK)
            {
                StreamWriter yazar = new StreamWriter(saveAs.FileName);
                yazar.Write(richTextBox1.Text);
                yazar.Close();
                FileInfo dosyaBilgi = new FileInfo(saveAs.FileName);
                this.Text = dosyaBilgi.Name + " - Netzwerk's Book";
                textKayit = richTextBox1.Text;
            }
            else
                saveAs.FileName = "";
        }

        int index = 0;
        int end;
        void bul(string kelime, bool none, bool reverse, bool wholeWords, bool matchCase, bool surdur)
        {
            richTextBox1.Select();
            int endOf = richTextBox1.Text.LastIndexOf(txtAranan.Text);

            if (!reverse)
                end = richTextBox1.Text.Length;
            
            
            if (surdur)
            {
                if (endOf < index)      //aramanın sonuna gelince tekrar başa dönmesini sağlar
                    index = 0;
                else if (end == 1)      //aramanın başına gelince tekrar sona dönmesini sağlar
                    end = richTextBox1.TextLength;
            }

            if (none)
            {
                richTextBox1.Find(kelime, index, end, RichTextBoxFinds.None);
                index = richTextBox1.SelectionStart + 1;
            }
            else if (reverse)
            {
                richTextBox1.Find(kelime, index, end, RichTextBoxFinds.Reverse);
                end = richTextBox1.SelectionStart + 1;
            }
            else if (wholeWords)
            {
                richTextBox1.Find(kelime, index, end, RichTextBoxFinds.WholeWord);
                index = richTextBox1.SelectionStart + 1;
            }
            else if (matchCase)
            {
                richTextBox1.Find(kelime, index, end, RichTextBoxFinds.MatchCase);
                index = richTextBox1.SelectionStart + 1;
            }
        }

        int sayac;
        void tumunuBul(string kelime, bool none, bool reverse, bool wholeWords, bool matchCase, bool bul,bool say)
        {
            
            sayac = 0;
            index = 0;
            end = richTextBox1.Text.Length;
            int lastIndex = richTextBox1.Text.LastIndexOf(txtAranan.Text);

            while (index < lastIndex)
            {
                if (none || reverse)
                {
                    richTextBox1.Find(kelime, index, end, RichTextBoxFinds.None);
                    sayac++;
                }
                else if (wholeWords)
                {
                    richTextBox1.Find(kelime, index, end, RichTextBoxFinds.WholeWord);
                    sayac++;
                }
                else if (matchCase)
                {
                    richTextBox1.Find(kelime, index, end, RichTextBoxFinds.MatchCase);
                    sayac++;
                }

                if (bul)
                {
                    richTextBox1.SelectionBackColor = Color.FloralWhite;
                    richTextBox1.SelectionColor = Color.FromArgb(50, 50, 50);
                }
                else
                {
                    richTextBox1.SelectionBackColor = Color.FromArgb(50, 50, 50);
                    richTextBox1.SelectionColor = Color.White;
                }
                index = richTextBox1.SelectionStart+1;
            }
        }

        void dosyayiAc(string DosyaAdi)
        {
            StreamReader okur = new StreamReader(DosyaAdi, Encoding.Default);
            if (okur.EndOfStream)           //açılan dosyanın içi boş...
                richTextBox1.Text = "";
            else                            //açılan dosyanın içi dolu
                while (!okur.EndOfStream)
                {
                    string text = okur.ReadToEnd();
                    richTextBox1.Text = text;
                }
            textKayit = richTextBox1.Text;
            okur.Close();
            FileInfo dosyaBilgi = new FileInfo(DosyaAdi);
            this.Text = dosyaBilgi.Name + " - Netzwerk's Book";
        }
        
        
        

//KEYDOWN CONTROLS
        //bulForm bul = new bulForm();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                yeniAc();
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                acilsusamacil();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                kaydet();
            }
            else if (e.Control && e.KeyCode == Keys.F)       
            {
                if (richTextBox1.TextLength > 0)
                {
                    panelBul.Visible = true;
                    tabControl1.SelectedIndex = 0;
                    txtAranan.Select();
                    //bul.Show();
                }
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                if (richTextBox1.TextLength > 0)
                {
                    panelBul.Visible = true;
                    tabControl1.SelectedIndex = 1;
                    txtAranan.Select();
                }
            }
            else if (e.KeyCode == Keys.Escape)
                panelBul.Visible = false;
        }

//RADIOBUTTON'S CHANGED
        private void rbBastan_CheckedChanged(object sender, EventArgs e)
        {
            index = 0;
            end = richTextBox1.Text.Length;
        }  

        private void rbSondan_CheckedChanged(object sender, EventArgs e)
        {
            index = 0;
            end = richTextBox1.Text.Length;
        }


        


        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
    }
}
