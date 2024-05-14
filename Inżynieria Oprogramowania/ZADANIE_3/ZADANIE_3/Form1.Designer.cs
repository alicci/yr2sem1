namespace ZADANIE_3
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
            this.buttonOdswiez = new System.Windows.Forms.Button();
            this.buttonAktualizuj = new System.Windows.Forms.Button();
            this.textBoxID_TOW = new System.Windows.Forms.TextBox();
            this.textBoxILOSC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPRODUKTY = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUKTY)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZapisDb
            // 
            this.buttonZapisDb.Location = new System.Drawing.Point(33, 26);
            this.buttonZapisDb.Name = "buttonZapisDb";
            this.buttonZapisDb.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisDb.TabIndex = 0;
            this.buttonZapisDb.Text = "Zapisz";
            this.buttonZapisDb.UseVisualStyleBackColor = true;
            this.buttonZapisDb.Click += new System.EventHandler(this.buttonZapisDb_Click);
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.Location = new System.Drawing.Point(138, 25);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(75, 23);
            this.buttonOdswiez.TabIndex = 1;
            this.buttonOdswiez.Text = "Odśwież";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            this.buttonOdswiez.Click += new System.EventHandler(this.buttonOdswiez_Click);
            // 
            // buttonAktualizuj
            // 
            this.buttonAktualizuj.Location = new System.Drawing.Point(249, 25);
            this.buttonAktualizuj.Name = "buttonAktualizuj";
            this.buttonAktualizuj.Size = new System.Drawing.Size(75, 23);
            this.buttonAktualizuj.TabIndex = 2;
            this.buttonAktualizuj.Text = "Aktualizuj";
            this.buttonAktualizuj.UseVisualStyleBackColor = true;
            this.buttonAktualizuj.Click += new System.EventHandler(this.buttonAktualizuj_Click);
            // 
            // textBoxID_TOW
            // 
            this.textBoxID_TOW.Location = new System.Drawing.Point(360, 28);
            this.textBoxID_TOW.Name = "textBoxID_TOW";
            this.textBoxID_TOW.Size = new System.Drawing.Size(100, 20);
            this.textBoxID_TOW.TabIndex = 3;
            // 
            // textBoxILOSC
            // 
            this.textBoxILOSC.Location = new System.Drawing.Point(497, 28);
            this.textBoxILOSC.Name = "textBoxILOSC";
            this.textBoxILOSC.Size = new System.Drawing.Size(100, 20);
            this.textBoxILOSC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID towaru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ilość";
            // 
            // dataGridViewPRODUKTY
            // 
            this.dataGridViewPRODUKTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRODUKTY.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewPRODUKTY.Name = "dataGridViewPRODUKTY";
            this.dataGridViewPRODUKTY.Size = new System.Drawing.Size(680, 356);
            this.dataGridViewPRODUKTY.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPRODUKTY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxILOSC);
            this.Controls.Add(this.textBoxID_TOW);
            this.Controls.Add(this.buttonAktualizuj);
            this.Controls.Add(this.buttonOdswiez);
            this.Controls.Add(this.buttonZapisDb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUKTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZapisDb;
        private System.Windows.Forms.Button buttonOdswiez;
        private System.Windows.Forms.Button buttonAktualizuj;
        private System.Windows.Forms.TextBox textBoxID_TOW;
        private System.Windows.Forms.TextBox textBoxILOSC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPRODUKTY;
    }
}

