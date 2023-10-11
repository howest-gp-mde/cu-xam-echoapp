using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mde.Echo.Services
{
    public class EchoService
    {

        public string ReverseIt(string it)
        {
            it = it?.Trim() ?? "";
            return new string(it.Reverse().ToArray());
        }

    }
}
