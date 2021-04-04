using System;
using System.Reflection;
using Ex024_Inheritance.Heroes;
using Ex024_Inheritance.Strength;
using Ex024_Inheritance.Intelligence;
using Ex024_Inheritance.Agility;
using static System.Console;
using static Ex025_Polymorphism.HeroFactory;
using System.Collections.Generic;

namespace Ex025_Polymorphism
{
    class Program
    {
        
        static (int IntelligenceCount, int StrengthCount, int AgilityCount) GetCount()
        {
            int intelligenceCount = 0;
            int strengthCount = 0;
            int agilityCount = 0;

            for (int i = 0; i < 10; i++)
            {
                switch (Randomize.GetNumber(3))
                {
                    case 0: intelligenceCount++; break;
                    case 1: strengthCount++; break;
                    default: agilityCount++; break;
                }
            }
            return (intelligenceCount, strengthCount, agilityCount);
        }
        
        static void Main()
        {
            #region Polymorphism ?

            Console.WriteLine("\nPolymorphism ?\n");

            //Polymorphism?

            //Ex024_Inheritance.Strength.Axe
            //Ex024_Inheritance.Intelligence.CrystalMaiden
            //Ex024_Inheritance.Agility.BountyHunter

            //Axe hero = new Axe(); Console.WriteLine(hero.GetType());
            //CrystalMaiden hero = new CrystalMaiden(); Console.WriteLine(hero.GetType());
            //BountyHunter hero = new BountyHunter(); Console.WriteLine(hero.GetType());

            Hero hero = new Axe(); Console.WriteLine(hero.GetType());
            hero = new CrystalMaiden(); Console.WriteLine(hero.GetType());
            hero = new BountyHunter(); Console.WriteLine(hero.GetType());

            Console.ReadLine();

            #endregion

            #region TeamCreater
            
            Console.WriteLine("\nTeamCreater\n");

            //TeamCreater

            //count = (3, 3, 4)
            //Ex024_Inheritance.Intelligence.Bane
            //Ex024_Inheritance.Intelligence.CrystalMaiden
            //Ex024_Inheritance.Intelligence.Chen
            //Ex024_Inheritance.Strength.Alchemist
            //Ex024_Inheritance.Strength.Beastmaster
            //Ex024_Inheritance.Strength.Alchemist
            //Ex024_Inheritance.Agility.Bloodseeker
            //Ex024_Inheritance.Agility.BountyHunter
            //Ex024_Inheritance.Agility.Broodmother
            //Ex024_Inheritance.Agility.ArcWaeden
           

            List<IntelligenceHero> intelligences = new List<IntelligenceHero>();
            List<StrengthHero> strengths = new List<StrengthHero>();
            List<AgilityHero> agilitys = new List<AgilityHero>();

            var count = GetCount();

            Console.WriteLine($"count = {count}");
            for (int i = 0; i < count.IntelligenceCount; i++)
            {
                intelligences.Add(GetIntelligenceHero());
                Console.WriteLine(intelligences[i]);
            }

            for (int i = 0; i < count.StrengthCount; i++)
            {
                strengths.Add(GetStrengthHero());
                Console.WriteLine(strengths[i]);
            }

            for (int i = 0; i < count.AgilityCount; i++)
            {
                agilitys.Add(GetAgilityHero());
                Console.WriteLine(agilitys[i]);
            }

            Console.ReadLine();

            #endregion

            #region ToDo

            Console.WriteLine("\nToDo\n");

            //ToDo

            //Ex024_Inheritance.Strength.Beastmaster
            //Ex024_Inheritance.Agility.Bloodseeker
            //Ex024_Inheritance.Intelligence.Chen
            //Ex024_Inheritance.Strength.Beastmaster
            //Ex024_Inheritance.Strength.Abaddon
            //Ex024_Inheritance.Strength.Brewmaster
            //Ex024_Inheritance.Intelligence.Bane
            //Ex024_Inheritance.Strength.Beastmaster
            //Ex024_Inheritance.Intelligence.Batrider
            //Ex024_Inheritance.Strength.Beastmaster

            List<Hero> heroes = new();

            for (int i = 0; i < 10; i++)
            {
                heroes.Add(GetHero());
                Console.WriteLine(heroes[i].GetType());
            }

            Console.ReadLine();

            #endregion

            #region Reflection

            Console.WriteLine("\nReflection\n");

            //Reflection

            //Ex024_Inheritance.Intelligence.Chen
            // Было GetHero();
            // Стало GetHeroThroughReflection();

            WriteLine(GetHeroThroughReflection().GetType());

            Console.ReadLine();

            #endregion

            #region Remark

            Console.WriteLine("\nRemark\n");

            //58225482
            //58225482
            //58225482
            //58225482
            //antiMag == agilityHero - True
            //agilityHero == baseHero - True
            //baseHero == am - True

            AntiMag antiMag = new();
            Console.WriteLine(antiMag.GetHashCode());

            AgilityHero agilityHero = antiMag;
            Console.WriteLine(antiMag.GetHashCode());

            Hero baseHero = agilityHero;
            Console.WriteLine(antiMag.GetHashCode());

            AntiMag am = (AntiMag)baseHero;
            Console.WriteLine(am.GetHashCode());

            Console.WriteLine($"antiMag == agilityHero - {antiMag == agilityHero}");
            Console.WriteLine($"agilityHero == baseHero - {agilityHero == baseHero}");
            Console.WriteLine($"baseHero == am - {baseHero == am}");

            Console.ReadLine();





            #endregion
        }
    }
}