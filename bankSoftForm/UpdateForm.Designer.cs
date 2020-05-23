namespace bankSoftForm
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.cmbAnUpdate = new System.Windows.Forms.ComboBox();
            this.grpCardsUpdate = new System.Windows.Forms.GroupBox();
            this.ckbMasterCard = new System.Windows.Forms.CheckBox();
            this.ckbVISA = new System.Windows.Forms.CheckBox();
            this.textTelefonUpdate = new System.Windows.Forms.TextBox();
            this.textEmailUpdate = new System.Windows.Forms.TextBox();
            this.textNumeUpdate = new System.Windows.Forms.TextBox();
            this.textPrenumeUpdate = new System.Windows.Forms.TextBox();
            this.textCNPUpdate = new System.Windows.Forms.TextBox();
            this.textSoldUpdate = new System.Windows.Forms.TextBox();
            this.textPerioadaDepUpdate = new System.Windows.Forms.TextBox();
            this.butonUpdateClient = new System.Windows.Forms.Button();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.panelUpdate.SuspendLayout();
            this.grpCardsUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpdate
            // 
            this.panelUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUpdate.BackgroundImage")));
            this.panelUpdate.Controls.Add(this.labelUpdate);
            this.panelUpdate.Controls.Add(this.butonUpdateClient);
            this.panelUpdate.Controls.Add(this.cmbAnUpdate);
            this.panelUpdate.Controls.Add(this.grpCardsUpdate);
            this.panelUpdate.Controls.Add(this.textTelefonUpdate);
            this.panelUpdate.Controls.Add(this.textEmailUpdate);
            this.panelUpdate.Controls.Add(this.textNumeUpdate);
            this.panelUpdate.Controls.Add(this.textPrenumeUpdate);
            this.panelUpdate.Controls.Add(this.textCNPUpdate);
            this.panelUpdate.Controls.Add(this.textSoldUpdate);
            this.panelUpdate.Controls.Add(this.textPerioadaDepUpdate);
            this.panelUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpdate.Location = new System.Drawing.Point(0, 0);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(333, 348);
            this.panelUpdate.TabIndex = 0;
            // 
            // cmbAnUpdate
            // 
            this.cmbAnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbAnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbAnUpdate.FormattingEnabled = true;
            this.cmbAnUpdate.Location = new System.Drawing.Point(185, 198);
            this.cmbAnUpdate.Name = "cmbAnUpdate";
            this.cmbAnUpdate.Size = new System.Drawing.Size(101, 21);
            this.cmbAnUpdate.TabIndex = 90;
            this.cmbAnUpdate.Text = "Anul nașterii";
            // 
            // grpCardsUpdate
            // 
            this.grpCardsUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpCardsUpdate.Controls.Add(this.ckbMasterCard);
            this.grpCardsUpdate.Controls.Add(this.ckbVISA);
            this.grpCardsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCardsUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.grpCardsUpdate.Location = new System.Drawing.Point(184, 119);
            this.grpCardsUpdate.Name = "grpCardsUpdate";
            this.grpCardsUpdate.Size = new System.Drawing.Size(102, 60);
            this.grpCardsUpdate.TabIndex = 89;
            this.grpCardsUpdate.TabStop = false;
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
            // textTelefonUpdate
            // 
            this.textTelefonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textTelefonUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefonUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textTelefonUpdate.Location = new System.Drawing.Point(184, 39);
            this.textTelefonUpdate.Name = "textTelefonUpdate";
            this.textTelefonUpdate.Size = new System.Drawing.Size(100, 20);
            this.textTelefonUpdate.TabIndex = 87;
            this.textTelefonUpdate.Text = "Telefon [+40]";
            this.textTelefonUpdate.Enter += new System.EventHandler(this.TelefonTextUpdate_Enter);
            this.textTelefonUpdate.Leave += new System.EventHandler(this.TelefonTextUpdate_Leave);
            // 
            // textEmailUpdate
            // 
            this.textEmailUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEmailUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmailUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmailUpdate.Location = new System.Drawing.Point(184, 78);
            this.textEmailUpdate.Name = "textEmailUpdate";
            this.textEmailUpdate.Size = new System.Drawing.Size(100, 20);
            this.textEmailUpdate.TabIndex = 88;
            this.textEmailUpdate.Text = "Email";
            this.textEmailUpdate.Enter += new System.EventHandler(this.EmailTextUpdate_Enter);
            this.textEmailUpdate.Leave += new System.EventHandler(this.EmailTextUpdate_Leave);
            // 
            // textNumeUpdate
            // 
            this.textNumeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textNumeUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumeUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNumeUpdate.Location = new System.Drawing.Point(35, 39);
            this.textNumeUpdate.Name = "textNumeUpdate";
            this.textNumeUpdate.Size = new System.Drawing.Size(100, 20);
            this.textNumeUpdate.TabIndex = 81;
            this.textNumeUpdate.Text = "Nume";
            this.textNumeUpdate.Enter += new System.EventHandler(this.NumeTextUpdate_Enter);
            this.textNumeUpdate.Leave += new System.EventHandler(this.NumeTextUpdate_Leave);
            // 
            // textPrenumeUpdate
            // 
            this.textPrenumeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPrenumeUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrenumeUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPrenumeUpdate.Location = new System.Drawing.Point(35, 78);
            this.textPrenumeUpdate.Name = "textPrenumeUpdate";
            this.textPrenumeUpdate.Size = new System.Drawing.Size(100, 20);
            this.textPrenumeUpdate.TabIndex = 82;
            this.textPrenumeUpdate.Text = "Prenume";
            this.textPrenumeUpdate.Enter += new System.EventHandler(this.PrenumeTextUpdate_Enter);
            this.textPrenumeUpdate.Leave += new System.EventHandler(this.PrenumeTextUpdate_Leave);
            // 
            // textCNPUpdate
            // 
            this.textCNPUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textCNPUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCNPUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCNPUpdate.Location = new System.Drawing.Point(35, 119);
            this.textCNPUpdate.Name = "textCNPUpdate";
            this.textCNPUpdate.Size = new System.Drawing.Size(100, 20);
            this.textCNPUpdate.TabIndex = 83;
            this.textCNPUpdate.Text = "CNP";
            this.textCNPUpdate.Enter += new System.EventHandler(this.CNPTextUpdate_Enter);
            this.textCNPUpdate.Leave += new System.EventHandler(this.CNPTextUpdate_Leave);
            // 
            // textSoldUpdate
            // 
            this.textSoldUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textSoldUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSoldUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textSoldUpdate.Location = new System.Drawing.Point(35, 159);
            this.textSoldUpdate.Name = "textSoldUpdate";
            this.textSoldUpdate.Size = new System.Drawing.Size(100, 20);
            this.textSoldUpdate.TabIndex = 84;
            this.textSoldUpdate.Text = "Sold [LEI]";
            this.textSoldUpdate.Enter += new System.EventHandler(this.SoldTextUpdate_Enter);
            this.textSoldUpdate.Leave += new System.EventHandler(this.SoldTextUpdate_Leave);
            // 
            // textPerioadaDepUpdate
            // 
            this.textPerioadaDepUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPerioadaDepUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPerioadaDepUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPerioadaDepUpdate.Location = new System.Drawing.Point(35, 198);
            this.textPerioadaDepUpdate.Name = "textPerioadaDepUpdate";
            this.textPerioadaDepUpdate.Size = new System.Drawing.Size(100, 20);
            this.textPerioadaDepUpdate.TabIndex = 85;
            this.textPerioadaDepUpdate.Text = "Perioada [LUNI]";
            this.textPerioadaDepUpdate.Enter += new System.EventHandler(this.PerioadaTextUpdate_Enter);
            this.textPerioadaDepUpdate.Leave += new System.EventHandler(this.PerioadaTextUpdate_Leave);
            // 
            // butonUpdateClient
            // 
            this.butonUpdateClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butonUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonUpdateClient.ForeColor = System.Drawing.Color.DimGray;
            this.butonUpdateClient.Location = new System.Drawing.Point(106, 261);
            this.butonUpdateClient.Name = "butonUpdateClient";
            this.butonUpdateClient.Size = new System.Drawing.Size(105, 40);
            this.butonUpdateClient.TabIndex = 91;
            this.butonUpdateClient.Text = "Modifica";
            this.butonUpdateClient.UseVisualStyleBackColor = false;
            this.butonUpdateClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonUpdateClient_MouseClick);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUpdate.Location = new System.Drawing.Point(75, 308);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(0, 13);
            this.labelUpdate.TabIndex = 92;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 348);
            this.Controls.Add(this.panelUpdate);
            this.Name = "UpdateForm";
            this.Text = "Form2";
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.grpCardsUpdate.ResumeLayout(false);
            this.grpCardsUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.CheckBox ckbMasterCard;
        private System.Windows.Forms.CheckBox ckbVISA;
        private System.Windows.Forms.Button butonUpdateClient;
        public System.Windows.Forms.TextBox textNumeUpdate;
        public System.Windows.Forms.TextBox textPrenumeUpdate;
        public System.Windows.Forms.TextBox textCNPUpdate;
        public System.Windows.Forms.TextBox textSoldUpdate;
        public System.Windows.Forms.TextBox textPerioadaDepUpdate;
        public System.Windows.Forms.ComboBox cmbAnUpdate;
        public System.Windows.Forms.GroupBox grpCardsUpdate;
        public System.Windows.Forms.TextBox textTelefonUpdate;
        public System.Windows.Forms.TextBox textEmailUpdate;
        private System.Windows.Forms.Label labelUpdate;
    }
}