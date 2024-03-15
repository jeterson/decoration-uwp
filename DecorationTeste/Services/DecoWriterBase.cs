using DecorationTeste.Deco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationTeste.Services
{
    internal interface IDecoWriter
    {
        void Writer(Decoration decoration);
    }
    internal abstract class DecoWriterBase : IDecoWriter
    {
        // common properties and/or common methods implementation/abstracts for writer deco
        public abstract void Writer(Decoration decoration);  
        
        public string GetClipInfoSEF(Decoration decoration)
        {
            return "";
        }
    }
}
