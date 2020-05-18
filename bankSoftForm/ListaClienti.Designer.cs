namespace bankSoftForm
{
    partial class ListaClienti
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
            this.lstClienti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstClienti
            // 
            this.lstClienti.FormattingEnabled = true;
            this.lstClienti.Location = new System.Drawing.Point(13, 13);
            this.lstClienti.Name = "lstClienti";
            this.lstClienti.Size = new System.Drawing.Size(1143, 251);
            this.lstClienti.TabIndex = 0;
            // 
            // ListaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 273);
            this.Controls.Add(this.lstClienti);
            this.Name = "ListaClienti";
            this.Text = "ListaClienti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstClienti;
    }
}