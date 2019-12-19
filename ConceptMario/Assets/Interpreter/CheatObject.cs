using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario.Assets.Interpreter
{
    public class CheatObject : IInterpreter
    {
        IInterpreter coin;
        public CheatObject(IInterpreter coin)
        {
            this.coin = coin;
        }
        public void interpreter(Context con)
        {
            if (con.Get(0)== "Coin")
            {
                coin.interpreter(con);
            }
        }
    }
}