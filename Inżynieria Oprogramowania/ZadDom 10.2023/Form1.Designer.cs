namespace ZadanieDomowe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPodajDane = new System.Windows.Forms.Label();
            this.labelKodPocztowy = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelWiek = new System.Windows.Forms.Label();
            this.labelImieNazwisko = new System.Windows.Forms.Label();
            this.textBoxKodPocztowy = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.textBoxImieNazwisko = new System.Windows.Forms.TextBox();
            this.buttonZapis = new System.Windows.Forms.Button();
            this.buttonCzyszczenie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.buttonCzyszczenie);
            this.panel1.Controls.Add(this.labelPodajDane);
            this.panel1.Controls.Add(this.labelKodPocztowy);
            this.panel1.Controls.Add(this.labelAdres);
            this.panel1.Controls.Add(this.labelWiek);
            this.panel1.Controls.Add(this.labelImieNazwisko);
            this.panel1.Controls.Add(this.textBoxKodPocztowy);
            this.panel1.Controls.Add(this.textBoxAdres);
            this.panel1.Controls.Add(this.textBoxWiek);
            this.panel1.Controls.Add(this.textBoxImieNazwisko);
            this.panel1.Controls.Add(this.buttonZapis);
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 470);
            this.panel1.TabIndex = 5;
            // 
            // labelPodajDane
            // 
            this.labelPodajDane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPodajDane.Location = new System.Drawing.Point(126, 36);
            this.labelPodajDane.Name = "labelPodajDane";
            this.labelPodajDane.Size = new System.Drawing.Size(193, 26);
            this.labelPodajDane.TabIndex = 14;
            this.labelPodajDane.Text = "Podaj swoje dane";
            // 
            // labelKodPocztowy
            // 
            this.labelKodPocztowy.AutoSize = true;
            this.labelKodPocztowy.Location = new System.Drawing.Point(49, 330);
            this.labelKodPocztowy.Name = "labelKodPocztowy";
            this.labelKodPocztowy.Size = new System.Drawing.Size(91, 16);
            this.labelKodPocztowy.TabIndex = 13;
            this.labelKodPocztowy.Text = "Kod Pocztowy";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(70, 256);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(43, 16);
            this.labelAdres.TabIndex = 12;
            this.labelAdres.Text = "Adres";
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(70, 179);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(38, 16);
            this.labelWiek.TabIndex = 11;
            this.labelWiek.Text = "Wiek";
            // 
            // labelImieNazwisko
            // 
            this.labelImieNazwisko.AutoSize = true;
            this.labelImieNazwisko.Location = new System.Drawing.Point(49, 107);
            this.labelImieNazwisko.Name = "labelImieNazwisko";
            this.labelImieNazwisko.Size = new System.Drawing.Size(99, 16);
            this.labelImieNazwisko.TabIndex = 10;
            this.labelImieNazwisko.Text = "Imie i Nazwisko";
            // 
            // textBoxKodPocztowy
            // 
            this.textBoxKodPocztowy.Location = new System.Drawing.Point(165, 330);
            this.textBoxKodPocztowy.Name = "textBoxKodPocztowy";
            this.textBoxKodPocztowy.Size = new System.Drawing.Size(154, 22);
            this.textBoxKodPocztowy.TabIndex = 9;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(165, 256);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(154, 22);
            this.textBoxAdres.TabIndex = 8;
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(166, 179);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(153, 22);
            this.textBoxWiek.TabIndex = 7;
            // 
            // textBoxImieNazwisko
            // 
            this.textBoxImieNazwisko.Location = new System.Drawing.Point(165, 107);
            this.textBoxImieNazwisko.Name = "textBoxImieNazwisko";
            this.textBoxImieNazwisko.Size = new System.Drawing.Size(154, 22);
            this.textBoxImieNazwisko.TabIndex = 6;
            // 
            // buttonZapis
            // 
            this.buttonZapis.Location = new System.Drawing.Point(204, 407);
            this.buttonZapis.Name = "buttonZapis";
            this.buttonZapis.Size = new System.Drawing.Size(150, 30);
            this.buttonZapis.TabIndex = 5;
            this.buttonZapis.Text = "Zapisz do bazy danych";
            this.buttonZapis.UseVisualStyleBackColor = true;
            this.buttonZapis.Click += new System.EventHandler(this.buttonZapis_Click);
            // 
            // buttonCzyszczenie
            // 
            this.buttonCzyszczenie.Location = new System.Drawing.Point(41, 407);
            this.buttonCzyszczenie.Name = "buttonCzyszczenie";
            this.buttonCzyszczenie.Size = new System.Drawing.Size(147, 30);
            this.buttonCzyszczenie.TabIndex = 15;
            this.buttonCzyszczenie.Text = "Zacznij od nowa";
            this.buttonCzyszczenie.UseVisualStyleBackColor = true;
            this.buttonCzyszczenie.Click += new System.EventHandler(this.buttonCzyszczenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 494);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonZapis;
        private System.Windows.Forms.TextBox textBoxKodPocztowy;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.TextBox textBoxImieNazwisko;
        private System.Windows.Forms.Label labelPodajDane;
        private System.Windows.Forms.Label labelKodPocztowy;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.Label labelImieNazwisko;
        private System.Windows.Forms.Button buttonCzyszczenie;
    }
}

