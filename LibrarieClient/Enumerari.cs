using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClient
{
    public enum raspunsTermeni
    {
        RASPUNS_INEXISTENT = 0,
        RASPUNS_DA = 1,
        RASPUNS_NU = 2
    };

    public enum CampuriClient
    {
        ID = 0,
        NUME = 1,
        PRENUME = 2,
        xCNP = 3,
        AN_NASTERE = 4,
        SOLD = 5,
        PERIOADADEPOZIT = 6,
        TELEFON = 7,
        EMAIL = 8,
        CARDURI = 9,      
    };
}
