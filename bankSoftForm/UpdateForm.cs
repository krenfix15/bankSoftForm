using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibrarieClient;
using NivelAccesDate;
using System.Collections.Generic;
using System.IO;
using System.Linq.Dynamic;

namespace bankSoftForm
{
    public partial class UpdateForm : Form
    {
        const int CIFRE_CNP = 13;
        const int CIFRE_TELEFON = 9;
        const int MAX_PERIOADA = 1200;
        const int MIN_PERIOADA = 3;
        const int NO_ITEMS_CMB = -1;

        IStocareData adminClienti;
        List<string> carduriSelectate = new List<string>();
        public Client client;
        public bankSoft bankSoftform = new bankSoft();
        public UpdateForm()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocare();
            for (int i = 1920; i <= DateTime.UtcNow.Year - 18; i++)
            {

                cmbAnUpdate.Items.Add(i);
            }
        }

        public string dataDepunere;
        private void NumeTextUpdate_Enter(object sender, EventArgs e)
        {
            if (textNumeUpdate.Text == "Nume")
            {
                textNumeUpdate.Text = "";
                textNumeUpdate.ForeColor = Color.Black;
            }
        }

        private void NumeTextUpdate_Leave(object sender, EventArgs e)
        {
            if (textNumeUpdate.Text == "")
            {
                textNumeUpdate.Text = "Nume";
                textNumeUpdate.ForeColor = Color.Gray;
            }
        }

        private void PrenumeTextUpdate_Enter(object sender, EventArgs e)
        {
            if (textPrenumeUpdate.Text == "Prenume")
            {
                textPrenumeUpdate.Text = "";
                textPrenumeUpdate.ForeColor = Color.Black;
            }
        }

        private void PrenumeTextUpdate_Leave(object sender, EventArgs e)
        {
            if (textPrenumeUpdate.Text == "")
            {
                textPrenumeUpdate.Text = "Prenume";
                textPrenumeUpdate.ForeColor = Color.Gray;
            }
        }


        private void CNPTextUpdate_Enter(object sender, EventArgs e)
        {
            if (textCNPUpdate.Text == "CNP")
            {
                textCNPUpdate.Text = "";
                textCNPUpdate.ForeColor = Color.Black;
            }
        }

        private void CNPTextUpdate_Leave(object sender, EventArgs e)
        {
            if (textCNPUpdate.Text == "")
            {
                textCNPUpdate.Text = "CNP";
                textCNPUpdate.ForeColor = Color.Gray;
            }
        }

        private void SoldTextUpdate_Enter(object sender, EventArgs e)
        {
            if (textSoldUpdate.Text == "Sold [LEI]")
            {
                textSoldUpdate.Text = "";

                textSoldUpdate.ForeColor = Color.Black;
            }
        }

        private void SoldTextUpdate_Leave(object sender, EventArgs e)
        {
            if (textSoldUpdate.Text == "")
            {
                textSoldUpdate.Text = "Sold [LEI]";
                textSoldUpdate.ForeColor = Color.Gray;
            }
        }

        private void PerioadaTextUpdate_Enter(object sender, EventArgs e)
        {
            if (textPerioadaDepUpdate.Text == "Perioada [LUNI]")
            {
                textPerioadaDepUpdate.Text = "";
                textPerioadaDepUpdate.ForeColor = Color.Black;
            }
        }

        private void PerioadaTextUpdate_Leave(object sender, EventArgs e)
        {
            if (textPerioadaDepUpdate.Text == "")
            {
                textPerioadaDepUpdate.Text = "Perioada [LUNI]";
                textPerioadaDepUpdate.ForeColor = Color.Gray;
            }
        }

        private void TelefonTextUpdate_Enter(object sender, EventArgs e)
        {
            if (textTelefonUpdate.Text == "Telefon [+40]")
            {
                textTelefonUpdate.Text = "";
                textTelefonUpdate.ForeColor = Color.Black;
            }
        }

        private void TelefonTextUpdate_Leave(object sender, EventArgs e)
        {
            if (textTelefonUpdate.Text == "")
            {
                textTelefonUpdate.Text = "Telefon [+40]";
                textTelefonUpdate.ForeColor = Color.Gray;
            }
        }

        private void EmailTextUpdate_Enter(object sender, EventArgs e)
        {
            if (textEmailUpdate.Text == "Email")
            {
                textEmailUpdate.Text = "";
                textEmailUpdate.ForeColor = Color.Black;
            }
        }

        private void EmailTextUpdate_Leave(object sender, EventArgs e)
        {
            if (textEmailUpdate.Text == "")
            {
                textEmailUpdate.Text = "Email";
                textEmailUpdate.ForeColor = Color.Gray;
            }
        }

