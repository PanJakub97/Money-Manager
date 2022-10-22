using BLL;
using DAL;
using DAL.DTO;
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
    public partial class FrmNewPosition : Form
    {
        public FrmNewPosition()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the Value field.");
            }
            else if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Type.");
            }
            else if (cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a month.");
            }

            else if (cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a year.");
            }
            else if (rbExpanse.Checked == false && rbIncome.Checked == false)
            {
                MessageBox.Show("Please select Expanse or Income");
            }
            else
            {
                POSITION position = new POSITION();
                position.Amount_of_Expanse = Convert.ToInt32(txtValue.Text);
                position.TypeOfExpanseID = (int)cmbType.SelectedValue;
                position.YearID = (int)cmbYear.SelectedValue;
                position.MonthID = (int)cmbMonth.SelectedValue;
                position.CreationDate = DateTime.UtcNow;
                position.UserID = UserStatic.ID;

                if (rbExpanse.Checked == true)
                {
                    string expanse = "Expanse";
                    if (CheckIfAlreadyExists(expanse) == true)
                    {
                        rbExpanse.Checked = false;
                        rbIncome.Checked = true;
                        return;
                    }
                    else if (CheckIfAlreadyExists(expanse) == false)
                    {
                        position.Income_ExpansePosition = rbExpanse.Text;
                        position.Income_ExpnaseID = 2;
                    }
                        
                }
                else if (rbIncome.Checked == true)
                {
                    string income = "Income";
                    if (CheckIfAlreadyExists(income) == true)
                    {
                        rbIncome.Checked = false;
                        rbExpanse.Checked=true;
                        return;
                    }
                    else if (CheckIfAlreadyExists(income) == false)
                    {
                        position.Income_ExpansePosition = rbIncome.Text;
                        position.Income_ExpnaseID = 1;
                    }
                        
                }
                else
                {
                    Console.WriteLine("Select Type of Balance");
                }

                    PositionBLL.AddPosition(position);
                    MessageBox.Show("Position was added.");
                    txtValue.Clear();
                    cmbType.SelectedIndex = -1;
                    cmbYear.SelectedIndex = -1;
                    cmbMonth.SelectedIndex = -1;
                    rbIncome.Checked = false;
                    rbExpanse.Checked = false;
            }
        }

        private bool CheckIfAlreadyExists(string Income_Expanse)
        {
            List<PositionDTO> positionList = new List<PositionDTO>();
            positionList = PositionBLL.GetPositions();
            bool exists = false;
            var cmbSelectedValue = cmbType.SelectedItem as TYPESOFEXPANSE;
            foreach (PositionDTO position in positionList)
            {
                if (cmbSelectedValue.TypeOfExpanse == position.TypeOfExpanse)
                {
                    if (position.Income_ExpansePosition != Income_Expanse)
                    {
                        MessageBox.Show("Position with different type already exists. Select another one!");
                        exists = true;
                        break;
                    }
                }
            }
            return exists;
        }

        List<TYPESOFEXPANSE> typeOfExpanseList = new List<TYPESOFEXPANSE>();
        List<MONTH> months = new List<MONTH>();
        List<YEAR> years = new List<YEAR>();
        private void FrmNewPosition_Load(object sender, EventArgs e)
        {
            typeOfExpanseList = NewTypeOfExpanseBLL.GetTypesOfExpanse();
            cmbType.DataSource = typeOfExpanseList;
            cmbType.DisplayMember = "TypeOfExpanse";
            cmbType.ValueMember = "ID";
            cmbType.SelectedIndex = -1;

            months = MonthsBLL.GetMonths();
            cmbMonth.DataSource = months;
            cmbMonth.DisplayMember = "MonthName";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;

            years = YearBLL.GetYear();
            cmbYear.DataSource = years;
            cmbYear.DisplayMember = "YearNumber";
            cmbYear.ValueMember = "ID";
            cmbYear.SelectedIndex = -1;
        }
    }
}
