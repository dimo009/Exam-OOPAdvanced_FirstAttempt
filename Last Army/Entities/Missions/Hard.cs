using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Entities.Missions
{
    public class Hard : Mission
    {
        private const double requiredEndurance = 80.0;

        public Hard(double enduranceRequired, double scoreToComplete) : base(requiredEndurance, scoreToComplete)
        {
        }
    }
}
