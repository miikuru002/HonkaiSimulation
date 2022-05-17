using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    //Estrategia Valkyrie
    public abstract class Valkyrie
    {
        //nombre de la valquiria
        public abstract string Name { get; }

        //nombre del traje de batalla
        public abstract string Battlesuit { get; }

        //metodo para la lógica del ataque
        public abstract string UltimateAttack();
    }
}
