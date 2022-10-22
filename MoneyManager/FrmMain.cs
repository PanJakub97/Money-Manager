using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpanses_Click(object sender, EventArgs e)
        {
            FrmExpanses frmExpanses = new FrmExpanses();
            this.Hide();
            frmExpanses.ShowDialog();
            this.Visible = true;
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            FrmCharts frmCharts = new FrmCharts();
            this.Hide();
            frmCharts.ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            FrmUserInfo frmUserInfo = new FrmUserInfo();
            this.Hide();
            frmUserInfo.ShowDialog();
            this.Visible = true;
        }

        private void btnNewPosition_Click(object sender, EventArgs e)
        {
            FrmNewPosition frmNewPosition = new FrmNewPosition();
            this.Hide();
            frmNewPosition.ShowDialog();
            this.Visible = true;
        }

        private void btnNewTypeOfExpanse_Click(object sender, EventArgs e)
        {
            FrmNewTypeOfExpanse frmNewTypeOfExpanse = new FrmNewTypeOfExpanse();
            this.Hide();
            frmNewTypeOfExpanse.ShowDialog();
            this.Visible = true;
        }

        private void btnListTypesOfExpanse_Click(object sender, EventArgs e)
        {
            FrmListTypesOfExpanse frm = new FrmListTypesOfExpanse();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }
    }
}
 