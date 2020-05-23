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
        //Constante 
        const int CIFRE_CNP = 13;
        const int CIFRE_TELEFON = 9;
        const int MAX_PERIOADA = 1200;
        const int MIN_PERIOADA = 3;
        const int NO_ITEMS_CMB = -1;

        IStocareData adminClienti;
        List<string> carduriSelectate = new List<string>();
        public bankSoft()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocare();
            dataGridClienti.BorderStyle = BorderStyle.None;
            dataGridClienti.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridClienti.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridClienti.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40,60,0);
            dataGridClienti.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridClienti.BackgroundColor = Color.White;
            dataGridClienti.EnableHeadersVisualStyles = false;
            dataGridClienti.DefaultCellStyle.ForeColor = Color.Black;
            dataGridClienti.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dataGridClienti.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridClienti.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40,40,0);
            dataGridClienti.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            btnLogo.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            List<Client> clienti = adminClienti.GetClienti();
            AdaugaClientiInControlDataGridView(clienti);

            for (int i = 1920; i <= DateTime.UtcNow.Year - 18; i++)
            {

                cmbAn.Items.Add(i);
            }

            foreach (DataGridViewColumn column in dataGridClienti.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private static void EnsureVisibleRow(DataGridView view, int rowToShow)
        {
            if (rowToShow >= 0 && rowToShow < view.RowCount)
            {
                var countVisible = view.DisplayedRowCount(false);
                var firstVisible = view.FirstDisplayedScrollingRowIndex;
                if (rowToShow < firstVisible)
                {
                    view.FirstDisplayedScrollingRowIndex = rowToShow;
                }
                else if (rowToShow >= firstVisible + countVisible)
                {
                    view.FirstDisplayedScrollingRowIndex = rowToShow - countVisible + 1;
                }
            }
        }
        private void NumeText_Enter(object sender, EventArgs e)
        {
            if (textNume.Text == "Nume")
            {
                textNume.Text = "";
                textNume.ForeColor = Color.White;
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
                textPrenume.ForeColor = Color.White;
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
                textCNP.ForeColor = Color.White;
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

                textSold.ForeColor = Color.White;
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
                textPerioadaDep.ForeColor = Color.White;
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
                textTelefon.ForeColor = Color.White;
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
                textEmail.ForeColor = Color.White;
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
            if (textCauta.Text == "Caută [CNP]")
            {
                textCauta.Text = "";
                textCauta.ForeColor = Color.White;
            }
        }

        private void textCauta_Leave(object sender, EventArgs e)
        {
            if(textCauta.Text == "")
            {
                textCauta.Text = "Caută [CNP]";
                textCauta.ForeColor = Color.Gray;
            }
        }

        private CodEroare Validare(string nume, string prenume, string CNP, string sold, string perioada, string telefon, string email, string AnulNasterii)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;

            bool numeContainsInt = nume.Any(char.IsDigit);
            bool prenumeContainsInt = prenume.Any(char.IsDigit);
            bool cnpContainsChar = CNP.Any(char.IsLetter);

            if (nume == "Nume" || numeContainsInt)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }

            if (prenume == "Prenume" || prenumeContainsInt)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }

            var isCNPNumeric = int.TryParse(CNP, out _);
            if (CNP == "CNP" || CNP.Length != CIFRE_CNP || cnpContainsChar)
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

            if (cmbAn.SelectedIndex == NO_ITEMS_CMB)
            {
                rezultatValidare |= CodEroare.ANUL_NASTERII_NESELECTAT;
            }

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

            else if (cmbAn.SelectedIndex > NO_ITEMS_CMB)
            {
                c = new Client(textNume.Text, textPrenume.Text, textCNP.Text, textSold.Text, textPerioadaDep.Text, textTelefon.Text, textEmail.Text);
                c.Carduri = new List<string>();
                c.Carduri.AddRange(carduriSelectate);
                c.DATA_DEPUNERE = DateTime.Now;
                c.AN_NASTERE = Int32.Parse(cmbAn.Text);
                adminClienti.AddClient(c);
                labelAdauga.Text = "Clientul a fost adaugat cu succes.";
                ResetareControale();
                List<Client> clienti = adminClienti.GetClienti();
                AdaugaClientiInControlDataGridView(clienti);
            }
        }

        private void butonCauta_MouseClick(object sender, MouseEventArgs e)
        {
            ResetareEtichete();

            textCauta.ForeColor = Color.Gray;

            List<Client> clienti = adminClienti.GetClienti();

            string searchValue = textCauta.Text;
            dataGridClienti.ClearSelection();
            dataGridClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow row in dataGridClienti.Rows)
                {
                    if (row.Cells[4].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        textCauta.ForeColor = Color.White;
                        dataGridClienti.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                    else
                        textCauta.ForeColor = Color.Red;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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

            cmbAn.ForeColor = Color.Gray;
            cmbAn.Text = "Anul nașterii";
            ckbMasterCard.Checked = false;
            ckbVISA.Checked = false;
            carduriSelectate.Clear();
        }

        public void ResetareEtichete()
        {
            labelAdauga.Text = string.Empty;
            if (textCauta.Text != "Caută [CNP]")
                textCauta.ForeColor = Color.White;
            else
                textCauta.ForeColor = Color.Gray;
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
            if ((codValidare & CodEroare.ANUL_NASTERII_NESELECTAT) == CodEroare.ANUL_NASTERII_NESELECTAT)
            {
                cmbAn.ForeColor = Color.Red;
            }
        }
        private void ckbCarduri_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; 

            string cardSelectat = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
            {
                carduriSelectate.Add(cardSelectat);
            }
            else
                carduriSelectate.Remove(cardSelectat);
        }

        public void AdaugaClientiInControlDataGridView(List<Client> clienti)
        {
            dataGridClienti.DataSource = null;
            dataGridClienti.DataSource = clienti.Select(c => new { c.ID_CLIENT, c.NUME, c.PRENUME, c.AN_NASTERE, c.CNP, c.SOLD_CONT, c.PERIOADA_DEPOZITARE, c.TELEFON, c.EMAIL, c.CARDURI, c.DATA_DEPUNERE, c.DATA_FINAL_PERIOADA,c.DOBANDA,c.SOLD_FINAL }).ToList();
            
        }

        private bool sortAscending = false;
        private void dataGridClienti_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Client> clienti = adminClienti.GetClientiActivi();
            if (sortAscending)
                dataGridClienti.DataSource = clienti.Select(c => new { c.ID_CLIENT, c.NUME, c.PRENUME, c.AN_NASTERE, c.CNP, c.SOLD_CONT, c.PERIOADA_DEPOZITARE, c.TELEFON, c.EMAIL, c.CARDURI, c.DATA_DEPUNERE, c.DATA_FINAL_PERIOADA }).OrderBy(c => c.NUME).ToList();
            else
                dataGridClienti.DataSource = clienti.Select(c => new { c.ID_CLIENT, c.NUME, c.PRENUME, c.AN_NASTERE, c.CNP, c.SOLD_CONT, c.PERIOADA_DEPOZITARE, c.TELEFON, c.EMAIL, c.CARDURI, c.DATA_DEPUNERE, c.DATA_FINAL_PERIOADA }).OrderByDescending(c => c.NUME).ToList();
            sortAscending = !sortAscending;
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

        private void dataGridClienti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateForm uForm = new UpdateForm();
            uForm.textNumeUpdate.Text = this.dataGridClienti.CurrentRow.Cells[1].Value.ToString();
            uForm.textPrenumeUpdate.Text = this.dataGridClienti.CurrentRow.Cells[2].Value.ToString();
            uForm.textCNPUpdate.Text = this.dataGridClienti.CurrentRow.Cells[4].Value.ToString();
            uForm.cmbAnUpdate.Text = this.dataGridClienti.CurrentRow.Cells[3].Value.ToString();
            uForm.textSoldUpdate.Text = this.dataGridClienti.CurrentRow.Cells[5].Value.ToString();
            uForm.textPerioadaDepUpdate.Text = this.dataGridClienti.CurrentRow.Cells[6].Value.ToString();
            uForm.textTelefonUpdate.Text = this.dataGridClienti.CurrentRow.Cells[7].Value.ToString();
            uForm.textEmailUpdate.Text = this.dataGridClienti.CurrentRow.Cells[8].Value.ToString();
            uForm.dataDepunere = this.dataGridClienti.CurrentRow.Cells[10].Value.ToString();
            
            Client c = adminClienti.GetClient(this.dataGridClienti.CurrentRow.Cells[4].Value.ToString());

            foreach (var card in uForm.grpCardsUpdate.Controls)
            {
                if (card is CheckBox)
                {
                    var cardBox = card as CheckBox;
                    foreach (String crd in c.Carduri)
                        if (cardBox.Text.Equals(crd))
                            cardBox.Checked = true;
                }
            }

            uForm.ShowDialog();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Client> clienti = adminClienti.GetClienti();
            AdaugaClientiInControlDataGridView(clienti);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Client> clienti = adminClienti.GetClientiActivi();
            dataGridClienti.DataSource = clienti.Select(c => new { c.ID_CLIENT, c.NUME, c.PRENUME, c.AN_NASTERE, c.CNP, c.SOLD_CONT, c.PERIOADA_DEPOZITARE, c.TELEFON, c.EMAIL, c.CARDURI, c.DATA_DEPUNERE, c.DATA_FINAL_PERIOADA, c.DOBANDA, c.SOLD_FINAL }).ToList();
            sfd.ShowDialog();
            if (sfd.FileName == string.Empty)
            {
                MessageBox.Show("Nu s-a efectuat salvarea fisierului!");
            }        
            else
            {
                salvareRaport(clienti, sfd.FileName);
                MessageBox.Show("Salvarea fisierului s-a efectuat cu succes!");
            }
                
        }

        private void închideFereastraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void afișeazăMeniuliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textNume.Enabled = true;
            textPrenume.Enabled = true;
            textCNP.Enabled = true;
            textPerioadaDep.Enabled = true;
            textSold.Enabled = true;
            textTelefon.Enabled = true;
            textEmail.Enabled = true;
            cmbAn.Enabled = true;
            grpCards.Enabled = true;
            butonAddClient.Enabled = true;
        }

        private void ascundeMeniulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textNume.Enabled = false;
            textPrenume.Enabled = false;
            textCNP.Enabled = false;
            textPerioadaDep.Enabled = false;
            textSold.Enabled = false;
            textTelefon.Enabled = false;
            textEmail.Enabled = false;
            cmbAn.Enabled = false;
            grpCards.Enabled = false;
            butonAddClient.Enabled = false;
        }

        private void buttonLogo_MouseHover(object sender, EventArgs e) => btnLogo.ImageIndex = 1;

        private void buttonLogo_MouseLeave(object sender, EventArgs e) => btnLogo.ImageIndex = 0;

    }
}
