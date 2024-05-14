using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANKIETA.BazaDanych;
using ANKIETA.ModelDanych;

namespace ANKIETA
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

        private void buttonZapisDb_Click(object sender, EventArgs e)
        {
            using (var strukturaDanych = new BazaDanychObsluga())
            {
                strukturaDanych.Osoby.Add(new Osoby() { imie = textBoxIMIE.Text.ToString(), nazwisko = textBoxNAZWISKO.Text.ToString(), numer_ankiety = textBoxANKIETA.Text.ToString(), odp_1 = textBoxODP1.Text.ToString(), odp_2 = textBoxODP2.Text.ToString() });
                strukturaDanych.SaveChanges();
            }
        }

        BazaDanychObsluga bazaDanychObsluga = new BazaDanychObsluga();

        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            BazaDanychObsluga bazaDanychObsluga = new BazaDanychObsluga();
            var DaneWczytane = from BazaDanychObsluga in bazaDanychObsluga.Osoby select BazaDanychObsluga;
            dataGridViewWIDOK.Rows.Clear();
            dataGridViewWIDOK.Columns.Clear();
            dataGridViewWIDOK.Columns.Add("id_osoby", "Identyfikator");
            dataGridViewWIDOK.Columns.Add("imie", "Imie");
            dataGridViewWIDOK.Columns.Add("nazwisko", "Nazwisko");
            dataGridViewWIDOK.Columns.Add("numer_ankiety", "Numer ankiety");
            dataGridViewWIDOK.Columns.Add("odp_1", "ODP 1");
            dataGridViewWIDOK.Columns.Add("odp_2", "ODP 2");

            foreach (var kursor in DaneWczytane)
            {
                dataGridViewWIDOK.Rows.Add(kursor.id_osoby, kursor.imie, kursor.nazwisko, kursor.numer_ankiety, kursor.odp_1, kursor.odp_2);
            }
        }
    }
}
