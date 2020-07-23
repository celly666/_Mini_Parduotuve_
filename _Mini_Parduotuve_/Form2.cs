using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Mini_Parduotuve
{
    public partial class Form2 : Form
    {
        public List<PrekiuKrepselis> krepselis;
        SiuntosSkaiciavimas siunt;
        public Form2(List<PrekiuKrepselis> k)
        {
            siunt = new SiuntosSkaiciavimas();
            InitializeComponent();
            krepselis = k;
            LoadKrepselis();
            SiuntimoIslaidos();

        }

        private void LoadKrepselis ()
        {
            dataGridView1.DataSource = krepselis;
            dataGridView1.Columns["Id"].Visible = false;


            Total.Text = (Math.Round(siunt.ApskaiciuotiKaina(krepselis)*100)/100).ToString();
        }
        public double ApskaiciuotiTotalSuma()
        {
            double kaina = 0;
            foreach (var item in krepselis)
            {

                kaina += item.Kaina * item.Kiekis;
            }   
            
                return kaina;
        }
        

        public void SiuntimoIslaidos()
        {
            SiuntimoBudas.Items.Add("Pristatymas į namus per paštą : 1.99");
            SiuntimoBudas.Items.Add("Pristatymas į namus per kurjerių tarnybą: 3.49");
            SiuntimoBudas.Items.Add("Atsiėmimas paštomate : 2.99");
            SiuntimoBudas.Items.Add("Tarptautinis siuntimas : 15.99");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double siuntimo = 0.0;

            if (SiuntimoBudas.SelectedItem == "Pristatymas į namus per paštą : 1.99")
            {
                siuntimo += 1.99;
                SiuntimoIs.Text = siuntimo.ToString();
            }
            else if (SiuntimoBudas.SelectedItem == "Pristatymas į namus per kurjerių tarnybą: 3.49")
            {
                siuntimo = 0;
                siuntimo += 3.49;
                SiuntimoIs.Text = siuntimo.ToString();
            }
            else if (SiuntimoBudas.SelectedItem == "Atsiėmimas paštomate : 2.99")
            {
                siuntimo = 0;
                siuntimo += 2.99;
                SiuntimoIs.Text = siuntimo.ToString();
            }
            else if (SiuntimoBudas.SelectedItem == "Tarptautinis siuntimas : 15.99")
            {
                siuntimo = 0;
                siuntimo += 15.99;
                SiuntimoIs.Text = siuntimo.ToString();
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            if (Total.Text!=" "&& SiuntimoIs.Text!=" ")
            {
                double total = Convert.ToDouble(Total.Text);
                double siuntosIs = Convert.ToDouble(SiuntimoIs.Text);
                double uzsakymas = total + siuntosIs;

                MessageBox.Show("Jūsų galutinė pirkinių kaina yra : " + uzsakymas.ToString());
            }
            else if (Total.Text != "0.00" && SiuntimoIs.Text == "")
            {
                MessageBox.Show("Pasirinkite siuntimo būdą");
            }
            else if (Total.Text == "0.00" && SiuntimoIs.Text != "")
            {
                MessageBox.Show("Pasirinkite norimas užsisakyti prekes");
            }
            else
            {
                MessageBox.Show("Tuščias užsakymas");
            }
        }
    }
}
