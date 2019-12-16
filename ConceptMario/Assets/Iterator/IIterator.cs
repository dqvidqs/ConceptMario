using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario.Assets.Iterator
{
    public interface IIterator
    {
        object Next();
        bool HasNext();
    }
}
