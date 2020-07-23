using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mini_Parduotuve
{
    class Prekes: Isiuntos
    {
        public string Id { get; }
        public string Pavadinimas { get; }
        public double Kaina { get; }
        public double Svoris { get; }
        public string ImagePath { get; set; }

        public Prekes()
        {
        }
        public Prekes(string id, string pavadinimas, double kaina, double svoris)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Svoris = svoris;
        }
    }
}
