using Ex024_Inheritance.Heroes;

namespace Ex024_Inheritance.Agility
{
    public abstract class AgilityHero : Hero
    {
        public override string ToString()
        {
            return $"{this.GetType()}";
        }
    }
}