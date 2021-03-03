using ERP_SERWIS.Entities;
using ERP_SERWIS.Forms;
using ERP_SERWIS.Helpers;
using ERP_SERWIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_SERWIS
{
    public partial class MainForm : Form
    {
        #region Models
        public LoginModel loginModel = new LoginModel();

        public StudenciEntities db = new StudenciEntities();

        #endregion

        #region CTOR
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
            mainDataGrid.DataSource = null;
            btnInfo.Enabled = false;
            btnDodaj.Enabled = false;
            btnEdytuj.Enabled = false;
            btnUsun.Enabled = false;
            btnOceny.Enabled = false;
            btnIntruction.Enabled = false;
        }
        #endregion

        #region Logowanie


        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            loginModel.Login = loginBox.Text;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            loginModel.Password = PasswordBox.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginModel.Login != null && loginModel.Password != null)
            {
                if (loginModel.Login == "admin" && loginModel.Password == "Admin")
                {
                    btnOceny.Enabled = true;
                    btnDodaj.Enabled = true;
                    btnInfo.Enabled = true;
                    btnUsun.Enabled = true;
                    btnEdytuj.Enabled = true;
                    btnIntruction.Enabled = true;

                    loginModel.IsLogin = true;
                    StatusBar.Text = "Zalogowany";
                    StatusBar.ForeColor = Color.Green;

                    loginBox.Text = null;
                    PasswordBox.Text = null;

                    mainDataGrid.DataSource = db.Show_All();
                }
                else
                {
                    MessageBox.Show("Podane dane są niepoprawne");
                }
            }
            else
            {
                MessageBox.Show("Proszę wypełnić wymagane pola");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginBox.Text = null;
            PasswordBox.Text = null;
            loginModel.IsLogin = false;

            btnInfo.Enabled = false;
            btnDodaj.Enabled = false;
            btnEdytuj.Enabled = false;
            btnUsun.Enabled = false;
            btnOceny.Enabled = false;
            btnIntruction.Enabled = false;

            mainDataGrid.DataSource = null;
            StatusBar.Text = "Nie zalogowany";
            StatusBar.ForeColor = Color.Black;
        }

        #endregion

        #region Functions

        private void btnInfo_Click(object sender, EventArgs e)
        {

            InfoForm info_Form = new InfoForm();
            info_Form.ShowDialog();
        }

        private void btnOceny_Click(object sender, EventArgs e)
        {
            OcenyForm form = new OcenyForm(mainDataGrid);
            form.ShowDialog();

            Helper.RefreshDataGrid(mainDataGrid,"All");
        }

        private void btnIntruction_Click(object sender, EventArgs e)
        {
            InstructionForm form = new InstructionForm();
            form.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajStudenta add_Form = new DodajStudenta();
            add_Form.ShowDialog();

            Helper.RefreshDataGrid(mainDataGrid, "All");
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            int indeks = Convert.ToInt32(mainDataGrid.CurrentRow.Cells[0].Value);
            EdycjaStudenta edit_Form = new EdycjaStudenta(indeks);
            edit_Form.ShowDialog();

            Helper.RefreshDataGrid(mainDataGrid, "All");
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            UsunStudenta remove_Form = new UsunStudenta(mainDataGrid);
            remove_Form.ShowDialog();

            Helper.RefreshDataGrid(mainDataGrid, "All");
        }


        #endregion
    }
}
