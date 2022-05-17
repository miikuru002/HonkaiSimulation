using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Valkyries
{
    public class DeaAnchora : Valkyrie
    {
        public override string Name => "Durandal";

        public override string Battlesuit => "Dea Anchora";

        public override string UltimateAttack()
        {
            return "dea_anchora.gif";
        }
    }
}
