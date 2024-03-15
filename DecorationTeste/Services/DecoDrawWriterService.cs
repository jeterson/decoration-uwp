using DecorationTeste.Deco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationTeste.Services
{
    internal class DecoDrawWriterService : DecoWriterBase
    {
        public override void Writer(Decoration decoration)
        {
            var decorationDraw = (DecorationDraw)decoration;
        }
    }
}
