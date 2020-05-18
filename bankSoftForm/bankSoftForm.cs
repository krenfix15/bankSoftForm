using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibrarieClient;
using NivelAccesDate;
using System.Collections.Generic;
using System.IO;

namespace bankSoftForm
{
    public partial class bankSoft : Form
    {
        IStocareData adminClienti;
        List<string> carduriSelectate = new List<string>();
        public bankSoft()
        {
            this.BackgroundImage = Properties.Resources.bck7;
            InitializeComponent();
            this.Width = 635;
            adminClienti = StocareFactory.GetAdministratorStocare();
            for (int i = 1920; i <= DateTime.UtcNow.Year-18; i++)
            {

                cmbAn.Items.Add(i);
            }
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

        private void textValoare_Enter(object sender, EventArgs e)
        {
            if (textValoare.Text == "+ Suma")
            {
                textValoare.Text = "";

                textValoare.ForeColor = Color.Black;
            }
        }

        private void textValoare_Leave(object sender, EventArgs e)
        {
            if (textValoare.Text == "")
            {
                textValoare.Text = "+ Suma";

                textValoare.ForeColor = Color.Gray;
            }
        }

        private CodEroare Validare(string nume, string prenume, string CNP, string sold, string perioada, string telefon, string email,string anulNasterii)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;

            bool containsInt = nume.Any(char.IsDigit);
            bool prenumeContainsInt = prenume.Any(char.IsDigit);

            if (nume == "Nume" || containsInt)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }

            if (prenume == "Prenume" || prenumeContainsInt)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }

            var isCNPNumeric = int.TryParse(CNP, out _);
            if (CNP == "CNP" || CNP.Length!=13)
            {
                rezultatValidare |= CodEroare.CNP_INCORECT;
            }

            var isSoldNumeric = int.TryParse(sold, out _);
            if (sold == "Sold" || !isSoldNumeric)
            {
                rezultatValidare |= CodEroare.SOLD_INCORECT;
            }

            var isPerioadaNumeric = int.TryParse(perioada, out _);
            if (perioada == "Perioada" || !isPerioadaNumeric || Int32.Parse(perioada)>1200)
            {
                rezultatValidare |= CodEroare.PERIOADA_INCORECT;
            }

            var isTelefonNumeric = int.TryParse(telefon, out _);
            if (telefon == "Telefon [+40]" || telefon.Length != 9 || !isTelefonNumeric)
            {
                rezultatValidare |= CodEroare.TELEFON_INCORECT;
            }

            if (cmbAn.SelectedIndex == -1)
            {
                rezultatValidare |= CodEroare.ANUL_NASTERII_NESELECTAT;
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

            int RaspunsSelectat = 0;
            foreach (var control in grpRadioTermeni.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    RaspunsSelectat = 1;
            }
            if (RaspunsSelectat == 0)
                rezultatValidare |= CodEroare.NO_RASPUNS_TERMENI;

            return rezultatValidare;
        }

        private void butonAddClient_MouseClick(object sender, MouseEventArgs e)
        {
            ResetareEtichete();

            Client c;

            CodEroare codValidare = Validare(textNume.Text, textPrenume.Text, textCNP.Text, textSold.Text, textPerioadaDep.Text, textTelefon.Text, textEmail.Text, cmbAn.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }

            else if(rdbNU.Checked)
            {
                rdbNU.ForeColor = Color.Red;
            }

            else if(rdbDA.Checked && cmbAn.SelectedIndex>-1)
            {
                c = new Client(textNume.Text, textPrenume.Text, textCNP.Text, textSold.Text, textPerioadaDep.Text, textTelefon.Text, textEmail.Text);          
                c.raspunsTRM = GetRaspunsSelectat();
                c.AnNastere = Int32.Parse(cmbAn.Text);
                c.Carduri = new List<string>();
                c.Carduri.AddRange(carduriSelectate);
                c.DataDepunere = dateDepunere.Value;

                adminClienti.AddClient(c);
                labelAdauga.Text = "Clientul a fost adaugat cu succes.";
                
                ResetareControale();
            }
        }

