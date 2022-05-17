using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Game
    {
        #region Atributos
        private Valkyrie _strategy;

        //nombre del jugador
        public string Player { get; set; }
        #endregion

        #region Metodos
        //metodo para cambiar de estrategia 
        public string ChangeValk(Valkyrie strategy)
        {
            if (strategy != null)
            {
                _strategy = strategy;

                return $"{strategy.Name} - {strategy.Battlesuit} seleccionada!";
            }

            throw new Exception("Ocurrió un error");
        }

        //metodo para atacar con la valquiria seleccionada
        public string Attack()
        {
            if (_strategy != null)
                return _strategy.UltimateAttack();

            throw new Exception("Debes seleccionar una valquiria para atacar");
        }
        #endregion
    }
}
