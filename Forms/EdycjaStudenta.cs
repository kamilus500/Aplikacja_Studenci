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
    public partial class EdycjaStudenta : Form
    {
        private StudenciEntities db = new StudenciEntities();
        private Student student = new Student();

        public EdycjaStudenta(int indeks)
        {
            InitializeComponent();
            student = db.Students.First(x => x.id_indeks == indeks);
        }

        private void Edycja_Studenta_Load(object sender, EventArgs e)
        {
            txtImieEdit.Text = student.imie;
            txtEditNazwisko.Text = student.nazwisko;
            datePickerEdit.Value = student.data_urodzenia;
        }

        private void txtImieEdit_TextChanged(object sender, EventArgs e)
        {
            student.imie = txtImieEdit.Text;
        }

        private void txtEditNazwisko_TextChanged(object sender, EventArgs e)
        {
            student.nazwisko = txtEditNazwisko.Text;
        }

        private void datePickerEdit_ValueChanged(object sender, EventArgs e)
        {
            student.data_urodzenia = datePickerEdit.Value;
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            this.Close();

        }

    }
}
