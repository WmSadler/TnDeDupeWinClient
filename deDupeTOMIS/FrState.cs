using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deDupeTOMIS
{
    public static class FrState
    {
        static bool _ippConnect;
        public static bool ippConnect
        {
            get
            {
                return _ippConnect;
            }
            set
            {
                _ippConnect = value;
            }
        }

        static bool _ippLocal;
        public static bool ippLocal
        {
            get
            {
                return _ippLocal;
            }
            set
            {
                _ippLocal = value;
            }
        }
    }
}
