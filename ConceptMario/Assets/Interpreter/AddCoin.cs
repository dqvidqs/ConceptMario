using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Assets.Characters;

namespace ConceptMario.Assets.Interpreter
{
    public class AddCoin : IInterpreter
    {
        Player player;
        public AddCoin(Player player)
        {
            this.player = player;
        }
        public void interpreter(Context con)
        {
            player.Coin += Convert.ToInt32(con.Get(2));
        }
    }
}
