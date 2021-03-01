using ERP_SERWIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_SERWIS.Helpers
{
    public static class Helper
    {
        private static StudenciEntities db = new StudenciEntities();
        public static void RefreshDataGrid(DataGridView dataGridView,string status)
        {
            
            dataGridView.DataSource = null;
            if(status == "student")
                dataGridView.DataSource = db.Show_Osoby();

            else if(status == "All")
                dataGridView.DataSource = db.Show_All();

            else
                MessageBox.Show("Wystąpił błąd w odświerzaniu danych");

            dataGridView.Refresh();
        }

        public static bool IsDatabaseNull()
        {
            if (db.Students.Count() != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
