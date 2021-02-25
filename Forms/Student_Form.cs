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
    public partial class Student_Form : Form  
    {        
        #region Models

        private StudenciEntities db = new StudenciEntities();
        private Student studentEdit = new Student();            //student do edycji
        private Student student = new Student();                //student do dodania
        private DataGridView dataGridView;                      //datagridview z mainform

        #endregion

        #region Ctor

        public Student_Form(DataGridView dataGrid)
        {
            InitializeComponent();
            dataGridView = dataGrid;
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
            dataGridStudent.DataSource = db.Show_Osoby();

            if (db.Students.Count() != 0)
            {
                int _id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

                studentEdit = db.Students.First(x => x.id_indeks == _id);

                txtImieEdit.Text = studentEdit.imie;
                txtEditNazwisko.Text = studentEdit.nazwisko;
                datePickerEdit.Value = studentEdit.data_urodzenia;
            }
            else
            {
                txtImieEdit.Text = string.Empty;
                txtEditNazwisko.Text = string.Empty;
            }
        }

        #endregion

        #region Functions

        #region Dodaj

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            student.Ocenies = null;
            db.Students.Add(student);
            db.SaveChanges();

            Helper.RefreshDataGrid(dataGridView, "student");
            Helper.RefreshDataGrid(dataGridStudent, "student");
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
            int parsedValue;
            if (!int.TryParse(txtIndex.Text, out parsedValue))
            {
                txtIndex.Text = null;
                MessageBox.Show("W polu Numer indeksu można wpisać tylko liczbę");
            }
            else
            {
                student.id_indeks = Convert.ToInt32(txtIndex.Text);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            student.data_urodzenia = dateTimePicker.Value;
        }


        #endregion

        #region Usun

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int _indeks = Convert.ToInt32(dataGridStudent.CurrentRow.Cells[0].Value);
            student = db.Students.First(x => x.id_indeks == _indeks);

            db.Students.Remove(student);
            db.SaveChanges();

            Helper.RefreshDataGrid(dataGridStudent, "student");
            Helper.RefreshDataGrid(dataGridView, "student");
            
        }
        #endregion

        #region Edit

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

            Helper.RefreshDataGrid(dataGridStudent,"student");
        }

        #endregion

        #region Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion

    }
}
