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
    public partial class InstructionForm : Form
    {
        #region Ctor

        public InstructionForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void btnWroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
