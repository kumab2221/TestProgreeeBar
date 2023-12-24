using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgreeeBar
{
    internal class Work : IWork
    {
        public event Action<int>? ProgressChanged;
        public void Handle()
        {
            for(int i=0; i<=100; i++)
            {
                System.Threading.Thread.Sleep(100);
                ProgressChanged?.Invoke(i);
            }
        }
    }
}
