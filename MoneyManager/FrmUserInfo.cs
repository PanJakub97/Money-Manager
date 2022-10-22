using BLL;
using DAL;
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
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // wpisac tutaj trzeba userNo jaki jest przypisany do konta  i powinien sie wyswietalc w readonly
        private void FrmUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (txtInitialBalance.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the Initial Balance field.");
            }
            else
            {
                USER user = new USER();
                user.InitialMoney = Convert.ToInt32(txtInitialBalance.Text);
                UserBLL.AddInitialMoney(user);
                MessageBox.Show("Initial Money was added");
                txtInitialBalance.Clear();
            }
        }

        private void txtInitialBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
    }
}
