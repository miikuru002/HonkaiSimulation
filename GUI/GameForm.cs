using Core;
using Core.Valkyries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GameForm : Form
    {
        //lista con las estrategias
        List<Valkyrie> _strategies;
        //instancia de game
        Game game;

        public GameForm()
        {
            InitializeComponent();

            //inicializa la lista
            _strategies = new List<Valkyrie>();

            //agrega las estrategias de ataque (valquirias)
            _strategies.Add(new HerrscherOfTheVoid());
            _strategies.Add(new HerrscherOfFire());
            _strategies.Add(new HerrscherOfReason());
            _strategies.Add(new StygianNymph());
            _strategies.Add(new DeaAnchora());

            //asocia la lista con el combobox
            this.cmbxValk.DataSource = _strategies;

            //crea un nuevo juego
            game = new Game();
            game.Player = "JamutaqOrtega";

            this.lblPlayer.Text = game.Player;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //obtiene la valquiria seleccionada
            Valkyrie valk = (Valkyrie)this.cmbxValk.SelectedItem;

            //cambia de estrategia (cambia de valquiria)
            MessageBox.Show(game.ChangeValk(valk));
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            try
            {
                string img = game.Attack();

                string full_path = Path.GetFullPath($@"..\..\..\Assets\{img}");

                /* invoca el metodo atacar del jugador, el comportamiento de este 
                 * varia segun la estrategia que se seleccione
                 */
                pcbxAttack.Image = Image.FromFile(full_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
