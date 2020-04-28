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
            this.butonCauta = new System.Windows.Forms.Button();
            this.labelAdauga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNume
            // 
            this.textNume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNume.Location = new System.Drawing.Point(29, 33);
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
            this.textPrenume.Location = new System.Drawing.Point(29, 73);
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
            this.textSold.Location = new System.Drawing.Point(29, 153);
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
            this.textCNP.Location = new System.Drawing.Point(29, 113);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(100, 20);
            this.textCNP.TabIndex = 2;
            this.textCNP.Text = "CNP";
            this.textCNP.TextChanged += new System.EventHandler(this.textCNP_TextChanged);
            this.textCNP.Enter += new System.EventHandler(this.CNPText_Enter);
            this.textCNP.Leave += new System.EventHandler(this.CNPText_Leave);
            // 
            // textTelefon
            // 
            this.textTelefon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textTelefon.Location = new System.Drawing.Point(29, 232);
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
            this.textPerioadaDep.Location = new System.Drawing.Point(29, 192);
            this.textPerioadaDep.Name = "textPerioadaDep";
            this.textPerioadaDep.Size = new System.Drawing.Size(100, 20);
            this.textPerioadaDep.TabIndex = 4;
            this.textPerioadaDep.Text = "Perioada [LUNI]";
            this.textPerioadaDep.TextChanged += new System.EventHandler(this.textPerioadaDep_TextChanged);
            this.textPerioadaDep.Enter += new System.EventHandler(this.PerioadaText_Enter);
            this.textPerioadaDep.Leave += new System.EventHandler(this.PerioadaText_Leave);
            // 
            // textEmail
            // 
            this.textEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmail.Location = new System.Drawing.Point(29, 271);
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
            this.textCauta.Location = new System.Drawing.Point(263, 33);
            this.textCauta.Name = "textCauta";
            this.textCauta.Size = new System.Drawing.Size(172, 20);
            this.textCauta.TabIndex = 7;
            this.textCauta.Text = "Cauta [CNP]";
            this.textCauta.Enter += new System.EventHandler(this.textCauta_Enter);
            this.textCauta.Leave += new System.EventHandler(this.textCauta_Leave);
            // 
            // RtbAfisare
            // 
            this.RtbAfisare.Location = new System.Drawing.Point(262, 58);
            this.RtbAfisare.Margin = new System.Windows.Forms.Padding(2);
            this.RtbAfisare.Name = "RtbAfisare";
            this.RtbAfisare.Size = new System.Drawing.Size(200, 234);
            this.RtbAfisare.TabIndex = 12;
            this.RtbAfisare.Text = "";
            // 
            // butonAddClient
            // 
            this.butonAddClient.ForeColor = System.Drawing.SystemColors.Desktop;
            this.butonAddClient.Location = new System.Drawing.Point(38, 309);
            this.butonAddClient.Name = "butonAddClient";
            this.butonAddClient.Size = new System.Drawing.Size(75, 23);
            this.butonAddClient.TabIndex = 13;
            this.butonAddClient.Text = "Adauga";
            this.butonAddClient.UseVisualStyleBackColor = true;
            this.butonAddClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonAddClient_MouseClick);
            // 
            // butonCauta
            // 
            this.butonCauta.Image = ((System.Drawing.Image)(resources.GetObject("butonCauta.Image")));
            this.butonCauta.Location = new System.Drawing.Point(437, 33);
            this.butonCauta.Name = "butonCauta";
            this.butonCauta.Size = new System.Drawing.Size(25, 20);
            this.butonCauta.TabIndex = 14;
            this.butonCauta.UseVisualStyleBackColor = true;
            this.butonCauta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonCauta_MouseClick);
            // 
            // labelAdauga
            // 
            this.labelAdauga.AutoSize = true;
            this.labelAdauga.ForeColor = System.Drawing.Color.Red;
            this.labelAdauga.Location = new System.Drawing.Point(119, 314);
            this.labelAdauga.Name = "labelAdauga";
            this.labelAdauga.Size = new System.Drawing.Size(0, 13);
            this.labelAdauga.TabIndex = 15;
            // 
            // bankSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 358);
            this.Controls.Add(this.labelAdauga);
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
            this.Name = "bankSoft";
            this.Text = "bankSoft";
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
        private System.Windows.Forms.Label labelAdauga;
    }
}

