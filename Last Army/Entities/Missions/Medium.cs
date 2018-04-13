using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Missions
{
    public class Medium : Mission
    {
        private const double requiredEndurance = 50.0;

        public Medium(double enduranceRequired, double scoreToComplete) : base(requiredEndurance, scoreToComplete)
        {
        }
    }
}
