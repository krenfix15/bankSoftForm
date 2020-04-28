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
using System.Collections;

namespace bankSoftForm
{
    public partial class bankSoft : Form
    {
        IStocareData adminClienti;
        public bankSoft()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocare();
        }

        private void NumeText_Enter(object sender, EventArgs e)
        {
            if (textNume.Text == "Nume")
            {
                textNume.Text = "";

                textNume.ForeColor = Color.Black;
            }
        }

        private void NumeText_Leave(object sender, EventArgs e)
        {
            if (textNume.Text == "")
            {
                textNume.Text = "Nume";

                textNume.ForeColor = Color.Gray;
            }
        }

        private void PrenumeText_Enter(object sender, EventArgs e)
        {
            if (textPrenume.Text == "Prenume")
            {
                textPrenume.Text = "";

                textPrenume.ForeColor = Color.Black;
            }
        }

        private void PrenumeText_Leave(object sender, EventArgs e)
        {
            if (textPrenume.Text == "")
            {
                textPrenume.Text = "Prenume";

                textPrenume.ForeColor = Color.Gray;
            }
        }

        private void textCNP_TextChanged(object sender, EventArgs e)
        {

        }

        private void CNPText_Enter(object sender, EventArgs e)
        {
            if (textCNP.Text == "CNP")
            {
                textCNP.Text = "";

                textCNP.ForeColor = Color.Black;
            }
        }

        private void CNPText_Leave(object sender, EventArgs e)
        {
            if (textCNP.Text == "")
            {
                textCNP.Text = "CNP";

                textCNP.ForeColor = Color.Gray;
            }
        }

        private void SoldText_Enter(object sender, EventArgs e)
        {
            if (textSold.Text == "Sold [LEI]")
            {
                textSold.Text = "";

                textSold.ForeColor = Color.Black;
            }
        }

        private void SoldText_Leave(object sender, EventArgs e)
        {
            if (textSold.Text == "")
            {
                textSold.Text = "Sold [LEI]";

                textSold.ForeColor = Color.Gray;
            }
        }

        private void textPerioadaDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerioadaText_Enter(object sender, EventArgs e)
        {
            if (textPerioadaDep.Text == "Perioada [LUNI]")
            {
                textPerioadaDep.Text = "";

                textPerioadaDep.ForeColor = Color.Black;
            }
        }

        private void PerioadaText_Leave(object sender, EventArgs e)
        {
            if (textPerioadaDep.Text == "")
            {
                textPerioadaDep.Text = "Perioada [LUNI]";

                textPerioadaDep.ForeColor = Color.Gray;
            }
        }

        private void TelefonText_Enter(object sender, EventArgs e)
        {
            if (textTelefon.Text == "Telefon [+40]")
            {
                textTelefon.Text = "";

                textTelefon.ForeColor = Color.Black;
            }
        }

        private void TelefonText_Leave(object sender, EventArgs e)
        {
            if (textTelefon.Text == "")
            {
                textTelefon.Text = "Telefon [+40]";

                textTelefon.ForeColor = Color.Gray;
            }
        }

        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "Email")
            {
                textEmail.Text = "";

                textEmail.ForeColor = Color.Black;
            }
        }

        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "Email";

                textEmail.ForeColor = Color.Gray;
            }
        }

        private void textCauta_Enter(object sender, EventArgs e)
        {
            if (textCauta.Text == "Cauta [CNP]")
            {
                textCauta.Text = "";

                textCauta.ForeColor = Color.Black;
            }
        }

        private void textCauta_Leave(object sender, EventArgs e)
        {
            if (textCauta.Text == "")
            {
                textCauta.Text = "Cauta [CNP]";

                textCauta.ForeColor = Color.Gray;
            }
        }

        private CodEroare Validare(string nume, string prenume, string CNP, string sold, string perioada, string telefon, string email)
        {
            if (nume == "Nume")
            {
                return CodEroare.NUME_INCORECT;
            }
            if (prenume == "Prenume")
            {
                return CodEroare.PRENUME_INCORECT;
            }
            var isCNPNumeric = int.TryParse(CNP, out _);
            if (CNP == "CNP" || CNP.Length!=13)
            {
                return CodEroare.CNP_INCORECT;
            }

            var isSoldNumeric = int.TryParse(sold, out _);
            if (sold == "Sold" || !isSoldNumeric)
            {
                return CodEroare.SOLD_INCORECT;
            }

            var isPerioadaNumeric = int.TryParse(perioada, out _);
            if (perioada == "Perioada" || !isPerioadaNumeric)
            {
                return CodEroare.PERIOADA_INCORECT;
            }

            var isTelefonNumeric = int.TryParse(telefon, out _);
            if (telefon == "Telefon [+40]")
            {
                return CodEroare.TELEFON_INCORECT;
            }

            bool IsValidEmail(string _email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(_email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            if (email == "Email" || IsValidEmail(email))
            {
                return CodEroare.EMAIL_INCORECT;
            }

            return CodEroare.CORECT;
        }

        private void butonAddClient_MouseClick(object sender, MouseEventArgs e)
        {
            labelAdauga.Text = "";

            Client c;

            textCNP.ForeColor         = Color.Gray;
            textNume.ForeColor        = Color.Gray;
            textPrenume.ForeColor     = Color.Gray;
            textTelefon.ForeColor     = Color.Gray;
            textEmail.ForeColor       = Color.Gray;
            textSold.ForeColor        = Color.Gray;
            textPerioadaDep.ForeColor = Color.Gray;

            CodEroare valideaza = Validare(textNume.Text, textPrenume.Text, textCNP.Text, textSold.Text, textPerioadaDep.Text, textEmail.Text, textTelefon.Text);
            
            if (valideaza != CodEroare.CORECT)
            {
                switch (valideaza)
                {                   
                    case CodEroare.NUME_INCORECT:
                        textNume.ForeColor = Color.Red;
                        break;
                    case CodEroare.PRENUME_INCORECT:
                        textPrenume.ForeColor = Color.Red;
                        break;
                    case CodEroare.CNP_INCORECT:
                        textCNP.ForeColor = Color.Red;
                        break;
                    case CodEroare.SOLD_INCORECT:
                        textSold.ForeColor = Color.Red;
                        break;
                    case CodEroare.PERIOADA_INCORECT:
                        textPerioadaDep.ForeColor = Color.Red;
                        break;
                    case CodEroare.EMAIL_INCORECT:
                        textEmail.ForeColor = Color.Red;
                        break;
                    case CodEroare.TELEFON_INCORECT:
                        textTelefon.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                c = new Client(textNume.Text, textPrenume.Text, textCNP.Text, textSold.Text, textPerioadaDep.Text, textTelefon.Text, textEmail.Text);
                adminClienti.AddClient(c);
                labelAdauga.Text = "Studentul a fost adaugat cu succes.";
            }
        }

        private void butonCauta_MouseClick(object sender, MouseEventArgs e)
        {
            RtbAfisare.Clear();

            textCauta.ForeColor = Color.Gray;

            ArrayList clienti = adminClienti.GetClienti();

            foreach (Client c in clienti)
            {
                if (textCauta.Text == c.CNP)
                {
                    RtbAfisare.AppendText(c.ConversieLaSir());
                    RtbAfisare.AppendText(Environment.NewLine);
                    textCauta.ForeColor = Color.Black;
                }
                else textCauta.ForeColor = Color.Red;
            }
        }
    }
}
