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
            mainDataGrid.DataSource = null;
            btnInfo.Enabled = false;
            btnStudenci.Enabled = false;
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
                    btnStudenci.Enabled = true;
                    btnInfo.Enabled = true;
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
            btnStudenci.Enabled = false;
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

            Info_Form info_Form = new Info_Form();
            info_Form.ShowDialog();
        }

        private void btnStudenci_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = mainDataGrid;

            Student_Form form = new Student_Form(dataGrid);
            form.ShowDialog();

            Helper.RefreshDataGrid(mainDataGrid,"All");
        }

        private void btnOceny_Click(object sender, EventArgs e)
        {
            Oceny_Form form = new Oceny_Form(mainDataGrid);
            form.ShowDialog();

            Helper.RefreshDataGrid(mainDataGrid,"All");
        }

        private void btnIntruction_Click(object sender, EventArgs e)
        {
            Instruction_Form form = new Instruction_Form();
            form.ShowDialog();
        }

        #endregion
    }
}