        private void ResetareControale()
        {
            textCNPUpdate.ForeColor = Color.Gray;
            textNumeUpdate.ForeColor = Color.Gray;
            textPrenumeUpdate.ForeColor = Color.Gray;
            textTelefonUpdate.ForeColor = Color.Gray;
            textEmailUpdate.ForeColor = Color.Gray;
            textSoldUpdate.ForeColor = Color.Gray;
            textPerioadaDepUpdate.ForeColor = Color.Gray;
            textCNPUpdate.Text = "CNP";
            textNumeUpdate.Text = "Nume";
            textPrenumeUpdate.Text = "Prenume";
            textTelefonUpdate.Text = "Telefon [+40]";
            textEmailUpdate.Text = "Email";
            textSoldUpdate.Text = "Sold [LEI]";
            textPerioadaDepUpdate.Text = "Perioada [LUNI]";

            cmbAnUpdate.ForeColor = Color.Gray;
            cmbAnUpdate.Text = "Anul nașterii";
            ckbMasterCard.Checked = false;
            ckbVISA.Checked = false;
            carduriSelectate.Clear();
        }

        public void ResetareEtichete()
        {
            labelUpdate.Text = string.Empty;
        }

        private CodEroare Validare(string nume, string prenume, string CNP, string sold, string perioada, string telefon, string email, string AnulNasterii)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;

            bool numeContainsInt = nume.Any(char.IsDigit);
            bool prenumeContainsInt = prenume.Any(char.IsDigit);

            if (nume == "Nume" || numeContainsInt)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }

            if (prenume == "Prenume" || prenumeContainsInt)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }

            var isCNPNumeric = int.TryParse(CNP, out _);
            if (CNP == "CNP" || CNP.Length != CIFRE_CNP)
            {
                rezultatValidare |= CodEroare.CNP_INCORECT;
            }

            var isSoldNumeric = int.TryParse(sold, out _);
            if (sold == "Sold" || !isSoldNumeric)
            {
                rezultatValidare |= CodEroare.SOLD_INCORECT;
            }

            var isPerioadaNumeric = int.TryParse(perioada, out _);
            if (perioada == "Perioada" || !isPerioadaNumeric || Int32.Parse(perioada) > MAX_PERIOADA || Int32.Parse(perioada) < MIN_PERIOADA)
            {
                rezultatValidare |= CodEroare.PERIOADA_INCORECT;
            }

            var isTelefonNumeric = int.TryParse(telefon, out _);
            if (telefon == "Telefon [+40]" || telefon.Length != CIFRE_TELEFON || !isTelefonNumeric)
            {
                rezultatValidare |= CodEroare.TELEFON_INCORECT;
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

            if (email == "Email" || !IsValidEmail(email))
            {
                rezultatValidare |= CodEroare.EMAIL_INCORECT;
            }

            if (cmbAnUpdate.SelectedIndex == NO_ITEMS_CMB)
            {
                rezultatValidare |= CodEroare.ANUL_NASTERII_NESELECTAT;
            }

            return rezultatValidare;
        }

        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                textNumeUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                textPrenumeUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CNP_INCORECT) == CodEroare.CNP_INCORECT)
            {
                textCNPUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.EMAIL_INCORECT) == CodEroare.EMAIL_INCORECT)
            {
                textEmailUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PERIOADA_INCORECT) == CodEroare.PERIOADA_INCORECT)
            {
                textPerioadaDepUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.SOLD_INCORECT) == CodEroare.SOLD_INCORECT)
            {
                textSoldUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.TELEFON_INCORECT) == CodEroare.TELEFON_INCORECT)
            {
                textTelefonUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.ANUL_NASTERII_NESELECTAT) == CodEroare.ANUL_NASTERII_NESELECTAT)
            {
                cmbAnUpdate.ForeColor = Color.Red;
            }
        }

        private void ckbCarduri_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string cardSelectat = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                carduriSelectate.Add(cardSelectat);
            else
                carduriSelectate.Remove(cardSelectat);
        }

        public void butonUpdateClient_MouseClick(object sender, MouseEventArgs e)
        {
            ResetareEtichete();

            CodEroare codValidare = Validare(textNumeUpdate.Text, textPrenumeUpdate.Text, textCNPUpdate.Text, textSoldUpdate.Text, textPerioadaDepUpdate.Text, textTelefonUpdate.Text, textEmailUpdate.Text, cmbAnUpdate.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else if (cmbAnUpdate.SelectedIndex > NO_ITEMS_CMB)
            {
                try
                {
                    client = new Client(textNumeUpdate.Text, textPrenumeUpdate.Text, textCNPUpdate.Text, textSoldUpdate.Text, textPerioadaDepUpdate.Text, textTelefonUpdate.Text, textEmailUpdate.Text);
                    client.Carduri = new List<string>();
                    client.Carduri.AddRange(carduriSelectate);
                    client.AN_NASTERE = Int32.Parse(cmbAnUpdate.Text);
                    client.DATA_DEPUNERE = Convert.ToDateTime(dataDepunere);
                    adminClienti.UpdateClient(client);
                    labelUpdate.Text = "Clientul a fost modificat cu succes.";
                }
                catch(Exception)
                {
                    MessageBox.Show("Nu s a realizat actualizarea!");
                }
                finally
                {
                    bankSoftform.pictureLogo_Click(null, null);
                }           
            }
        }
    }
}
