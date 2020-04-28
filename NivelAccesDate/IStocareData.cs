using LibrarieClient;
using System.Collections;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddClient(Client s);
        ArrayList GetClienti();

        Client GetClient(string nume, string prenume);

        bool UpdateClient(Client s);
    }
}
