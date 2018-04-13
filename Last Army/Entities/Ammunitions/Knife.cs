using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class Knife:Ammunition
    {
        //public const double Weight = 0.4;

        public Knife(string name)
            : base (name, weight:0.4)
        {
        }
    }
}