        private void butonCauta_MouseClick(object sender, MouseEventArgs e)
        {
            ResetareEtichete();

            RtbAfisare.Clear();

            textCauta.ForeColor = Color.Gray;

            List<Client> clienti = adminClienti.GetClienti();           

            foreach (Client c in clienti)
            {
                if (textCauta.Text == c.CNP)
                {
                    RtbAfisare.AppendText(c.ConversieLaSir());
                    RtbAfisare.AppendText(Environment.NewLine);
                    foreach (var card in grpCards.Controls)
                    {
                        if (card is CheckBox)
                        {
                            var cardBox = card as CheckBox;
                            foreach (String crd in c.Carduri)
                                if (cardBox.Text.Equals(crd))
                                    cardBox.Checked = true;
                        }
                    }
                    textCauta.ForeColor = Color.Gray;
                }
                else
                    textCauta.ForeColor = Color.Red;

                if (textNume.Enabled == true && textPrenume.Enabled == true)
                {
                    textNume.Enabled = false;
                    textPrenume.Enabled = false;
                    textCNP.Enabled = false;
                    textSold.Enabled = false;
                    textPerioadaDep.Enabled = false;
                    textTelefon.Enabled = false;
                    textEmail.Enabled = false;
                    cmbAn.Enabled = false;

                    //dezactivare butoane radio
                    foreach (var button in grpRadioTermeni.Controls)
                    {
                        if (button is RadioButton)
                        {
                            var radioButton = button as RadioButton;
                            radioButton.Enabled = false;
                        }
                    }
                }
                else
                {
                    textNume.Enabled = true;
                    textPrenume.Enabled = true;
                    textCNP.Enabled = true;
                    textSold.Enabled = true;
                    textPerioadaDep.Enabled = true;
                    textTelefon.Enabled = true;
                    textEmail.Enabled = true;
                    cmbAn.Enabled = true;

                    //activare butoane radio
                    foreach (var button in grpRadioTermeni.Controls)
                    {
                        if (button is RadioButton)
                        {
                            var radioButton = button as RadioButton;
                            radioButton.Enabled = true;
                        }
                    }
                }
            }
        }

        private void butonAdaugaValoare_MouseClick(object sender, MouseEventArgs e)
        {
            List <Client>clienti = adminClienti.GetClienti();
                
            foreach (Client c in clienti)
            {
                if (c.CNP==textCauta.Text)
                {
                    int sumaActuala = Int32.Parse(c.soldCont);
                    int sumaAdaugata = Int32.Parse(textValoare.Text);
                    sumaActuala += sumaAdaugata;
                    c.soldCont = sumaActuala.ToString();
                    adminClienti.UpdateClient(c);
                    Console.WriteLine("{0}", c.soldCont);
                    labelValoare.ForeColor = Color.Black;
                    labelValoare.Text = "Suma adaugata cu succes!";                      
                }
            }         
        }

        private void ResetareControale()
        {
            textCNP.ForeColor = Color.Gray;
            textNume.ForeColor = Color.Gray;
            textPrenume.ForeColor = Color.Gray;
            textTelefon.ForeColor = Color.Gray;
            textEmail.ForeColor = Color.Gray;
            textSold.ForeColor = Color.Gray;
            textPerioadaDep.ForeColor = Color.Gray;
            textCauta.ForeColor = Color.Gray;

            textCNP.Text = "CNP";
            textNume.Text = "Nume";
            textPrenume.Text = "Prenume";
            textTelefon.Text = "Telefon [+40]";
            textEmail.Text = "Email";
            textSold.Text = "Sold [LEI]";
            textPerioadaDep.Text = "Perioada [LUNI]";
            textCauta.Text = "Cauta [CNP]";
            textValoare.Text = "+ Suma";

            rdbDA.Checked = false;
            rdbNU.Checked = false;
            rdbDA.ForeColor = Color.Gray;
            rdbNU.ForeColor = Color.Gray;
            ckbMasterCard.Checked = false;
            ckbVISA.Checked = false;
            cmbAn.ForeColor = Color.Gray;
            cmbAn.Text = "Anul nașterii";

            carduriSelectate.Clear();
        }

