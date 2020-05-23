using LibrarieClient;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddClient(Client s);
        List<Client> GetClienti();

        Client GetClient(string cnp);

        bool UpdateClient(Client s);

        List<Client> GetClientiActivi();
    }
}
