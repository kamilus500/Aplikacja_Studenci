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
    public partial class UsunStudenta : Form
    {
        private StudenciEntities db = new StudenciEntities();
        private Student student = new Student();
        private DataGridView gridView = new DataGridView();

        public UsunStudenta(DataGridView maindatagrid)
        {
            InitializeComponent();
            gridView = maindatagrid;
        }

        private void Usun_Studenta_Load(object sender, EventArgs e)
        {
            dataGridStudent.DataSource = db.Show_Osoby();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (Helper.IsDatabaseNull() == false)
            {
                int numer = Convert.ToInt32(dataGridStudent.CurrentRow.Index);
                int id = Convert.ToInt32(dataGridStudent.Rows[numer].Cells[0].Value);

                student = db.Students.FirstOrDefault(x => x.id_indeks == id);

                db.Students.Remove(student);
                db.SaveChanges();

                Helper.RefreshDataGrid(dataGridStudent, "student");
                Helper.RefreshDataGrid(gridView, "All");
            }
            else
            {
                MessageBox.Show("Baza jest pusta. Nie można nic usunąć");
            }
        }
    }
}