        public void ResetareEtichete()
        {
            labelAdauga.Text = string.Empty;
            labelValoare.Text = string.Empty;
            rdbDA.ForeColor = Color.Gray;
            rdbDA.ForeColor = Color.Gray;
        }

        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                textNume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                textPrenume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CNP_INCORECT) == CodEroare.CNP_INCORECT)
            {
                textCNP.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.EMAIL_INCORECT) == CodEroare.EMAIL_INCORECT)
            {
                textEmail.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PERIOADA_INCORECT) == CodEroare.PERIOADA_INCORECT)
            {
                textPerioadaDep.ForeColor = Color.Red;               
            }
            if ((codValidare & CodEroare.SOLD_INCORECT) == CodEroare.SOLD_INCORECT)
            {
                textSold.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.TELEFON_INCORECT) == CodEroare.TELEFON_INCORECT)
            {
                textTelefon.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.NO_RASPUNS_TERMENI) == CodEroare.NO_RASPUNS_TERMENI)
            {
                rdbDA.ForeColor = Color.Red;
                rdbNU.ForeColor = Color.Red;
            }
            if((codValidare & CodEroare.ANUL_NASTERII_NESELECTAT)==CodEroare.ANUL_NASTERII_NESELECTAT)
            {
                cmbAn.ForeColor = Color.Red;
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
            {
                carduriSelectate.Add(cardSelectat);
                rdbNU.ForeColor = Color.Gray;
            }
                
            else
                carduriSelectate.Remove(cardSelectat);
        }

        private raspunsTermeni GetRaspunsSelectat()
        {
            if (rdbDA.Checked)
                return raspunsTermeni.RASPUNS_DA;
            if (rdbNU.Checked)
                return raspunsTermeni.RASPUNS_NU;
            
            return raspunsTermeni.RASPUNS_INEXISTENT;
        }

        private void btnAfisareLista_MouseClick(object sender, MouseEventArgs e)
        {
            ListaClienti listaClienti = new ListaClienti();
            listaClienti.ShowDialog();
        }

        bool boolbtnDataGrid = true;
        private void btnDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            List<Client> clienti = adminClienti.GetClienti();
            AdaugaClientiInControlDataGridView(clienti);

            if (boolbtnDataGrid)
            {
                boolbtnDataGrid = false;
                this.Width = 1250;
            }
            else
            {
                boolbtnDataGrid = true;
                this.Width = 635;
            }
        }
        private void AdaugaClientiInControlDataGridView(List<Client> clienti)
        {
            //reset continut control DataGridView
            dataGridClienti.DataSource = null;
            //personalizare sursa de date
            dataGridClienti.DataSource = clienti.Select(c => new { c.IDClient, c.Nume, c.Prenume, c.AnNastere, c.CNP,c.soldCont,c.perioadaDepozitare,c.Telefon,c.Email,c.CarduriAsString, c.DataDepunere, c.DataFinalPerioada } ).ToList();
        }

        private void salvareInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Client> clienti = adminClienti.GetClientiActivi();
            dataGridClienti.DataSource = clienti.Select(c => new { c.IDClient, c.Nume, c.Prenume, c.AnNastere, c.CNP, c.soldCont, c.perioadaDepozitare, c.Telefon, c.Email, c.CarduriAsString, c.DataDepunere, c.DataFinalPerioada }).ToList();
            sfd.ShowDialog();
            salvareRaport(clienti, sfd.FileName);
        }
        public void salvareRaport(List<Client> clienti, string numeFisier)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                {
                    foreach (Client c in clienti)
                    {
                        swFisierText.WriteLine(c.ConversieLaSir_PentruFisier());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
    }
}
