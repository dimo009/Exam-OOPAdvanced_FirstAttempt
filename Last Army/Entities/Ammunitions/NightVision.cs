using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class NightVision:Ammunition
    {
        //public const double Weight = 0.8;

        public NightVision(string name)
            : base (name, weight:0.8)
        {
        }
    }
}