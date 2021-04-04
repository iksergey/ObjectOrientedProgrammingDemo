using Ex023_Inheritance.Heroes;
using Ex023_Inheritance.Items;
using System;

namespace Ex023_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var axe = new Axe();
            axe.About();
            axe.Teleport(1, 1);
            axe.Items.PortalItemSlot = new PortalItem();
            axe.Teleport(1, 1);
            Console.WriteLine("\n---\n");

            var zeus = new Zeus();
            zeus.About();
            zeus.Teleport(1, 1);
            zeus.Items.PortalItemSlot = new PortalItem();
            zeus.Teleport(1, 1);
            Console.WriteLine("\n---\n");


            var ursa = new Ursa();
            ursa.About();
            ursa.Teleport(1, 1);
            ursa.Items.PortalItemSlot = new PortalItem();
            ursa.Teleport(1, 1);
            Console.WriteLine("\n---\n");

        }
    }
}
