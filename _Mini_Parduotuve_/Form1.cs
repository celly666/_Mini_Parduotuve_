using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Mini_Parduotuve
{
    public partial class Form1 : Form
    {
        Dictionary<TabPage, Prekes> prekes;
        
        List<PrekiuKrepselis> krepselis;

        public Form1()
        {
            InitializeComponent();
            
            prekes = new Dictionary<TabPage, Prekes>();
            krepselis = new List<PrekiuKrepselis>();
            LoadPrekes();
        }

        public void LoadPrekes()
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader("Siuntos.txt"))
            {
                string line = null;

                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(';');
                    Prekes prek = new Prekes(data[0], data[1], double.Parse(data[2]), double.Parse(data[3]));
                    string fileName = prek.Pavadinimas + ".JPG";
                    string path = Path.Combine(Environment.CurrentDirectory, @"foto\", fileName);
                    prek.ImagePath = path;
                    FileInfo inf = new FileInfo(path);

                    TabPage page = new TabPage();
                    page.Text = (prek.Pavadinimas).ToString();
                    if (inf.Exists)
                    {
                        using (Bitmap img = new Bitmap(path))
                        {
                            page.BackgroundImage = (Image)img.Clone();
                            page.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                        
                        PrekiuInfo.TabPages.Add(page);
                        prekes.Add(page, prek);
                    
                }


            }
        }

        private void MerchInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrekiuInfo.TabPages.Count != 0)
            {
                Pavadinimas.Text = prekes[PrekiuInfo.SelectedTab].Pavadinimas;
                Svoris.Text = prekes[PrekiuInfo.SelectedTab].Svoris.ToString();
                Kaina.Text = prekes[PrekiuInfo.SelectedTab].Kaina.ToString() ;

            }
        }

        private void IdetiIKrepsBTN_Click(object sender, EventArgs e)
        {
            var preke = prekes[PrekiuInfo.SelectedTab];
            bool exist = false;
            foreach (var item in krepselis)
            {
                if (item.Pavadinimas == preke.Pavadinimas)
                    exist = true;
            }
            if (!exist)
                krepselis.Add(new PrekiuKrepselis(preke));
            else
            {
                var result = MessageBox.Show("Preke jau krepselyje");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 BasketForm = new Form2(krepselis);
            BasketForm.ShowDialog();
        }
    }
}

