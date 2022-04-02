using NUnit.Framework;
using System;

namespace KalkulatorTests
{
    public class Tests
    {
        [Test]
        public void Dodaj_DwieLiczbyDodatnie_Wynik()
        {
            var kalkulator = new Kalkulator.Kalkulator();
            int suma = kalkulator.Dodaj(2, 2);
            Assert.AreEqual(4, suma);
        }

        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 0)]
        [TestCase(-2, -2, -4)]
        public void Dodaj_ZwracaWynikDodawania(int a, int b, int wynik)
        {
            var kalkulator = new Kalkulator.Kalkulator();
            int suma = kalkulator.Dodaj(a, b);
            Assert.AreEqual(wynik, suma);
        }

        [Test]
        public void Odejmij_DwieLiczbyDodatnie_Wynik()
        {
            var kalkulator = new Kalkulator.Kalkulator();
            int suma = kalkulator.Odejmij(5, 2);
            Assert.AreEqual(3, suma);
        }

        [TestCase(5, 2, 3)]
        [TestCase(10, 2, 8)]
        [TestCase(6, -2, 8)]
        public void Odejmij_ZwracaWynikDodawania(int a, int b, int wynik)
        {
            var kalkulator = new Kalkulator.Kalkulator();
            int suma = kalkulator.Odejmij(a, b);
            Assert.AreEqual(wynik, suma);
        }

        [Test]
        public void Mnoz_DwieLiczbyDodatnie_Wynik()
        {
            var kalkulator = new Kalkulator.Kalkulator();
            int suma = kalkulator.Mnoz(2, 2);
            Assert.AreEqual(4, suma);
        }

        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 6)]
        [TestCase(-2, -3, 6)]
        public void Mnoz_ZwracaWynikDodawania(int a, int b, int wynik)
        {
            var kalkulator = new Kalkulator.Kalkulator();
            int suma = kalkulator.Mnoz(a, b);
            Assert.AreEqual(wynik, suma);
        }

        [Test]
        public void Dziel_DwieLiczbyDodatnie_Wynik()
        {
            var kalkulator = new Kalkulator.Kalkulator();
            int suma = kalkulator.Dziel(2, 2);
            Assert.AreEqual(1, suma);
        }

        [TestCase(2, 2, 1)]
        [TestCase(10, 2, 5)]
        [TestCase(-20, -20, 1)]
        public void Dziel_ZwracaWynikDodawania(int a, int b, int wynik)
        {
            var kalkulator = new Kalkulator.Kalkulator();
            int suma = kalkulator.Dziel(a, b);
            Assert.AreEqual(wynik, suma);
        }

        [Test]
        public void Dziel_PrzechwytywanieException_DzieleniePrzezZero()
        {
            var kalkulator = new Kalkulator.Kalkulator();
            try
            {
                int suma = kalkulator.Dziel(2, 0);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, new DivideByZeroException().Message);
            }
        }
    }
}