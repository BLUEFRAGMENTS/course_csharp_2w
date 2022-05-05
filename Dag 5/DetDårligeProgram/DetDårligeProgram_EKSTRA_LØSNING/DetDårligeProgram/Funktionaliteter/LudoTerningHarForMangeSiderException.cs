using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetDårligeProgram.Funktionaliteter
{
    internal class LudoTerningHarForMangeSiderException : System.Exception
    {
        public LudoTerningHarForMangeSiderException(int terningeSide)
            : base($"En ludoterning har ikke en {terningeSide}. side")
        {
        }
    }
}
