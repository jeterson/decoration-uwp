using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationTeste.Deco
{
    internal class DecorationDraw: Decoration
    {
        public int PenEffectMode { get; set; }
        // specific attributes


        // methods and override methods
        public override bool IsDecorationDifferentSEF()
        {
            return true;
        }
    }
}
