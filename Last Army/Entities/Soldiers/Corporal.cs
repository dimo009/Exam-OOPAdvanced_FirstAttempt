using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Soldiers
{
    public class Corporal : Soldier
    {
        public Corporal(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
        {
            this.OverallSkill = 2.5 * (this.Age + this.Experience);
        }

        protected override IReadOnlyList<string> WeaponsAllowed => new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "Helmet",
            "Knife"

        };

        public override void Regenerate()
        {
            this.Endurance += 10 + this.Age;
        }
    }
}
