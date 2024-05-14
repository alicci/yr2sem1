namespace WindowsFormsApp1
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
            this.buttonZapisDb = new System.Windows.Forms.Button();
            this.dataGridViewPomiary = new System.Windows.Forms.DataGridView();
            this.buttonOdswiez = new System.Windows.Forms.Button();
            this.buttonAktualizacja = new System.Windows.Forms.Button();
            this.textBoxIdPomiar = new System.Windows.Forms.TextBox();
            this.textBoxWartosc1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUsun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPomiary)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZapisDb
            // 
            this.buttonZapisDb.Location = new System.Drawing.Point(61, 38);
            this.buttonZapisDb.Name = "buttonZapisDb";
            this.buttonZapisDb.Size = new System.Drawing.Size(151, 46);
            this.buttonZapisDb.TabIndex = 0;
            this.buttonZapisDb.Text = "Zapisz";
            this.buttonZapisDb.UseVisualStyleBackColor = true;
            this.buttonZapisDb.Click += new System.EventHandler(this.buttonZapisDb_Click);
            // 
            // dataGridViewPomiary
            // 
            this.dataGridViewPomiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPomiary.Location = new System.Drawing.Point(61, 106);
            this.dataGridViewPomiary.Name = "dataGridViewPomiary";
            this.dataGridViewPomiary.RowHeadersWidth = 51;
            this.dataGridViewPomiary.RowTemplate.Height = 24;
            this.dataGridViewPomiary.Size = new System.Drawing.Size(723, 365);
            this.dataGridViewPomiary.TabIndex = 1;
            this.dataGridViewPomiary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPomiary_CellClick);
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.Location = new System.Drawing.Point(218, 38);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(151, 46);
            this.buttonOdswiez.TabIndex = 2;
            this.buttonOdswiez.Text = "Odswiez";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            this.buttonOdswiez.Click += new System.EventHandler(this.buttonOdswiez_Click);
            // 
            // buttonAktualizacja
            // 
            this.buttonAktualizacja.Location = new System.Drawing.Point(434, 77);
            this.buttonAktualizacja.Name = "buttonAktualizacja";
            this.buttonAktualizacja.Size = new System.Drawing.Size(75, 23);
            this.buttonAktualizacja.TabIndex = 3;
            this.buttonAktualizacja.Text = "Aktualizuj";
            this.buttonAktualizacja.UseVisualStyleBackColor = true;
            this.buttonAktualizacja.Click += new System.EventHandler(this.buttonAktualizacja_Click);
            // 
            // textBoxIdPomiar
            // 
            this.textBoxIdPomiar.Location = new System.Drawing.Point(417, 38);
            this.textBoxIdPomiar.Name = "textBoxIdPomiar";
            this.textBoxIdPomiar.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdPomiar.TabIndex = 4;
            // 
            // textBoxWartosc1
            // 
            this.textBoxWartosc1.Location = new System.Drawing.Point(577, 37);
            this.textBoxWartosc1.Name = "textBoxWartosc1";
            this.textBoxWartosc1.Size = new System.Drawing.Size(100, 22);
            this.textBoxWartosc1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "id pomiaru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wartosc 1";
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(580, 77);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 8;
            this.buttonUsun.Text = "Usun rekord";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 507);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWartosc1);
            this.Controls.Add(this.textBoxIdPomiar);
            this.Controls.Add(this.buttonAktualizacja);
            this.Controls.Add(this.buttonOdswiez);
            this.Controls.Add(this.dataGridViewPomiary);
            this.Controls.Add(this.buttonZapisDb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPomiary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZapisDb;
        private System.Windows.Forms.DataGridView dataGridViewPomiary;
        private System.Windows.Forms.Button buttonOdswiez;
        private System.Windows.Forms.Button buttonAktualizacja;
        private System.Windows.Forms.TextBox textBoxIdPomiar;
        private System.Windows.Forms.TextBox textBoxWartosc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUsun;
    }
}

