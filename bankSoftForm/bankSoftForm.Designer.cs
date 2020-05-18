using System;

namespace bankSoftForm
{
    partial class bankSoft
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankSoft));
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.textSold = new System.Windows.Forms.TextBox();
            this.textCNP = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.textPerioadaDep = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textCauta = new System.Windows.Forms.TextBox();
            this.RtbAfisare = new System.Windows.Forms.RichTextBox();
            this.butonAddClient = new System.Windows.Forms.Button();
            this.textValoare = new System.Windows.Forms.TextBox();
            this.butonAdaugaValoare = new System.Windows.Forms.Button();
            this.labelValoare = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butonCauta = new System.Windows.Forms.Button();
            this.rdbDA = new System.Windows.Forms.RadioButton();
            this.rdbNU = new System.Windows.Forms.RadioButton();
            this.grpRadioTermeni = new System.Windows.Forms.GroupBox();
            this.ckbMasterCard = new System.Windows.Forms.CheckBox();
            this.ckbVISA = new System.Windows.Forms.CheckBox();
            this.grpCards = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblTermeni = new System.Windows.Forms.Label();
            this.cmbAn = new System.Windows.Forms.ComboBox();
            this.btnListare = new System.Windows.Forms.Button();
            this.dataGridClienti = new System.Windows.Forms.DataGridView();
            this.btnDataGrid = new System.Windows.Forms.Button();
            this.labelAdauga = new System.Windows.Forms.Label();
            this.dateDepunere = new System.Windows.Forms.DateTimePicker();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareClientiActiviInFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpRadioTermeni.SuspendLayout();
            this.grpCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNume
            // 
            this.textNume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNume.Location = new System.Drawing.Point(72, 33);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 0;
            this.textNume.Text = "Nume";
            this.textNume.Enter += new System.EventHandler(this.NumeText_Enter);
            this.textNume.Leave += new System.EventHandler(this.NumeText_Leave);
            // 
            // textPrenume
            // 
            this.textPrenume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPrenume.Location = new System.Drawing.Point(72, 73);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(100, 20);
            this.textPrenume.TabIndex = 1;
            this.textPrenume.Text = "Prenume";
            this.textPrenume.Enter += new System.EventHandler(this.PrenumeText_Enter);
            this.textPrenume.Leave += new System.EventHandler(this.PrenumeText_Leave);
            // 
            // textSold
            // 
            this.textSold.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textSold.Location = new System.Drawing.Point(72, 153);
            this.textSold.Name = "textSold";
            this.textSold.Size = new System.Drawing.Size(100, 20);
            this.textSold.TabIndex = 3;
            this.textSold.Text = "Sold [LEI]";
            this.textSold.Enter += new System.EventHandler(this.SoldText_Enter);
            this.textSold.Leave += new System.EventHandler(this.SoldText_Leave);
            // 
            // textCNP
            // 
            this.textCNP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCNP.Location = new System.Drawing.Point(72, 113);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(100, 20);
            this.textCNP.TabIndex = 2;
            this.textCNP.Text = "CNP";
            this.textCNP.Enter += new System.EventHandler(this.CNPText_Enter);
            this.textCNP.Leave += new System.EventHandler(this.CNPText_Leave);
            // 
            // textTelefon
            // 
            this.textTelefon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textTelefon.Location = new System.Drawing.Point(72, 232);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(100, 20);
            this.textTelefon.TabIndex = 5;
            this.textTelefon.Text = "Telefon [+40]";
            this.textTelefon.Enter += new System.EventHandler(this.TelefonText_Enter);
            this.textTelefon.Leave += new System.EventHandler(this.TelefonText_Leave);
            // 
            // textPerioadaDep
            // 
            this.textPerioadaDep.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPerioadaDep.Location = new System.Drawing.Point(72, 192);
            this.textPerioadaDep.Name = "textPerioadaDep";
            this.textPerioadaDep.Size = new System.Drawing.Size(100, 20);
            this.textPerioadaDep.TabIndex = 4;
            this.textPerioadaDep.Text = "Perioada [LUNI]";
            this.textPerioadaDep.Enter += new System.EventHandler(this.PerioadaText_Enter);
            this.textPerioadaDep.Leave += new System.EventHandler(this.PerioadaText_Leave);
            // 
            // textEmail
            // 
            this.textEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmail.Location = new System.Drawing.Point(72, 271);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 6;
            this.textEmail.Text = "Email";
            this.textEmail.Enter += new System.EventHandler(this.EmailText_Enter);
            this.textEmail.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // textCauta
            // 
            this.textCauta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCauta.Location = new System.Drawing.Point(407, 33);
            this.textCauta.Name = "textCauta";
            this.textCauta.Size = new System.Drawing.Size(172, 20);
            this.textCauta.TabIndex = 7;
            this.textCauta.Text = "Cauta [CNP]";
            this.textCauta.Enter += new System.EventHandler(this.textCauta_Enter);
            this.textCauta.Leave += new System.EventHandler(this.textCauta_Leave);
            // 
            // RtbAfisare
            // 
            this.RtbAfisare.Location = new System.Drawing.Point(406, 58);
            this.RtbAfisare.Margin = new System.Windows.Forms.Padding(2);
            this.RtbAfisare.Name = "RtbAfisare";
            this.RtbAfisare.Size = new System.Drawing.Size(200, 256);
            this.RtbAfisare.TabIndex = 12;
            this.RtbAfisare.Text = "";
            // 
            // butonAddClient
            // 
            this.butonAddClient.ForeColor = System.Drawing.SystemColors.Desktop;
            this.butonAddClient.Location = new System.Drawing.Point(72, 447);
            this.butonAddClient.Name = "butonAddClient";
            this.butonAddClient.Size = new System.Drawing.Size(75, 23);
            this.butonAddClient.TabIndex = 13;
            this.butonAddClient.Text = "Adauga";
            this.butonAddClient.UseVisualStyleBackColor = true;
            this.butonAddClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonAddClient_MouseClick);
            // 
            // textValoare
            // 
            this.textValoare.BackColor = System.Drawing.SystemColors.Window;
            this.textValoare.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textValoare.Location = new System.Drawing.Point(406, 319);
            this.textValoare.Name = "textValoare";
            this.textValoare.Size = new System.Drawing.Size(100, 20);
            this.textValoare.TabIndex = 16;
            this.textValoare.Text = "+ Suma";
            this.textValoare.Enter += new System.EventHandler(this.textValoare_Enter);
            // 
            // butonAdaugaValoare
            // 
            this.butonAdaugaValoare.Location = new System.Drawing.Point(512, 319);
            this.butonAdaugaValoare.Name = "butonAdaugaValoare";
            this.butonAdaugaValoare.Size = new System.Drawing.Size(25, 20);
            this.butonAdaugaValoare.TabIndex = 17;
            this.butonAdaugaValoare.Text = "A";
            this.butonAdaugaValoare.UseVisualStyleBackColor = true;
            this.butonAdaugaValoare.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonAdaugaValoare_MouseClick);
            // 
            // labelValoare
            // 
            this.labelValoare.AutoSize = true;
            this.labelValoare.Location = new System.Drawing.Point(404, 342);
            this.labelValoare.Name = "labelValoare";
            this.labelValoare.Size = new System.Drawing.Size(0, 13);
            this.labelValoare.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(38, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 29);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(38, 263);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 29);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(38, 228);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 29);
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(38, 188);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 29);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(38, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // butonCauta
            // 
            this.butonCauta.Image = ((System.Drawing.Image)(resources.GetObject("butonCauta.Image")));
            this.butonCauta.Location = new System.Drawing.Point(581, 33);
            this.butonCauta.Name = "butonCauta";
            this.butonCauta.Size = new System.Drawing.Size(25, 20);
            this.butonCauta.TabIndex = 14;
            this.butonCauta.UseVisualStyleBackColor = true;
            this.butonCauta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonCauta_MouseClick);
            // 
            // rdbDA
            // 
            this.rdbDA.AutoSize = true;
            this.rdbDA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rdbDA.Location = new System.Drawing.Point(6, 0);
            this.rdbDA.Name = "rdbDA";
            this.rdbDA.Size = new System.Drawing.Size(39, 17);
            this.rdbDA.TabIndex = 28;
            this.rdbDA.TabStop = true;
            this.rdbDA.Text = "Da";
            this.rdbDA.UseVisualStyleBackColor = true;
            // 
            // rdbNU
            // 
            this.rdbNU.AutoSize = true;
            this.rdbNU.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rdbNU.Location = new System.Drawing.Point(62, 0);
            this.rdbNU.Name = "rdbNU";
            this.rdbNU.Size = new System.Drawing.Size(39, 17);
            this.rdbNU.TabIndex = 29;
            this.rdbNU.TabStop = true;
            this.rdbNU.Text = "Nu";
            this.rdbNU.UseVisualStyleBackColor = true;
            // 
            // grpRadioTermeni
            // 
            this.grpRadioTermeni.BackColor = System.Drawing.SystemColors.Window;
            this.grpRadioTermeni.Controls.Add(this.rdbNU);
            this.grpRadioTermeni.Controls.Add(this.rdbDA);
            this.grpRadioTermeni.Location = new System.Drawing.Point(59, 412);
            this.grpRadioTermeni.Name = "grpRadioTermeni";
            this.grpRadioTermeni.Size = new System.Drawing.Size(101, 21);
            this.grpRadioTermeni.TabIndex = 30;
            this.grpRadioTermeni.TabStop = false;
            // 
            // ckbMasterCard
            // 
            this.ckbMasterCard.AutoSize = true;
            this.ckbMasterCard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ckbMasterCard.Location = new System.Drawing.Point(5, 0);
            this.ckbMasterCard.Name = "ckbMasterCard";
            this.ckbMasterCard.Size = new System.Drawing.Size(80, 17);
            this.ckbMasterCard.TabIndex = 31;
            this.ckbMasterCard.Text = "MasterCard";
            this.ckbMasterCard.UseVisualStyleBackColor = true;
            this.ckbMasterCard.CheckedChanged += new System.EventHandler(this.ckbCarduri_CheckedChanged);
            // 
            // ckbVISA
            // 
            this.ckbVISA.AutoSize = true;
            this.ckbVISA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ckbVISA.Location = new System.Drawing.Point(5, 19);
            this.ckbVISA.Name = "ckbVISA";
            this.ckbVISA.Size = new System.Drawing.Size(50, 17);
            this.ckbVISA.TabIndex = 32;
            this.ckbVISA.Text = "VISA";
            this.ckbVISA.UseVisualStyleBackColor = true;
            this.ckbVISA.CheckedChanged += new System.EventHandler(this.ckbCarduri_CheckedChanged);
            // 
            // grpCards
            // 
            this.grpCards.BackColor = System.Drawing.SystemColors.Window;
            this.grpCards.Controls.Add(this.ckbMasterCard);
            this.grpCards.Controls.Add(this.ckbVISA);
            this.grpCards.Location = new System.Drawing.Point(72, 309);
            this.grpCards.Name = "grpCards";
            this.grpCards.Size = new System.Drawing.Size(100, 36);
            this.grpCards.TabIndex = 33;
            this.grpCards.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(38, 309);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 29);
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // lblTermeni
            // 
            this.lblTermeni.AutoSize = true;
            this.lblTermeni.BackColor = System.Drawing.SystemColors.Window;
            this.lblTermeni.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTermeni.Location = new System.Drawing.Point(12, 396);
            this.lblTermeni.Name = "lblTermeni";
            this.lblTermeni.Size = new System.Drawing.Size(199, 13);
            this.lblTermeni.TabIndex = 35;
            this.lblTermeni.Text = "Sunteți de acord cu termenii și condițiile?";
            // 
            // cmbAn
            // 
            this.cmbAn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbAn.FormattingEnabled = true;
            this.cmbAn.Location = new System.Drawing.Point(71, 360);
            this.cmbAn.Name = "cmbAn";
            this.cmbAn.Size = new System.Drawing.Size(101, 21);
            this.cmbAn.TabIndex = 36;
            this.cmbAn.Text = "Anul nașterii";
            // 
            // btnListare
            // 
            this.btnListare.BackColor = System.Drawing.SystemColors.Window;
            this.btnListare.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnListare.Location = new System.Drawing.Point(407, 358);
            this.btnListare.Name = "btnListare";
            this.btnListare.Size = new System.Drawing.Size(75, 23);
            this.btnListare.TabIndex = 37;
            this.btnListare.Text = "Lista Clienti";
            this.btnListare.UseVisualStyleBackColor = false;
            this.btnListare.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAfisareLista_MouseClick);
            // 
            // dataGridClienti
            // 
            this.dataGridClienti.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClienti.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridClienti.Location = new System.Drawing.Point(622, 27);
            this.dataGridClienti.Name = "dataGridClienti";
            this.dataGridClienti.Size = new System.Drawing.Size(590, 440);
            this.dataGridClienti.TabIndex = 39;
            // 
            // btnDataGrid
            // 
            this.btnDataGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnDataGrid.Image")));
            this.btnDataGrid.Location = new System.Drawing.Point(565, 429);
            this.btnDataGrid.Name = "btnDataGrid";
            this.btnDataGrid.Size = new System.Drawing.Size(41, 38);
            this.btnDataGrid.TabIndex = 40;
            this.btnDataGrid.UseVisualStyleBackColor = true;
            this.btnDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDataGrid_MouseClick);
            // 
            // labelAdauga
            // 
            this.labelAdauga.AutoSize = true;
            this.labelAdauga.ForeColor = System.Drawing.Color.Red;
            this.labelAdauga.Location = new System.Drawing.Point(147, 452);
            this.labelAdauga.Name = "labelAdauga";
            this.labelAdauga.Size = new System.Drawing.Size(0, 13);
            this.labelAdauga.TabIndex = 41;
            // 
            // dateDepunere
            // 
            this.dateDepunere.Location = new System.Drawing.Point(189, 33);
            this.dateDepunere.Name = "dateDepunere";
            this.dateDepunere.Size = new System.Drawing.Size(200, 20);
            this.dateDepunere.TabIndex = 42;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareClientiActiviInFisierTextToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvareClientiActiviInFisierTextToolStripMenuItem
            // 
            this.salvareClientiActiviInFisierTextToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.salvareClientiActiviInFisierTextToolStripMenuItem.Name = "salvareClientiActiviInFisierTextToolStripMenuItem";
            this.salvareClientiActiviInFisierTextToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.salvareClientiActiviInFisierTextToolStripMenuItem.Text = "[Salvare Clienti Activi]";
            this.salvareClientiActiviInFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salvareInFisierToolStripMenuItem_Click);
            // 
            // bankSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 479);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateDepunere);
            this.Controls.Add(this.labelAdauga);
            this.Controls.Add(this.btnDataGrid);
            this.Controls.Add(this.dataGridClienti);
            this.Controls.Add(this.btnListare);
            this.Controls.Add(this.cmbAn);
            this.Controls.Add(this.lblTermeni);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.grpCards);
            this.Controls.Add(this.grpRadioTermeni);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelValoare);
            this.Controls.Add(this.butonAdaugaValoare);
            this.Controls.Add(this.textValoare);
            this.Controls.Add(this.butonCauta);
            this.Controls.Add(this.butonAddClient);
            this.Controls.Add(this.RtbAfisare);
            this.Controls.Add(this.textCauta);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.textPerioadaDep);
            this.Controls.Add(this.textSold);
            this.Controls.Add(this.textCNP);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bankSoft";
            this.Text = "bankSoft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpRadioTermeni.ResumeLayout(false);
            this.grpRadioTermeni.PerformLayout();
            this.grpCards.ResumeLayout(false);
            this.grpCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.TextBox textSold;
        private System.Windows.Forms.TextBox textCNP;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.TextBox textPerioadaDep;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textCauta;
        private System.Windows.Forms.RichTextBox RtbAfisare;
        private System.Windows.Forms.Button butonAddClient;
        private System.Windows.Forms.Button butonCauta;
        private System.Windows.Forms.TextBox textValoare;
        private System.Windows.Forms.Button butonAdaugaValoare;
        private System.Windows.Forms.Label labelValoare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton rdbDA;
        private System.Windows.Forms.RadioButton rdbNU;
        private System.Windows.Forms.GroupBox grpRadioTermeni;
        private System.Windows.Forms.CheckBox ckbMasterCard;
        private System.Windows.Forms.CheckBox ckbVISA;
        private System.Windows.Forms.GroupBox grpCards;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblTermeni;
        private System.Windows.Forms.ComboBox cmbAn;
        private System.Windows.Forms.Button btnListare;
        private System.Windows.Forms.DataGridView dataGridClienti;
        private System.Windows.Forms.Button btnDataGrid;
        private System.Windows.Forms.Label labelAdauga;
        private System.Windows.Forms.DateTimePicker dateDepunere;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareClientiActiviInFisierTextToolStripMenuItem;
    }
}

