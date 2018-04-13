using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Missions
{
    public class Easy : Mission
    {
        private const double requiredEndurance = 20.0;

        public Easy(double enduranceRequired, double scoreToComplete) : base(requiredEndurance, scoreToComplete)
        {
        }
    }
}
