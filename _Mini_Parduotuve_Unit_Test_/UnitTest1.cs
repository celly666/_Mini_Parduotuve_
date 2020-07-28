using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _Mini_Parduotuve;
using System.Collections.Generic;

namespace _Mini_Parduotuve_Unit_Test_
{
    [TestClass]
    public class SiuntosSkaiciavimas_UnitTest
    {
        [TestMethod]
        public void SiuntosDydis_DuodamMSiunta_TikimesGautiM()
        {

            List<PrekiuKrepselis> krepselis = new List<PrekiuKrepselis>();
            krepselis.Add(new PrekiuKrepselis
            {
                Svoris = 10
            });
            krepselis.Add(new PrekiuKrepselis
            {
                Svoris = 5
            });

            SiuntosSkaiciavimas klasifikavimas = new SiuntosSkaiciavimas();
            klasifikavimas.SiuntosDydis(krepselis);

            Assert.AreEqual("S", klasifikavimas.SiuntDydis);
        }
        [TestMethod]
        public void SiuntosDydis_DuodamSSiunta_TikimesGautiS()
        {

            List<PrekiuKrepselis> krepselis = new List<PrekiuKrepselis>();
            krepselis.Add(new PrekiuKrepselis
            {
                Svoris = 10
            });


            SiuntosSkaiciavimas klasifikavimas = new SiuntosSkaiciavimas();
            klasifikavimas.SiuntosDydis(krepselis);

            Assert.AreEqual("S", klasifikavimas.SiuntDydis);
        }
        [TestMethod]
        public void SiuntosDydis_DuodamLSiunta_TikimesGautiL()
        {
            List<PrekiuKrepselis> krepselis = new List<PrekiuKrepselis>();
            krepselis.Add(new PrekiuKrepselis
            {

                Svoris = 5
            });
            krepselis.Add(new PrekiuKrepselis
            {

                Svoris = 0.4
            });
            krepselis.Add(new PrekiuKrepselis
            {

                Svoris = 15
            });
            krepselis.Add(new PrekiuKrepselis
            {

                Svoris = 10
            });
            krepselis.Add(new PrekiuKrepselis
            {

                Svoris = 20
            });
            krepselis.Add(new PrekiuKrepselis
            {

                Svoris = 5
            });

            SiuntosSkaiciavimas klasifikavimas = new SiuntosSkaiciavimas();
            klasifikavimas.SiuntosDydis(krepselis);

            Assert.AreEqual("L", klasifikavimas.SiuntDydis);

        }
            [TestMethod]
        public void ApskaiciuotiKaina_DuodamSSiunta_TikimesGauti5()
        {
            List<PrekiuKrepselis> krepselis = new List<PrekiuKrepselis>();
            krepselis.Add(new PrekiuKrepselis
            {
                
                Svoris = 5
            });
            krepselis.Add(new PrekiuKrepselis
            {
                
                Svoris = 0.4
            });

            SiuntosSkaiciavimas klasifikavimas = new SiuntosSkaiciavimas();
            klasifikavimas.ApskaiciuotiKaina(krepselis);

            Assert.AreEqual(5, klasifikavimas.ApskaiciuotiKaina(krepselis));
        }
    
        [TestMethod]
        public void ApskaiciuotiKaina_DuodamMSiunta_TikimesGauti10()
        {
            List<PrekiuKrepselis> krepselis = new List<PrekiuKrepselis>();
            krepselis.Add(new PrekiuKrepselis
            {
               
                Svoris = 10
            });
            krepselis.Add(new PrekiuKrepselis
            {
                
                Svoris = 5
            });

            SiuntosSkaiciavimas klasifikavimas = new SiuntosSkaiciavimas();
            klasifikavimas.ApskaiciuotiKaina(krepselis);

            Assert.AreEqual(10, klasifikavimas.ApskaiciuotiKaina(krepselis));
        }
     
        [TestMethod]
        public void ApskaiciuotiKaina_DuodamLSiunta_TikimesGauti15()
        {
            List<PrekiuKrepselis> krepselis = new List<PrekiuKrepselis>();
            krepselis.Add(new PrekiuKrepselis
            {
                
                Svoris = 5
            });
            krepselis.Add(new PrekiuKrepselis
            {
                
                Svoris = 15
            });
            krepselis.Add(new PrekiuKrepselis
            {
                
                Svoris = 10
            });
            krepselis.Add(new PrekiuKrepselis
            {
                
                Svoris = 20
            });
            krepselis.Add(new PrekiuKrepselis
            {
                
                Svoris = 5
            });

            SiuntosSkaiciavimas klasifikavimas = new SiuntosSkaiciavimas();
            klasifikavimas.ApskaiciuotiKaina(krepselis);

            Assert.AreEqual(15, klasifikavimas.ApskaiciuotiKaina(krepselis));

        }
    }
}

