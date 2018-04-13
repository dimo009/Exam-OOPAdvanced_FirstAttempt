using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class RPG:Ammunition
    {
        // public const double Weight = 17.1;

        public RPG(string name)
            : base(name, weight:17.1)
        {
        }
    }
}