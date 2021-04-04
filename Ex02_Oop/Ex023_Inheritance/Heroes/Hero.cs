using Ex023_Inheritance.Abilitys;
using Ex023_Inheritance.BackpackComposition;
using Ex023_Inheritance.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex023_Inheritance.Heroes
{
    class Hero
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
        public HeroType Attributes { get; set; }
        public string Name { get; init; }


        public ushort Strength => strength;
        public ushort Agility => agility;
        public ushort Intelligence => intelligence;
        public virtual ushort Health => health;
        public virtual ushort Mana => mana;

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




        public Hero() :
            this(name: $"Hero #{Guid.NewGuid().ToString().Substring(0, 5)}",
                 strength: 0,
                 agility: 0,
                 intelligence: 0,
                 level: 0,
                 movementSpeed: 0,
                 health: 0,
                 mana: 0
                )
        {
            Items = new Backpack();
        }

        public Hero(string name,
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
            return String.Format(pattrn,
                                 Name,
                                 strength,
                                 agility,
                                 intelligence,
                                 health,
                                 mana,
                                 this.GetType().Name
                                );
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
