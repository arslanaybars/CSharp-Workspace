using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_28GenericCollections
{
    class cOrnek<T>
    {
        public T Alan1;

        public T Metot1(T sayi)
        {
            return sayi;
        }

        public int Metot1(int sayi)
        {
            return sayi * sayi;
        }
    }
}
