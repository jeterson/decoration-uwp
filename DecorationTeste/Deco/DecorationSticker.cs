using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationTeste.Deco
{
    internal class DecorationSticker : Decoration
    {
        // specific attributes
        public int StickerType { get; set; }
        

        // methods and override methods
        public override bool IsDecorationDifferentSEF()
        {
            return true;
        }
    }
}
