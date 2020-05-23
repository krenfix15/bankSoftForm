using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankSoftForm
{
    [Flags]
    public enum CodEroare
    {
        CORECT = 0,
        NUME_INCORECT = 1,
        PRENUME_INCORECT = 2,
        CNP_INCORECT = 4,
        SOLD_INCORECT = 16,
        PERIOADA_INCORECT = 32,
        TELEFON_INCORECT = 64,
        EMAIL_INCORECT = 128,
        CAUTA_INCORECT = 256,
        ANUL_NASTERII_NESELECTAT = 512
    }
}
