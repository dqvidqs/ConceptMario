using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario.Assets.Interpreter
{
    public class Coin : IInterpreter
    {
        IInterpreter add;
        IInterpreter remove;
        public Coin(IInterpreter add, IInterpreter remove)
        {
            this.add = add;
            this.remove = remove;
        }
        public void interpreter(Context con)
        {
            if (con.Get(1) == "Add")
            {
                add.interpreter(con);
            }
            else
            {
                remove.interpreter(con);
            }
        }
    }
}
