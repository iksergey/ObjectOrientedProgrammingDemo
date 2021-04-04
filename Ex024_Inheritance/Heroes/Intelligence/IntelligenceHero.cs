using Ex024_Inheritance.Heroes;

namespace Ex024_Inheritance.Intelligence
{
    public abstract class IntelligenceHero : Hero 
    {
        public override string ToString()
        {
            return $"{this.GetType()}";
        }
    }
}