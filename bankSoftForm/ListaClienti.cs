using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieClient;
using NivelAccesDate;
using System.Collections.Generic;
using System.Collections;

namespace bankSoftForm
{
    public partial class ListaClienti : Form
    {  
        IStocareData adminClienti;
        public ListaClienti()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocare();
            lstClienti.Items.Clear();
            var antetTabel = String.Format("{0,0} \t{1,25} {2,25} {3,25} \t      {4,25} {5,25} {6,25} {7,35} {8,35} {9,35}", "Id", "Nume", "Prenume", "CNP", "Anul Nasterii", "Sold", "Perioada", "Telefon", "Email", "Carduri");
            lstClienti.Items.Add(antetTabel);

            List<Client> clienti = adminClienti.GetClienti();

            foreach (Client c in clienti)
            {
                var linieTabel = String.Format("{0,0} {1,25} {2,25} {3,25} {4,25} {5,25} {6,25} {7,35} {8,35} {9,25}\n", c.IDClient, c.Nume, c.Prenume, c.CNP, c.AnNastere, c.soldCont,c.perioadaDepozitare,c.Telefon,c.Email,c.CarduriAsString);
                lstClienti.Items.Add(linieTabel);
            }
            
        }
    }
}

