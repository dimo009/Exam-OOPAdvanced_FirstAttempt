using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Missions
{
    public abstract class Mission:IMission
    {
        private string name;
        private double enduranceRequired;
        private double scoreToComplete;
        private double wearLevelDecrement;
        public Mission(double enduranceRequired, double scoreToComplete)
        {
            this.EnduranceRequired = enduranceRequired;
            this.ScoreToComplete = scoreToComplete;
        }

       

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double EnduranceRequired
        {
            get { return enduranceRequired; }
            set { enduranceRequired = value; }
        }
        public double ScoreToComplete
        {
            get { return scoreToComplete; }
            set { scoreToComplete = value; }
        }
 
        public double WearLevelDecrement
        {
            get { return WearLevelDecrement; }
            set { WearLevelDecrement = value; }
        }





    }
}
