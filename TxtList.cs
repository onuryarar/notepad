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
    public partial class TxtList : Form
    {
        public TxtList()
        {
            InitializeComponent();
        }

        public string dosyaAdi;
        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            foreach (FileInfo item in dosyalar)
            {
                if (item.Name == treeView1.SelectedNode.Text)
                    dosyaAdi = item.FullName;
            }
        }

        FileInfo[] dosyalar;
        private void btnListele_Click(object sender, EventArgs e)
        {
            string dosyaUzanti = "";
            if (comboBox1.SelectedIndex == 0)
                dosyaUzanti = "*.txt";
            else if (comboBox1.SelectedIndex == 1)
                dosyaUzanti = "*.rtf";
            else if (comboBox1.SelectedIndex == 2)
                dosyaUzanti = "*.doc";
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\"+Environment.UserName+@"\Desktop\");
            dosyalar = di.GetFiles(dosyaUzanti, SearchOption.AllDirectories);
            TreeNode[] tn = new TreeNode[150];
            MessageBox.Show(dosyalar.Length.ToString());
            tn[0] = treeView1.Nodes.Add("C:");
            foreach (FileInfo item in dosyalar)
            {
                string[] dosya = item.FullName.Split('\\');
                tn[0] = treeView1.Nodes[0];
                for (int i = 1; i < dosya.Length; i++)
                {
                    if (tn[i] != null)
                    {
                        if (tn[i].Text != dosya[i])
                            tn[i] = tn[i - 1].Nodes.Add(dosya[i]);
                    }
                    else if (tn[i] == null)
                        tn[i] = tn[i - 1].Nodes.Add(dosya[i]);
                    
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] uzanti = treeView1.SelectedNode.Text.Split('.');
            if (uzanti[uzanti.Length - 1] == "txt" && comboBox1.SelectedIndex == 0)
                btnDosyaAc.Enabled = true;
            else if (uzanti[uzanti.Length - 1] == "rtf" && comboBox1.SelectedIndex == 1)
                btnDosyaAc.Enabled = true;
            else if (uzanti[uzanti.Length - 1] == "doc" && comboBox1.SelectedIndex == 2)
                btnDosyaAc.Enabled = true;
            else
                btnDosyaAc.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                treeView1.Nodes.Clear();
                btnListele.Enabled = true;
            }
            else
                btnListele.Enabled = false;
        }

        
    }
}
