using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZADANIE_3.BazaDanych;
using ZADANIE_3.ModelDanych;

namespace ZADANIE_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZapisDb_Click(object sender, EventArgs e)
        {

        }

        BazaDanychObsluga bazaDanychObsluga = new BazaDanychObsluga();

        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            BazaDanychObsluga bazaDanychObsluga = new BazaDanychObsluga();
            var DaneWczytane = from BazaDanychObsluga in bazaDanychObsluga.magazyn_produkty select BazaDanychObsluga;
            dataGridViewPRODUKTY.Rows.Clear();
            dataGridViewPRODUKTY.Columns.Clear();
            dataGridViewPRODUKTY.Columns.Add("id_produktu", "Identyfikator");
            dataGridViewPRODUKTY.Columns.Add("nazwa", "Nazwa");
            dataGridViewPRODUKTY.Columns.Add("jednostka", "Jednostka");
            dataGridViewPRODUKTY.Columns.Add("ilosc", "Ilosc");
            dataGridViewPRODUKTY.Columns.Add("termin_waznosci", "Termin ważności");

            foreach (var kursor in DaneWczytane)
            {
                dataGridViewPRODUKTY.Rows.Add(kursor.id_produktu, kursor.nazwa, kursor.jednostka, kursor.ilosc, kursor.termin_waznosci);
            }
        }

        private void buttonAktualizuj_Click(object sender, EventArgs e)
        {
            using (var daneAktualizacja = new BazaDanychObsluga())
            {
                // Pobierz id_produktu i nową ilość z formularza
                int idProduktu = Int32.Parse(textBoxID_TOW.Text.ToString());
                string nowaIlosc = textBoxILOSC.Text.ToString();

                // Znajdź odpowiedni rekord w bazie danych
                var produktDoAktualizacji = daneAktualizacja.magazyn_produkty
                                              .SingleOrDefault(p => p.id_produktu == idProduktu);

                if (produktDoAktualizacji != null)
                {
                    // Zaktualizuj tylko ilość dla danego rekordu
                    produktDoAktualizacji.ilosc = nowaIlosc;

                    // Zapisz zmiany
                    daneAktualizacja.SaveChanges();
                }
                else
                {
                    // Obsłuż przypadek, gdy nie znaleziono produktu o podanym id_produktu
                    MessageBox.Show("Nie znaleziono produktu o podanym ID.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
