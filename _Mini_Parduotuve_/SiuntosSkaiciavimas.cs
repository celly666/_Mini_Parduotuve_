using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Mini_Parduotuve
{
    public class SiuntosSkaiciavimas
    {
        public string SiuntDydis { get; set; }
        public void SiuntosDydis(List<PrekiuKrepselis> krepselis)
        {
            double bendrasSvoris = 0;

            if (krepselis.Count != 0)
            {
                foreach (var item in krepselis)
                {

                    bendrasSvoris += item.Svoris * item.Kiekis;
                }
                if (bendrasSvoris <=12)
                {
                    SiuntDydis = "S";

                }

                 if (bendrasSvoris <=60 && bendrasSvoris >=35)
                {
                    SiuntDydis = "L";

                }

                else if(bendrasSvoris >13 && bendrasSvoris <35)
                {
                    SiuntDydis = "M";

                }
            }

        }
        public double ApskaiciuotiKaina(List<PrekiuKrepselis> krepselis)
        {
            SiuntosDydis(krepselis);
            double kaina = 0;

            foreach (var item in krepselis)
            {
                kaina += item.Kaina * item.Kiekis;
            }
            switch (SiuntDydis)
            {
                case "S":

                    return kaina + 5;

                case "M":

                    return kaina + 10;
                case "L":

                    return kaina + 15;

            }

                    return 0;

            }
        }
    } 

    

    


    


       
        

   


