namespace ANKIETA
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.textBoxIMIE = new System.Windows.Forms.TextBox();
            this.textBoxNAZWISKO = new System.Windows.Forms.TextBox();
            this.textBoxANKIETA = new System.Windows.Forms.TextBox();
            this.textBoxODP1 = new System.Windows.Forms.TextBox();
            this.textBoxODP2 = new System.Windows.Forms.TextBox();
            this.labelAnkieta = new System.Windows.Forms.Label();
            this.labelODP1 = new System.Windows.Forms.Label();
            this.labelODP2 = new System.Windows.Forms.Label();
            this.dataGridViewWIDOK = new System.Windows.Forms.DataGridView();
            this.buttonZapisDb = new System.Windows.Forms.Button();
            this.buttonOdswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWIDOK)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(29, 11);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(32, 16);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imie";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(168, 11);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(65, 16);
            this.labelNazwisko.TabIndex = 1;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // textBoxIMIE
            // 
            this.textBoxIMIE.Location = new System.Drawing.Point(33, 34);
            this.textBoxIMIE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIMIE.Name = "textBoxIMIE";
            this.textBoxIMIE.Size = new System.Drawing.Size(100, 22);
            this.textBoxIMIE.TabIndex = 2;
            // 
            // textBoxNAZWISKO
            // 
            this.textBoxNAZWISKO.Location = new System.Drawing.Point(172, 33);
            this.textBoxNAZWISKO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNAZWISKO.Name = "textBoxNAZWISKO";
            this.textBoxNAZWISKO.Size = new System.Drawing.Size(100, 22);
            this.textBoxNAZWISKO.TabIndex = 3;
            // 
            // textBoxANKIETA
            // 
            this.textBoxANKIETA.Location = new System.Drawing.Point(299, 34);
            this.textBoxANKIETA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxANKIETA.Name = "textBoxANKIETA";
            this.textBoxANKIETA.Size = new System.Drawing.Size(100, 22);
            this.textBoxANKIETA.TabIndex = 4;
            // 
            // textBoxODP1
            // 
            this.textBoxODP1.Location = new System.Drawing.Point(449, 34);
            this.textBoxODP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxODP1.Name = "textBoxODP1";
            this.textBoxODP1.Size = new System.Drawing.Size(100, 22);
            this.textBoxODP1.TabIndex = 5;
            // 
            // textBoxODP2
            // 
            this.textBoxODP2.Location = new System.Drawing.Point(588, 34);
            this.textBoxODP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxODP2.Name = "textBoxODP2";
            this.textBoxODP2.Size = new System.Drawing.Size(100, 22);
            this.textBoxODP2.TabIndex = 6;
            // 
            // labelAnkieta
            // 
            this.labelAnkieta.AutoSize = true;
            this.labelAnkieta.Location = new System.Drawing.Point(300, 11);
            this.labelAnkieta.Name = "labelAnkieta";
            this.labelAnkieta.Size = new System.Drawing.Size(93, 16);
            this.labelAnkieta.TabIndex = 7;
            this.labelAnkieta.Text = "Numer ankiety";
            // 
            // labelODP1
            // 
            this.labelODP1.AutoSize = true;
            this.labelODP1.Location = new System.Drawing.Point(445, 11);
            this.labelODP1.Name = "labelODP1";
            this.labelODP1.Size = new System.Drawing.Size(62, 16);
            this.labelODP1.TabIndex = 8;
            this.labelODP1.Text = "Pytanie 1";
            // 
            // labelODP2
            // 
            this.labelODP2.AutoSize = true;
            this.labelODP2.Location = new System.Drawing.Point(584, 11);
            this.labelODP2.Name = "labelODP2";
            this.labelODP2.Size = new System.Drawing.Size(62, 16);
            this.labelODP2.TabIndex = 9;
            this.labelODP2.Text = "Pytanie 2";
            // 
            // dataGridViewWIDOK
            // 
            this.dataGridViewWIDOK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWIDOK.Location = new System.Drawing.Point(13, 131);
            this.dataGridViewWIDOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewWIDOK.Name = "dataGridViewWIDOK";
            this.dataGridViewWIDOK.RowHeadersWidth = 51;
            this.dataGridViewWIDOK.Size = new System.Drawing.Size(774, 306);
            this.dataGridViewWIDOK.TabIndex = 11;
            // 
            // buttonZapisDb
            // 
            this.buttonZapisDb.Location = new System.Drawing.Point(173, 80);
            this.buttonZapisDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZapisDb.Name = "buttonZapisDb";
            this.buttonZapisDb.Size = new System.Drawing.Size(100, 28);
            this.buttonZapisDb.TabIndex = 12;
            this.buttonZapisDb.Text = "Zapisz";
            this.buttonZapisDb.UseVisualStyleBackColor = true;
            this.buttonZapisDb.Click += new System.EventHandler(this.buttonZapisDb_Click);
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.Location = new System.Drawing.Point(327, 80);
            this.buttonOdswiez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(100, 28);
            this.buttonOdswiez.TabIndex = 13;
            this.buttonOdswiez.Text = "Odśwież";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            this.buttonOdswiez.Click += new System.EventHandler(this.buttonOdswiez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOdswiez);
            this.Controls.Add(this.buttonZapisDb);
            this.Controls.Add(this.dataGridViewWIDOK);
            this.Controls.Add(this.labelODP2);
            this.Controls.Add(this.labelODP1);
            this.Controls.Add(this.labelAnkieta);
            this.Controls.Add(this.textBoxODP2);
            this.Controls.Add(this.textBoxODP1);
            this.Controls.Add(this.textBoxANKIETA);
            this.Controls.Add(this.textBoxNAZWISKO);
            this.Controls.Add(this.textBoxIMIE);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWIDOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.TextBox textBoxIMIE;
        private System.Windows.Forms.TextBox textBoxNAZWISKO;
        private System.Windows.Forms.TextBox textBoxANKIETA;
        private System.Windows.Forms.TextBox textBoxODP1;
        private System.Windows.Forms.TextBox textBoxODP2;
        private System.Windows.Forms.Label labelAnkieta;
        private System.Windows.Forms.Label labelODP1;
        private System.Windows.Forms.Label labelODP2;
        private System.Windows.Forms.DataGridView dataGridViewWIDOK;
        private System.Windows.Forms.Button buttonZapisDb;
        private System.Windows.Forms.Button buttonOdswiez;
    }
}

