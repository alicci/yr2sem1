using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    class InsertSql
    {
        public string dodajRekord_wszystkie_pola(string nazwaTableli, string imieNazwisko, string wiek, string adres, string kodPocztowy)
        {
            string sqlString = "INSERT INTO " + nazwaTableli + " (" + BazaDanychOpis.DANE_OSOBOWE_imieNazwisko + ", " + BazaDanychOpis.DANE_OSOBOWE_wiek + ", " + BazaDanychOpis.DANE_OSOBOWE_adres + ", " + BazaDanychOpis.DANE_OSOBOWE_kodPocztowy + ") " +
                               "VALUES ('" + imieNazwisko + "', '" + wiek + "', '" + adres + "', '" + kodPocztowy + "');";
            return sqlString;
        }

    }
}
