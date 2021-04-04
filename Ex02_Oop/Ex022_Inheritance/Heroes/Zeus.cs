using Ex023_Inheritance.Abilitys;
using Ex023_Inheritance.BackpackComposition;
using Ex023_Inheritance.Infrastructure;
using System;

namespace Ex023_Inheritance.Heroes
{
    class Zeus
    {
        protected Ability[] abilities;
        protected ushort strength;
        protected ushort agility;
        protected ushort intelligence;

        protected byte level;
        protected ushort movementSpeed;

        protected ushort health, maximumHealth;
        protected ushort mana, maximumMana;


        public Backpack Items { get; set; }
        public HeroType Attributes { get; init; }
        public string Name { get; init; }


        public ushort Strength => strength;
        public ushort Agility => agility;
        public ushort Intelligence => intelligence;
        public ushort Health => health;
        public ushort Mana => (ushort)(health + mana * 1.2);

        public short Attack
        {
            get
            {
                double result = Attributes switch
                {
                    HeroType.Strength => strength,
                    HeroType.Agility => agility,
                    HeroType.Intelligence => intelligence,
                    _ => 0
                };

                result *= 1.2;

                ///
                ///
                ///

                return (short)result;
            }
        }

        public byte Level => level;
        public ushort MovementSpeed => movementSpeed;

        public Zeus() :
            this(name: $"Hero #{Guid.NewGuid().ToString().Substring(0, 5)}",
                 strength: Randomize.Value(10, 15),
                 agility: Randomize.Value(10, 15),
                 intelligence: Randomize.Value(20, 25),
                 level: 1,
                 movementSpeed: Randomize.Value(),
                 health: Randomize.Value(),
                 mana: Randomize.Value(koff: 3)
                )
        {
            Items = new Backpack();
            Attributes = HeroType.Intelligence;
        }

        public Zeus(string name,
                    ushort strength,
                    ushort agility,
                    ushort intelligence,
                    byte level,
                    ushort movementSpeed,
                    ushort health,
                    ushort mana,
                    params Ability[] abilities
                    )
        {
            this.Name = name;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.level = level;
            this.movementSpeed = movementSpeed;
            this.health = health;
            this.maximumHealth = health;
            this.mana = mana;
            this.maximumMana = mana;
            this.abilities = abilities;
        }

        public string About()
        {
            string pattrn = "Name: {0} Strength: {1} Agility: {2} Intelligence: {3}: Health: {4} Mana: {5} type: {6}";
            var result = String.Format(pattrn,
                                 Name,
                                 strength,
                                 agility,
                                 intelligence,
                                 health,
                                 mana,
                                 this.GetType().Name
                                );
            Console.WriteLine(result);
            return result;
        }
        public void MoveTo(int x = 1, int y = 1)
        {
            Console.WriteLine($"{this.Name} MoveTo [{x} {y}]");
        }
        public void Teleport(int x, int y)
        {
            if (this.Items["PortalItem"].ItemName != "NullItem")
            {
                Console.WriteLine($"Teleport to x:{x} y:{y}");
            }
            else
            {
                Console.WriteLine("No item");
            }
        }

        public Ability GetAbility(byte indexOf)
        {
            return abilities[indexOf];
        }


    }
}
