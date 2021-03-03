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
    public partial class OcenyForm : Form
    {
        #region Models

        private StudenciEntities db = new StudenciEntities();
        private Student student;
        private Oceny ocena = new Oceny();
        private DataGridView dataGridView;

        #endregion

        #region Ctor

        public OcenyForm(DataGridView dataGrid)
        {
            InitializeComponent();
            dataGridView = dataGrid;
        }
        private void Oceny_Form_Load(object sender, EventArgs e)
        {
            dataGridOceny.DataSource = db.Show_Osoby();
        }

        #endregion

        #region Functions

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ocena.ocena = Convert.ToInt32(textBox1.Text);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (ocena.ocena > 6 || ocena.ocena < 1)
            {
                MessageBox.Show("Proszę podać ocenę od 1 do 6");
            }
            else
            {
                if (!Helper.IsDatabaseNull())
                {
                    int numer = Convert.ToInt32(dataGridOceny.CurrentRow.Index);
                    int _id_Studenta = Convert.ToInt32(dataGridOceny.Rows[numer].Cells[0].Value);
                    int _id_Oceny = db.Ocenies.Count();

                    student = db.Students.First(x => x.id_indeks == _id_Studenta);

                    ocena.id_indeks = student.id_indeks;
                    ocena.id_oceny = _id_Oceny + 1;
                    student.Ocenies.Add(ocena);

                    db.SaveChanges();
                    this.Close();

                    Helper.RefreshDataGrid(dataGridView, "All");
                }
                else
                {
                    MessageBox.Show("Nie można dodać oceny. Nie ma żadnego studenta w bazie");
                }
            }
        }

        #endregion
    }
}
