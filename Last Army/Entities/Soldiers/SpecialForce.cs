using System.Collections.Generic;
using System.Text;

namespace Last_Army
{
    public class SpecialForce : Soldier
    {
        private const double OverallSkillMiltiplier = 3.5;

 
        public SpecialForce(string name, int age, double experience, double endurance)
            : base(name, age, experience, endurance)
        {
            this.OverallSkill = 3.5 * (this.Age + this.Experience);
        }

        protected override IReadOnlyList<string> WeaponsAllowed => new List<string>
            {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "RPG",
            "Helmet",
            "Knife",
            "NightVision"
        };

        public override void Regenerate()
        {
            this.Endurance += 30 + this.Age;
        }

        //protected readonly List<string> WeaponsAllowed = new List<string>
        //{
        //    "Gun",
        //    "AutomaticMachine",
        //    "MachineGun",
        //    "RPG",
        //    "Helmet",
        //    "Knife",
        //    "NightVision"
        //};



    }
}