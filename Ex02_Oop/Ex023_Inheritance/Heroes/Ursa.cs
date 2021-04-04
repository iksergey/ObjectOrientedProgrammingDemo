using Ex023_Inheritance.Abilitys;
using Ex023_Inheritance.BackpackComposition;
using Ex023_Inheritance.Infrastructure;
using System;

namespace Ex023_Inheritance.Heroes
{
    class Ursa : Hero
    {
        public Ursa() :
            base(name: "Ursa",
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
            base.Attributes = HeroType.Agility;
        }
     }

}
