using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class Gun:Ammunition
    {
        // public const double Weight = 1.4;

        public Gun(string name) : base(name, weight:1.4)
        {
        }
    }
}