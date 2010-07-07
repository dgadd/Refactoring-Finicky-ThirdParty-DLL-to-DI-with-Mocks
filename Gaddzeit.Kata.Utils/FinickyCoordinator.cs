using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gaddzeit.Kata.Utils
{
    public class FinickyCoordinator
    {
        private readonly IFinickyWrapper _finickyWrapper;

        public FinickyCoordinator(IFinickyWrapper finickyWrapper)
        {
            _finickyWrapper = finickyWrapper;
        }

        public string DoMyCustomAction()
        {
            return _finickyWrapper.DoSomethingProprietary();
        }
    }
}
