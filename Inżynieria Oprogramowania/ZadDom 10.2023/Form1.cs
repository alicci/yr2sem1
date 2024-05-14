using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void buttonZapis_Click(object sender, EventArgs e)
        {
            BazaLaczkaRozlaczka bazaLaczkaRozlaczka = new BazaLaczkaRozlaczka();
            InsertSql insertSql = new InsertSql();
            SQLiteCommand sql_cmd = bazaLaczkaRozlaczka.Polacz();

            string dodajRekord = insertSql.dodajRekord_wszystkie_pola(BazaDanychOpis.BAZADANYCH_TABELA_daneOsobowe, textBoxImieNazwisko.Text, textBoxWiek.Text, textBoxAdres.Text, textBoxKodPocztowy.Text);

            sql_cmd.CommandText = dodajRekord;
            sql_cmd.ExecuteNonQuery();

            bazaLaczkaRozlaczka.Rozlacz();
        }

        private void buttonCzyszczenie_Click(object sender, EventArgs e)
        {
            textBoxImieNazwisko.Clear();
            textBoxWiek.Clear();
            textBoxAdres.Clear();
            textBoxKodPocztowy.Clear();
        }
    }
}
