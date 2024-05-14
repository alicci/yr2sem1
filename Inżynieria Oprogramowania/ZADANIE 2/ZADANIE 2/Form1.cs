using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZADANIE_2.BazaDanych;
using ZADANIE_2.ModelDanych;

namespace ZADANIE_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZapisDb_Click(object sender, EventArgs e)
        {
            using (var strukturaDanych = new BazaDanychObsluga())
            {
                strukturaDanych.ksiazka.Add(new ksiazka() { nazwa1 = textBoxNAZWA.Text.ToString(), email = textBoxEMAIL.Text.ToString(), miasto = textBoxMIASTO.Text.ToString() });
                strukturaDanych.SaveChanges();
            }

            textBoxEMAIL.Clear();
            textBoxMIASTO.Clear();
            textBoxNAZWA.Clear();
        }

        BazaDanychObsluga bazaDanychObsluga = new BazaDanychObsluga();

        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            BazaDanychObsluga bazaDanychObsluga = new BazaDanychObsluga();
            var DaneWczytane = from BazaDanychObsluga in bazaDanychObsluga.ksiazka select BazaDanychObsluga;
            dataGridViewWIDOK.Rows.Clear();
            dataGridViewWIDOK.Columns.Clear();
            dataGridViewWIDOK.Columns.Add("id_adresata", "Identyfikator");
            dataGridViewWIDOK.Columns.Add("nazwa1", "Nazwa");
            dataGridViewWIDOK.Columns.Add("email", "Email");
            dataGridViewWIDOK.Columns.Add("miasto", "Miasto");

            foreach (var kursor in DaneWczytane)
            {
                dataGridViewWIDOK.Rows.Add(kursor.id_adresata, kursor.nazwa1, kursor.email, kursor.miasto);
            }

        }
    }
}
