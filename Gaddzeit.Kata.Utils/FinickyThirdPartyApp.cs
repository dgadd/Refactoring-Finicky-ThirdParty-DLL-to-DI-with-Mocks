using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gaddzeit.Kata.Utils
{
    public class FinickyThirdPartyApp
    {
        public string DoSomethingProprietary()
        {
            throw new Exception("I'm FINICKY about licensing on dev machines! You can't use me, dev!");
        }
    }
}
