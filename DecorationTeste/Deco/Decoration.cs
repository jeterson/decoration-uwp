using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;

namespace DecorationTeste.Deco
{
    public abstract class Decoration
    {
        // others common attributes
        public IRandomAccessStream Stream { get; set; }
        


        // other common methods and/or common abstract methods
        public abstract bool IsDecorationDifferentSEF();
    }
}
