using Ex023_Inheritance.Infrastructure;
using Ex023_Inheritance.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex023_Inheritance.BackpackComposition
{
    class Backpack
    {
        public Backpack()
        {
            Slots = new GameItem[6] 
            {
                new NullItem(), 
                new NullItem(),
                new NullItem(),
                new NullItem(),
                new NullItem(),
                new NullItem()
            };
            BonusSlots = new GameItem[3]
            {
                new NullItem(),
                new NullItem(),
                new NullItem()
                };
            NeutralItemSlot = new NullItem();
            PortalItemSlot = new NullItem();
        }

        public GameItem[] Slots { get; set; }
        public GameItem[] BonusSlots { get; set; }
        public GameItem PortalItemSlot { get; set; }
        public GameItem NeutralItemSlot { get; set; }

        public Item this[string itemType]
        {
            get
            {
                return itemType switch
                {
                    "Slots" => Slots[Randomize.Value(Slots.Length)],
                    "BonusSlots" => BonusSlots[Randomize.Value(BonusSlots.Length)],
                    "NeutralItem" => NeutralItemSlot,
                    "PortalItem" => PortalItemSlot,
                    _ => new NullItem()
                };
            }
        }

    }
}