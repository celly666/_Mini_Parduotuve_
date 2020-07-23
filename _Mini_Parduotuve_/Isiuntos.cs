using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mini_Parduotuve
{
    public interface Isiuntos
    {
        string Id { get; }
        string Pavadinimas { get; }
        double Kaina { get; }
        double Svoris { get; }

    }
}
