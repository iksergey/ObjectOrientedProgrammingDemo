using Ex024_Inheritance.Heroes;

namespace Ex024_Inheritance.Strength
{
    public abstract class StrengthHero : Hero
    {
        public override string ToString()
        {
            return $"{this.GetType()}";
        }
    }
}
