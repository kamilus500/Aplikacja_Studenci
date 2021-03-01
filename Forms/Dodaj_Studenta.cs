using ERP_SERWIS.Entities;
using ERP_SERWIS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_SERWIS.Forms
{
    public partial class Dodaj_Studenta : Form
    {
        private StudenciEntities db = new StudenciEntities();
        private Student student = new Student();
        private DataGridView dataGridView = new DataGridView();
        public Dodaj_Studenta()
        {
            InitializeComponent();
        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {
            student.imie = txtImie.Text;
        }

        private void txtNazwisko_TextChanged(object sender, EventArgs e)
        {
            student.nazwisko = txtNazwisko.Text;
        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            student.id_indeks = Convert.ToInt32(txtIndex.Text);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            student.data_urodzenia = dateTimePicker.Value;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            student.Ocenies = null;
            db.Students.Add(student);
            db.SaveChanges();

            Helper.RefreshDataGrid(dataGridView, "All");

            this.Close();
        }
    }
}
