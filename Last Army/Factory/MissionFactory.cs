using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Army.Factory
{
    public class MissionFactory : IMissionFactory
    {
        public IMission CreateMission(string difficultyLevel, double neededPoints)
        {
            throw new NotImplementedException();
        }
    }
}
