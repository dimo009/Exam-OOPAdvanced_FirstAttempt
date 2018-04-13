using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Ammunitions
{
    public abstract class Ammunition:IAmmunition
    {
        private string name;

        private double weight;

        private double wearLevel;

        public Ammunition(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.WearLevel = this.Weight * 100;
        }


        

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
         
        }

        public double Weight
        {
            get { return this.weight; }
            protected set { this.weight = value; }
        }

        public double WearLevel
        {
            get { return this.wearLevel; }
        
            set { this.wearLevel = value; }
        }

        public void DecreaseWearLevel(double wearAmount)
        {
            this.WearLevel -= wearAmount;
        }
    }
}
