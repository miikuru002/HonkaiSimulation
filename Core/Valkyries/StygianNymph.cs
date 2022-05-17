using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Valkyries
{
    public class StygianNymph : Valkyrie
    {
        public override string Name => "Seele Vollerei";

        public override string Battlesuit => "Stygian Nymph";

        public override string UltimateAttack()
        {
            return "stygian_nymph.gif";
        }
    }
}
