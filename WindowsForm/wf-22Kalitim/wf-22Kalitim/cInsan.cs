using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_22Kalitim
{
    sealed class cInsan : cHayvan
    {
        private string _dusunur;

        public string Dusunur
        {
            get { return _dusunur; }
            set { _dusunur = value; }
        }

        public override string YeniDogan()
        {
            return "Bebek";
        }
    }
}
