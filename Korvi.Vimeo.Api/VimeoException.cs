using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korvi.Vimeo.Api
{
    public class VimeoException : Exception
    {
        public VimeoException(string message) : base(message) { }
    }
}
