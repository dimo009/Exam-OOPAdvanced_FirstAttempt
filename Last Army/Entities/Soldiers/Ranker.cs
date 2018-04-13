using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Soldiers
{
    public class Ranker : Soldier
    {
        public Ranker(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
        {
            this.OverallSkill = 1.5 * (this.Age + this.Experience);
        }

        protected override IReadOnlyList<string> WeaponsAllowed => new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "Helmet"

        };

        public override void Regenerate()
        {
            this.Endurance += this.Age + 10;
        }

    }
}
