using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_22Kalitim
{
    abstract class cCanli
    {
        private string _solunum;
        private string _beslenme;
        private string _bosaltim;
        private string _ureme;

        #region Properties
        public string Solunum
        {
            get { return _solunum; }
            set { _solunum = value; }
        }

        public string Beslenme
        {
            get { return _beslenme; }
            set { _beslenme = value; }
        }

        public string Bosaltim
        {
            get { return _bosaltim; }
            set { _bosaltim = value; }
        }

        public string Ureme
        {
            get { return _ureme; }
            set { _ureme = value; }
        } 
        #endregion

        public abstract void Beslen();

        public abstract void SuIc();
    }
}
