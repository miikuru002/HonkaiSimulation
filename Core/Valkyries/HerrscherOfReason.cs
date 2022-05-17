using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Valkyries
{
    public class HerrscherOfReason : Valkyrie
    {
        public override string Name => "Bronya Zaychik";

        public override string Battlesuit => "Herrscher Of Reason";

        public override string UltimateAttack()
        {
            return "hor.gif";
        }
    }
}
