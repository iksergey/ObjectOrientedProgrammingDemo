using Ex024_Inheritance.Agility;
using Ex024_Inheritance.Heroes;
using Ex024_Inheritance.Intelligence;
using Ex024_Inheritance.Strength;
using System;
using System.Reflection;

namespace Ex024_Inheritance
{
    class Program
    {

        // абстракция
        static void Main(string[] args)
        {
            

            StrengthHero strengthHero = new StrengthHero();
            AgilityHero agilityHero = new AgilityHero();
            IntelligenceHero intelligenceHero = new IntelligenceHero();

            AntiMag antiCreep = new AntiMag();
            Hero hero = antiCreep;
             

            CrystalMaiden cm = new CrystalMaiden();
            Axe axe = new Axe();

        }
    }
}
