using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Assets.Characters;
namespace ConceptMario.Assets.Interpreter
{
    public class RemoveCoin: IInterpreter
    {
        Player player;
        public RemoveCoin(Player player)
        {
            this.player = player;
        }
        public void interpreter(Context con)
        {
            player.Coin -= Convert.ToInt32(con.Get(2));
        }
    }
}
