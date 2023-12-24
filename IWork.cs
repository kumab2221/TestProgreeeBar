using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgreeeBar
{
    internal interface IWork
    {
        public event Action<int> ProgressChanged;
        public abstract void Handle();
    }
}
