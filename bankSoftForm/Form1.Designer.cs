namespace bankSoftForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.butonCauta = new System.Windows.Forms.Button();
            this.textCauta = new System.Windows.Forms.TextBox();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.textCNP = new System.Windows.Forms.TextBox();
            this.textSold = new System.Windows.Forms.TextBox();
            this.textPerioadaDep = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.butonAddClient = new System.Windows.Forms.Button();
            this.grpCards = new System.Windows.Forms.GroupBox();
            this.ckbVISA = new System.Windows.Forms.CheckBox();
            this.ckbMasterCard = new System.Windows.Forms.CheckBox();
            this.labelAdauga = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridClienti = new System.Windows.Forms.DataGridView();
            this.dateDepunere = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.grpCards.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.butonCauta);
            this.panel2.Controls.Add(this.textCauta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 78);
            this.panel2.TabIndex = 1;
            // 
            // butonCauta
            // 
            this.butonCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonCauta.ForeColor = System.Drawing.Color.DimGray;
            this.butonCauta.Image = ((System.Drawing.Image)(resources.GetObject("butonCauta.Image")));
            this.butonCauta.Location = new System.Drawing.Point(371, 25);
            this.butonCauta.Name = "butonCauta";
            this.butonCauta.Size = new System.Drawing.Size(43, 25);
            this.butonCauta.TabIndex = 16;
            this.butonCauta.UseVisualStyleBackColor = false;
            // 
            // textCauta
            // 
            this.textCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textCauta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCauta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCauta.Location = new System.Drawing.Point(127, 29);
            this.textCauta.Name = "textCauta";
            this.textCauta.Size = new System.Drawing.Size(247, 20);
            this.textCauta.TabIndex = 15;
            this.textCauta.Text = "Caută [CNP]";
            // 
            // textNume
            // 
            this.textNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNume.Location = new System.Drawing.Point(46, 71);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 42;
            this.textNume.Text = "Nume";
            // 
            // textPrenume
            // 
            this.textPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrenume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPrenume.Location = new System.Drawing.Point(46, 111);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(100, 20);
            this.textPrenume.TabIndex = 43;
            this.textPrenume.Text = "Prenume";
            // 
            // textCNP
            // 
            this.textCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textCNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCNP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCNP.Location = new System.Drawing.Point(46, 151);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(100, 20);
            this.textCNP.TabIndex = 44;
            this.textCNP.Text = "CNP";
            // 
            // textSold
            // 
            this.textSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSold.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textSold.Location = new System.Drawing.Point(46, 191);
            this.textSold.Name = "textSold";
            this.textSold.Size = new System.Drawing.Size(100, 20);
            this.textSold.TabIndex = 45;
            this.textSold.Text = "Sold [LEI]";
            // 
            // textPerioadaDep
            // 
            this.textPerioadaDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPerioadaDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPerioadaDep.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPerioadaDep.Location = new System.Drawing.Point(46, 230);
            this.textPerioadaDep.Name = "textPerioadaDep";
            this.textPerioadaDep.Size = new System.Drawing.Size(100, 20);
            this.textPerioadaDep.TabIndex = 46;
            this.textPerioadaDep.Text = "Perioada [LUNI]";
            // 
            // textTelefon
            // 
            this.textTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textTelefon.Location = new System.Drawing.Point(46, 270);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(100, 20);
            this.textTelefon.TabIndex = 47;
            this.textTelefon.Text = "Telefon [+40]";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmail.Location = new System.Drawing.Point(46, 309);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 48;
            this.textEmail.Text = "Email";
            // 
            // butonAddClient
            // 
            this.butonAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonAddClient.ForeColor = System.Drawing.Color.DimGray;
            this.butonAddClient.Location = new System.Drawing.Point(57, 472);
            this.butonAddClient.Name = "butonAddClient";
            this.butonAddClient.Size = new System.Drawing.Size(75, 23);
            this.butonAddClient.TabIndex = 49;
            this.butonAddClient.Text = "Adauga";
            this.butonAddClient.UseVisualStyleBackColor = false;
            // 
            // grpCards
            // 
            this.grpCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpCards.Controls.Add(this.ckbMasterCard);
            this.grpCards.Controls.Add(this.ckbVISA);
            this.grpCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCards.ForeColor = System.Drawing.Color.DimGray;
            this.grpCards.Location = new System.Drawing.Point(46, 335);
            this.grpCards.Name = "grpCards";
            this.grpCards.Size = new System.Drawing.Size(100, 57);
            this.grpCards.TabIndex = 58;
            this.grpCards.TabStop = false;
            // 
            // ckbVISA
            // 
            this.ckbVISA.AutoSize = true;
            this.ckbVISA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ckbVISA.Location = new System.Drawing.Point(6, 34);
            this.ckbVISA.Name = "ckbVISA";
            this.ckbVISA.Size = new System.Drawing.Size(50, 17);
            this.ckbVISA.TabIndex = 32;
            this.ckbVISA.Text = "VISA";
            this.ckbVISA.UseVisualStyleBackColor = true;
            // 
            // ckbMasterCard
            // 
            this.ckbMasterCard.AutoSize = true;
            this.ckbMasterCard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ckbMasterCard.Location = new System.Drawing.Point(6, 11);
            this.ckbMasterCard.Name = "ckbMasterCard";
            this.ckbMasterCard.Size = new System.Drawing.Size(80, 17);
            this.ckbMasterCard.TabIndex = 31;
            this.ckbMasterCard.Text = "MasterCard";
            this.ckbMasterCard.UseVisualStyleBackColor = true;
            // 
            // labelAdauga
            // 
            this.labelAdauga.AutoSize = true;
            this.labelAdauga.ForeColor = System.Drawing.Color.Red;
            this.labelAdauga.Location = new System.Drawing.Point(121, 472);
            this.labelAdauga.Name = "labelAdauga";
            this.labelAdauga.Size = new System.Drawing.Size(0, 13);
            this.labelAdauga.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(236, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 47);
            this.panel1.TabIndex = 63;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(93)))), ((int)(((byte)(97)))));
            this.panelSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSideMenu.BackgroundImage")));
            this.panelSideMenu.Controls.Add(this.dateDepunere);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.labelAdauga);
            this.panelSideMenu.Controls.Add(this.grpCards);
            this.panelSideMenu.Controls.Add(this.butonAddClient);
            this.panelSideMenu.Controls.Add(this.textEmail);
            this.panelSideMenu.Controls.Add(this.textTelefon);
            this.panelSideMenu.Controls.Add(this.textPerioadaDep);
            this.panelSideMenu.Controls.Add(this.textSold);
            this.panelSideMenu.Controls.Add(this.textCNP);
            this.panelSideMenu.Controls.Add(this.textPrenume);
            this.panelSideMenu.Controls.Add(this.textNume);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Enabled = false;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 548);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.dataGridClienti);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 470);
            this.panel3.TabIndex = 17;
            // 
            // dataGridClienti
            // 
            this.dataGridClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClienti.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridClienti.Location = new System.Drawing.Point(20, 20);
            this.dataGridClienti.Name = "dataGridClienti";
            this.dataGridClienti.Size = new System.Drawing.Size(754, 425);
            this.dataGridClienti.TabIndex = 0;
            // 
            // dateDepunere
            // 
            this.dateDepunere.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateDepunere.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateDepunere.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateDepunere.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateDepunere.CalendarTrailingForeColor = System.Drawing.Color.Goldenrod;
            this.dateDepunere.Location = new System.Drawing.Point(46, 422);
            this.dateDepunere.Name = "dateDepunere";
            this.dateDepunere.Size = new System.Drawing.Size(100, 20);
            this.dateDepunere.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpCards.ResumeLayout(false);
            this.grpCards.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butonCauta;
        private System.Windows.Forms.TextBox textCauta;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.TextBox textCNP;
        private System.Windows.Forms.TextBox textSold;
        private System.Windows.Forms.TextBox textPerioadaDep;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button butonAddClient;
        private System.Windows.Forms.GroupBox grpCards;
        private System.Windows.Forms.CheckBox ckbMasterCard;
        private System.Windows.Forms.CheckBox ckbVISA;
        private System.Windows.Forms.Label labelAdauga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridClienti;
        private System.Windows.Forms.DateTimePicker dateDepunere;
    }
}