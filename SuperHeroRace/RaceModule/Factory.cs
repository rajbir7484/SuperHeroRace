using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroRace.RaceModule
{
    public static class Factory
    {
        public static Punter GetPunter(string pp)
        {
            if(pp.Equals("Noah"))
            {
                return new Noah() { Name = "Noah", Cash = 50 };
            }
            else if(pp.Equals("William"))
            {
                return new William() { Name = "William", Cash = 50 };
            }
            else if (pp.Equals("George"))
            {
                return new George() { Name = "George", Cash = 50 };
            }
            else
            {
                return null;
            }
        }
    }
}
