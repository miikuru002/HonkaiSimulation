using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Valkyries
{
    public class HerrscherOfFire : Valkyrie
    {
        public override string Name => "Kiana Kaslana";

        public override string Battlesuit => "Herrscher Of Fire";

        public override string UltimateAttack()
        {
            return "hof.gif";
        }
    }
}
