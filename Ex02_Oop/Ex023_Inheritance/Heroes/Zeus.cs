using Ex023_Inheritance.Abilitys;
using Ex023_Inheritance.BackpackComposition;
using Ex023_Inheritance.Infrastructure;
using System;

namespace Ex023_Inheritance.Heroes
{
    class Zeus : Hero
    {
        public Zeus() 
            : base(name: "Zeus",
                   strength: Randomize.Value(20, 25),
                   agility: Randomize.Value(10, 15),
                   intelligence: Randomize.Value(10, 15),
                   level: 1,
                   movementSpeed: Randomize.Value(),
                   health: Randomize.Value(koff: 3),
                   mana: Randomize.Value()
        )
        {
            base.Items = new Backpack();
            base.Attributes = HeroType.Intelligence;
        }


        // Предупреждение CS0108 "Zeus.Mana" скрывает наследуемый член "Hero.Mana"
        // public ushort Mana => (ushort)(base.mana + base.intelligence * 1.2);
        public override ushort Mana =>  (ushort)(base.mana + base.intelligence * 1.2);



    }
}
