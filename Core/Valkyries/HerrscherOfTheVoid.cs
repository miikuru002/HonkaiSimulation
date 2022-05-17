using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Valkyries
{
    public class HerrscherOfTheVoid : Valkyrie
    {
        public override string Name => "Kiana Kaslana";

        public override string Battlesuit => "Herrscher Of The Void";

        public override string UltimateAttack()
        {
            return "hov.gif";
        }
    }
}
