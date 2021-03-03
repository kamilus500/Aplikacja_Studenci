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
    public partial class DodajStudenta : Form
    {
        private StudenciEntities db = new StudenciEntities();
        private Student student = new Student();
        private DataGridView dataGridView = new DataGridView();
        public DodajStudenta()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            student.imie = txtImie.Text;
            student.nazwisko = txtNazwisko.Text;
            student.id_indeks = Convert.ToInt32(txtIndex.Text);
            student.data_urodzenia = dateTimePicker.Value;
            student.Ocenies = null;
            db.Students.Add(student);
            db.SaveChanges();

            Helper.RefreshDataGrid(dataGridView, "All");

            this.Close();
        }
    }
}
