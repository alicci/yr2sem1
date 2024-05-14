namespace ZADANIE_2
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
            this.textBoxNAZWA = new System.Windows.Forms.TextBox();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxMIASTO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewWIDOK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWIDOK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZapisDb
            // 
            this.buttonZapisDb.Location = new System.Drawing.Point(26, 31);
            this.buttonZapisDb.Name = "buttonZapisDb";
            this.buttonZapisDb.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisDb.TabIndex = 0;
            this.buttonZapisDb.Text = "Zapisz";
            this.buttonZapisDb.UseVisualStyleBackColor = true;
            this.buttonZapisDb.Click += new System.EventHandler(this.buttonZapisDb_Click);
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.Location = new System.Drawing.Point(125, 30);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(75, 23);
            this.buttonOdswiez.TabIndex = 1;
            this.buttonOdswiez.Text = "Odśwież";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            this.buttonOdswiez.Click += new System.EventHandler(this.buttonOdswiez_Click);
            // 
            // textBoxNAZWA
            // 
            this.textBoxNAZWA.Location = new System.Drawing.Point(264, 33);
            this.textBoxNAZWA.Name = "textBoxNAZWA";
            this.textBoxNAZWA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNAZWA.TabIndex = 2;
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(394, 33);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(100, 20);
            this.textBoxEMAIL.TabIndex = 3;
            // 
            // textBoxMIASTO
            // 
            this.textBoxMIASTO.Location = new System.Drawing.Point(528, 33);
            this.textBoxMIASTO.Name = "textBoxMIASTO";
            this.textBoxMIASTO.Size = new System.Drawing.Size(100, 20);
            this.textBoxMIASTO.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Miasto";
            // 
            // dataGridViewWIDOK
            // 
            this.dataGridViewWIDOK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWIDOK.Location = new System.Drawing.Point(26, 72);
            this.dataGridViewWIDOK.Name = "dataGridViewWIDOK";
            this.dataGridViewWIDOK.Size = new System.Drawing.Size(708, 366);
            this.dataGridViewWIDOK.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewWIDOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMIASTO);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.textBoxNAZWA);
            this.Controls.Add(this.buttonOdswiez);
            this.Controls.Add(this.buttonZapisDb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWIDOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZapisDb;
        private System.Windows.Forms.Button buttonOdswiez;
        private System.Windows.Forms.TextBox textBoxNAZWA;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxMIASTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewWIDOK;
    }
}

