using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BazaDanych;
using WindowsFormsApp1.ModelDanych;

namespace WindowsFormsApp1
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
                strukturaDanych.pomiar.Add(new pomiar() { wartosc1 = "123", wartosc2 = "98", wartosc3 = "101" });
                strukturaDanych.SaveChanges();
            }
        }

        BazaDanychObsluga bazaDanychObsluga = new BazaDanychObsluga();
        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            BazaDanychObsluga bazaDanychObsluga = new BazaDanychObsluga();
            var DaneWczytane = from BazaDanychObsluga in bazaDanychObsluga.pomiar select BazaDanychObsluga;

            dataGridViewPomiary.Rows.Clear();
            dataGridViewPomiary.Columns.Clear();
            dataGridViewPomiary.Columns.Add("pomiarId", "Identyfikator");
            dataGridViewPomiary.Columns.Add("wartosc1", "Pomiar 1");
            dataGridViewPomiary.Columns.Add("wartosc2", "Pomiar 2");
            dataGridViewPomiary.Columns.Add("wartosc3", "Pomiar 3");

            foreach (var kursor in DaneWczytane)
            {
                dataGridViewPomiary.Rows.Add(kursor.pomiarId, kursor.wartosc1, kursor.wartosc2, kursor.wartosc3);
            }
        }

        private void buttonAktualizacja_Click(object sender, EventArgs e)
        {
            using (var daneAktualizacja = new BazaDanychObsluga())
            {
                int idSensor = Int32.Parse(textBoxIdPomiar.Text.ToString());
                pomiar _pomiar = new pomiar() { pomiarId = idSensor, wartosc1 = textBoxWartosc1.Text.ToString() };
                daneAktualizacja.Entry(_pomiar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                daneAktualizacja.SaveChanges();
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            using (var daneAktualizacja = new BazaDanychObsluga())
            {
                int idSensor = Int32.Parse(textBoxIdPomiar.Text.ToString());
                pomiar _pomiar = new pomiar() { pomiarId = idSensor };
                daneAktualizacja.Entry(_pomiar).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                daneAktualizacja.SaveChanges();
            }
        }

        private void dataGridViewPomiary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string wybraneIdPomiar = dataGridViewPomiary.CurrentCell.Value.ToString();
            textBoxIdPomiar.Text = wybraneIdPomiar.ToString();
        }
    }
}
