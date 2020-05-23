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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankSoft));
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridClienti = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTopSide = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.butonCauta = new System.Windows.Forms.Button();
            this.textCauta = new System.Windows.Forms.TextBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.cmbAn = new System.Windows.Forms.ComboBox();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.textCNP = new System.Windows.Forms.TextBox();
            this.textSold = new System.Windows.Forms.TextBox();
            this.labelAdauga = new System.Windows.Forms.Label();
            this.textPerioadaDep = new System.Windows.Forms.TextBox();
            this.grpCards = new System.Windows.Forms.GroupBox();
            this.ckbMasterCard = new System.Windows.Forms.CheckBox();
            this.ckbVISA = new System.Windows.Forms.CheckBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.butonAddClient = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.închideFereastraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascundeMeniulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăMeniuliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelTopSide.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.grpCards.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelData.Controls.Add(this.dataGridClienti);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(200, 78);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(689, 449);
            this.panelData.TabIndex = 2;
            // 
            // dataGridClienti
            // 
            this.dataGridClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClienti.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridClienti.Location = new System.Drawing.Point(22, 19);
            this.dataGridClienti.Name = "dataGridClienti";
            this.dataGridClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClienti.Size = new System.Drawing.Size(646, 410);
            this.dataGridClienti.TabIndex = 0;
            this.dataGridClienti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClienti_CellDoubleClick);
            this.dataGridClienti.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridClienti_ColumnHeaderMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItem1.Text = "Actualizează Datele";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stergeToolStripMenuItem.Image")));
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.stergeToolStripMenuItem.Text = "Salvează în fișier";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // panelTopSide
            // 
            this.panelTopSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopSide.BackgroundImage")));
            this.panelTopSide.Controls.Add(this.btnLogo);
            this.panelTopSide.Controls.Add(this.butonCauta);
            this.panelTopSide.Controls.Add(this.textCauta);
            this.panelTopSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSide.Location = new System.Drawing.Point(200, 0);
            this.panelTopSide.Name = "panelTopSide";
            this.panelTopSide.Size = new System.Drawing.Size(689, 78);
            this.panelTopSide.TabIndex = 1;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogo.ImageIndex = 0;
            this.btnLogo.ImageList = this.imageList1;
            this.btnLogo.Location = new System.Drawing.Point(631, 18);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(37, 44);
            this.btnLogo.TabIndex = 18;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.MouseLeave += new System.EventHandler(this.buttonLogo_MouseLeave);
            this.btnLogo.MouseHover += new System.EventHandler(this.buttonLogo_MouseHover);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Graphicloads-Polygon-Bank.ico");
            this.imageList1.Images.SetKeyName(1, "Graphicloads-Colorful-Long-Shadow-Bank.ico");
            // 
            // butonCauta
            // 
            this.butonCauta.BackColor = System.Drawing.Color.Olive;
            this.butonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonCauta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.butonCauta.Image = ((System.Drawing.Image)(resources.GetObject("butonCauta.Image")));
            this.butonCauta.Location = new System.Drawing.Point(390, 32);
            this.butonCauta.Name = "butonCauta";
            this.butonCauta.Size = new System.Drawing.Size(44, 20);
            this.butonCauta.TabIndex = 16;
            this.butonCauta.UseVisualStyleBackColor = false;
            this.butonCauta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonCauta_MouseClick);
            // 
            // textCauta
            // 
            this.textCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textCauta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCauta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCauta.Location = new System.Drawing.Point(110, 32);
            this.textCauta.Name = "textCauta";
            this.textCauta.Size = new System.Drawing.Size(285, 20);
            this.textCauta.TabIndex = 15;
            this.textCauta.Text = "Caută [CNP]";
            this.textCauta.Enter += new System.EventHandler(this.textCauta_Enter);
            this.textCauta.Leave += new System.EventHandler(this.textCauta_Leave);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSideMenu.BackgroundImage")));
            this.panelSideMenu.Controls.Add(this.cmbAn);
            this.panelSideMenu.Controls.Add(this.textNume);
            this.panelSideMenu.Controls.Add(this.textPrenume);
            this.panelSideMenu.Controls.Add(this.textCNP);
            this.panelSideMenu.Controls.Add(this.textSold);
            this.panelSideMenu.Controls.Add(this.labelAdauga);
            this.panelSideMenu.Controls.Add(this.textPerioadaDep);
            this.panelSideMenu.Controls.Add(this.grpCards);
            this.panelSideMenu.Controls.Add(this.textTelefon);
            this.panelSideMenu.Controls.Add(this.butonAddClient);
            this.panelSideMenu.Controls.Add(this.textEmail);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 527);
            this.panelSideMenu.TabIndex = 0;
            // 
            // cmbAn
            // 
            this.cmbAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbAn.FormattingEnabled = true;
            this.cmbAn.Location = new System.Drawing.Point(47, 424);
            this.cmbAn.Name = "cmbAn";
            this.cmbAn.Size = new System.Drawing.Size(101, 21);
            this.cmbAn.TabIndex = 86;
            this.cmbAn.Text = "Anul nașterii";
            // 
            // textNume
            // 
            this.textNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNume.Location = new System.Drawing.Point(49, 78);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 76;
            this.textNume.Text = "Nume";
            this.textNume.Enter += new System.EventHandler(this.NumeText_Enter);
            this.textNume.Leave += new System.EventHandler(this.NumeText_Leave);
            // 
            // textPrenume
            // 
            this.textPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrenume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPrenume.Location = new System.Drawing.Point(49, 117);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(100, 20);
            this.textPrenume.TabIndex = 77;
            this.textPrenume.Text = "Prenume";
            this.textPrenume.Enter += new System.EventHandler(this.PrenumeText_Enter);
            this.textPrenume.Leave += new System.EventHandler(this.PrenumeText_Leave);
            // 
            // textCNP
            // 
            this.textCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textCNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCNP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCNP.Location = new System.Drawing.Point(49, 158);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(100, 20);
            this.textCNP.TabIndex = 78;
            this.textCNP.Text = "CNP";
            this.textCNP.Enter += new System.EventHandler(this.CNPText_Enter);
            this.textCNP.Leave += new System.EventHandler(this.CNPText_Leave);
            // 
            // textSold
            // 
            this.textSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSold.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textSold.Location = new System.Drawing.Point(49, 198);
            this.textSold.Name = "textSold";
            this.textSold.Size = new System.Drawing.Size(100, 20);
            this.textSold.TabIndex = 79;
            this.textSold.Text = "Sold [LEI]";
            this.textSold.Enter += new System.EventHandler(this.SoldText_Enter);
            this.textSold.Leave += new System.EventHandler(this.SoldText_Leave);
            // 
            // labelAdauga
            // 
            this.labelAdauga.AutoSize = true;
            this.labelAdauga.BackColor = System.Drawing.Color.Transparent;
            this.labelAdauga.ForeColor = System.Drawing.Color.White;
            this.labelAdauga.Location = new System.Drawing.Point(18, 494);
            this.labelAdauga.Name = "labelAdauga";
            this.labelAdauga.Size = new System.Drawing.Size(0, 13);
            this.labelAdauga.TabIndex = 85;
            // 
            // textPerioadaDep
            // 
            this.textPerioadaDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPerioadaDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPerioadaDep.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPerioadaDep.Location = new System.Drawing.Point(49, 237);
            this.textPerioadaDep.Name = "textPerioadaDep";
            this.textPerioadaDep.Size = new System.Drawing.Size(100, 20);
            this.textPerioadaDep.TabIndex = 80;
            this.textPerioadaDep.Text = "Perioada [LUNI]";
            this.textPerioadaDep.Enter += new System.EventHandler(this.PerioadaText_Enter);
            this.textPerioadaDep.Leave += new System.EventHandler(this.PerioadaText_Leave);
            // 
            // grpCards
            // 
            this.grpCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpCards.Controls.Add(this.ckbMasterCard);
            this.grpCards.Controls.Add(this.ckbVISA);
            this.grpCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCards.ForeColor = System.Drawing.Color.DimGray;
            this.grpCards.Location = new System.Drawing.Point(48, 351);
            this.grpCards.Name = "grpCards";
            this.grpCards.Size = new System.Drawing.Size(100, 57);
            this.grpCards.TabIndex = 84;
            this.grpCards.TabStop = false;
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
            this.ckbMasterCard.CheckedChanged += new System.EventHandler(this.ckbCarduri_CheckedChanged);
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
            this.ckbVISA.CheckedChanged += new System.EventHandler(this.ckbCarduri_CheckedChanged);
            // 
            // textTelefon
            // 
            this.textTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textTelefon.Location = new System.Drawing.Point(49, 277);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(100, 20);
            this.textTelefon.TabIndex = 81;
            this.textTelefon.Text = "Telefon [+40]";
            this.textTelefon.Enter += new System.EventHandler(this.TelefonText_Enter);
            this.textTelefon.Leave += new System.EventHandler(this.TelefonText_Leave);
            // 
            // butonAddClient
            // 
            this.butonAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonAddClient.ForeColor = System.Drawing.Color.DimGray;
            this.butonAddClient.Location = new System.Drawing.Point(59, 468);
            this.butonAddClient.Name = "butonAddClient";
            this.butonAddClient.Size = new System.Drawing.Size(75, 23);
            this.butonAddClient.TabIndex = 83;
            this.butonAddClient.Text = "Adauga";
            this.butonAddClient.UseVisualStyleBackColor = false;
            this.butonAddClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonAddClient_MouseClick);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmail.Location = new System.Drawing.Point(49, 316);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 82;
            this.textEmail.Text = "Email";
            this.textEmail.Enter += new System.EventHandler(this.EmailText_Enter);
            this.textEmail.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.închideFereastraToolStripMenuItem,
            this.ascundeMeniulToolStripMenuItem,
            this.afișeazăMeniuliToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(168, 70);
            // 
            // închideFereastraToolStripMenuItem
            // 
            this.închideFereastraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("închideFereastraToolStripMenuItem.Image")));
            this.închideFereastraToolStripMenuItem.Name = "închideFereastraToolStripMenuItem";
            this.închideFereastraToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.închideFereastraToolStripMenuItem.Text = "Închide fereastra";
            this.închideFereastraToolStripMenuItem.Click += new System.EventHandler(this.închideFereastraToolStripMenuItem_Click);
            // 
            // ascundeMeniulToolStripMenuItem
            // 
            this.ascundeMeniulToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ascundeMeniulToolStripMenuItem.Image")));
            this.ascundeMeniulToolStripMenuItem.Name = "ascundeMeniulToolStripMenuItem";
            this.ascundeMeniulToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ascundeMeniulToolStripMenuItem.Text = "Blochează meniul";
            this.ascundeMeniulToolStripMenuItem.Click += new System.EventHandler(this.ascundeMeniulToolStripMenuItem_Click);
            // 
            // afișeazăMeniuliToolStripMenuItem
            // 
            this.afișeazăMeniuliToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("afișeazăMeniuliToolStripMenuItem.Image")));
            this.afișeazăMeniuliToolStripMenuItem.Name = "afișeazăMeniuliToolStripMenuItem";
            this.afișeazăMeniuliToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.afișeazăMeniuliToolStripMenuItem.Text = "Activează meniul";
            this.afișeazăMeniuliToolStripMenuItem.Click += new System.EventHandler(this.afișeazăMeniuliToolStripMenuItem_Click);
            // 
            // bankSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 527);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelTopSide);
            this.Controls.Add(this.panelSideMenu);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Name = "bankSoft";
            this.Text = "bankSoft";
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelTopSide.ResumeLayout(false);
            this.panelTopSide.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.grpCards.ResumeLayout(false);
            this.grpCards.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.TextBox textCNP;
        private System.Windows.Forms.TextBox textSold;
        private System.Windows.Forms.Label labelAdauga;
        private System.Windows.Forms.TextBox textPerioadaDep;
        private System.Windows.Forms.GroupBox grpCards;
        private System.Windows.Forms.CheckBox ckbMasterCard;
        private System.Windows.Forms.CheckBox ckbVISA;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.Button butonAddClient;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Panel panelTopSide;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridClienti;
        private System.Windows.Forms.Button butonCauta;
        private System.Windows.Forms.TextBox textCauta;
        private System.Windows.Forms.ComboBox cmbAn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem închideFereastraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascundeMeniulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afișeazăMeniuliToolStripMenuItem;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.ImageList imageList1;
    }
}

