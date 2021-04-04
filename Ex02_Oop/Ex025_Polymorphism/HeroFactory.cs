using Ex024_Inheritance.Agility;
using Ex024_Inheritance.Heroes;
using Ex024_Inheritance.Intelligence;
using Ex024_Inheritance.Strength;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex025_Polymorphism

{


    static class HeroFactory
    {




        public static StrengthHero GetStrengthHero(int index = 0)
        {
            StrengthHero hero;
            if (index == 0) { index = Randomize.GetNumber(1, 6); }

            hero = index switch
            {
                1 => new Abaddon(),
                2 => new Alchemist(),
                3 => new Axe(),
                4 => new Beastmaster(),
                _ => new Brewmaster(),
            };
            return hero;
        }
        public static AgilityHero GetAgilityHero(int index = 0)
        {
            AgilityHero hero;
            if (index == 0) { index = Randomize.GetNumber(1, 6); }

            hero = index switch
            {
                1 => new AntiMag(),
                2 => new ArcWaeden(),
                3 => new Bloodseeker(),
                4 => new BountyHunter(),
                _ => new Broodmother()
            };
            return hero;
        }
        public static IntelligenceHero GetIntelligenceHero(int index = 0)
        {
            IntelligenceHero hero;
            if (index == 0) { index = Randomize.GetNumber(1, 6); }

            hero = index switch
            {
                1 => new AncientApparition(),
                2 => new CrystalMaiden(),
                3 => new Chen(),
                4 => new Batrider(),
                _ => new Bane()
            };

            return hero;
        }
















        #region ToDo

        public static Hero GetHero(int index = 0)
        {
            Hero hero;
            if (index == 0) { index = Randomize.GetNumber(1, 15); }

             
            hero = index switch
            {
                1 => new Abaddon(),
                2 => new Alchemist(),
                3 => new Axe(),
                4 => new Beastmaster(),
                5 => new Brewmaster(),
                6 => new CrystalMaiden(),
                7 => new Chen(),
                8 => new Batrider(),
                9 => new Bane(),
                10 => new AncientApparition(),
                11 => new AntiMag(),
                12 => new ArcWaeden(),
                13 => new Bloodseeker(),
                14 => new BountyHunter(),
                _ => new Broodmother()
            };

            return hero;
        }


        #endregion

    
        #region ToDo2









        public static Hero GetHeroThroughReflection(int index = 10)
        {

            string path = @"Ex024_Inheritance.dll";

            Assembly assembly = Assembly.LoadFrom(path);
            //Assembly assembly = Assembly.GetExecutingAssembly(); // для типов текущей сборки

            var types = assembly.GetTypes();
            int some = Randomize.GetNumber(types.Length);
            return assembly
                .CreateInstance(
                    // index = 0 - ошибка т к в текущей сборке первым попадёт,
                    // скорее всего, класс Program, который к Hero привести не получится
                    types[index == 0 ? some : index] 
                    .FullName
                ) as Hero;
        }



        #endregion
    }
}
