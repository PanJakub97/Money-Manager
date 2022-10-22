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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your User Number and Password");
            }
            else
            {
                List <USER> userslist = new List<USER>();
                userslist = UserBLL.GetUsers(Convert.ToInt32(txtUserNo.Text), txtPassword.Text);
                if (userslist.Count == 0)
                {
                    MessageBox.Show("Your account doesn't exists");
                }
                else
                {
                    USER users = new USER();
                    users = userslist.First();

                    UserStatic.ID = users.ID;
                    UserStatic.Password = users.Password;
                    UserStatic.InitialMoney = users.InitialMoney;

                    FrmMain frmMain = new FrmMain();
                    this.Hide();
                    frmMain.ShowDialog();
                }
            }
        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
