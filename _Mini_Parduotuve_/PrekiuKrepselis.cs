using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mini_Parduotuve
{
    public class PrekiuKrepselis:Isiuntos
    {
        public string Id { get; set; }

        public string Pavadinimas { get; set; }

        public double Kaina { get; set; }

        public double Svoris { get; set; }

        public int Kiekis { get; set; }

        public PrekiuKrepselis()
        {

        }
        

        public PrekiuKrepselis(Isiuntos siunt)
        {
            Id = siunt.Id;
            Pavadinimas = siunt.Pavadinimas;
            Kaina = siunt.Kaina;
            Svoris = siunt.Svoris;
            Kiekis = 1;
        }
        public void ChangeAmount(int kiekis)
        {
            Kiekis = kiekis;
        }
    }
}
