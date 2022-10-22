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
using Microsoft.VisualBasic;
using DAL.DTO;

namespace MoneyManager
{
    public partial class FrmUpdatePosition : Form
    {
        public FrmUpdatePosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        
        List<TYPESOFEXPANSE> typeOfExpanseList = new List<TYPESOFEXPANSE>();
        List<MONTH> months = new List<MONTH>();
        List<YEAR> years = new List<YEAR>();
        private void FrmUpdatePosition_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (detail.Income_ExpansePosition == "Income")
                {
                    rbIncome.Checked = true;
                    rbExpanse.Checked = false;
                }
                else if (detail.Income_ExpansePosition == "Expanse")
                {
                    rbExpanse.Checked = true;
                    rbIncome.Checked = false;
                }
                else
                {
                    MessageBox.Show("Select type");
                }

                typeOfExpanseList = NewTypeOfExpanseBLL.GetTypesOfExpanse();
                cmbType.DataSource = typeOfExpanseList;
                cmbType.DisplayMember = "TypeOfExpanse";
                cmbType.ValueMember = "ID";
                cmbType.Text = detail.TypeOfExpanse;

                months = MonthsBLL.GetMonths();
                cmbMonth.DataSource = months;
                cmbMonth.DisplayMember = "MonthName";
                cmbMonth.ValueMember = "ID";
                cmbMonth.Text = detail.MonthName;

                years = YearBLL.GetYear();
                cmbYear.DataSource = years;
                cmbYear.DisplayMember = "YearNumber";
                cmbYear.ValueMember = "ID";
                cmbYear.Text = detail.YearNumber.ToString();

                txtValue.Text = Convert.ToString(detail.Amount_of_Expanse);
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

        public bool isUpdate = false;
        public PositionDTO detail = new PositionDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
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
            else if(isUpdate)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    POSITION update = new POSITION();
                    update.ID = detail.ID;
                    update.Amount_of_Expanse = Convert.ToInt32(txtValue.Text);
                    update.TypeOfExpanseID = (int)cmbType.SelectedValue;
                    update.YearID = (int)cmbYear.SelectedValue;
                    update.MonthID = (int)cmbMonth.SelectedValue;
                    update.CreationDate = DateTime.UtcNow;
                    update.UserID = UserStatic.ID;

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
                            update.Income_ExpansePosition = rbExpanse.Text;
                            update.Income_ExpnaseID = 2;
                        }
                    }
                    else if (rbIncome.Checked == true)
                    {
                        string income = "Income";
                        if (CheckIfAlreadyExists(income) == true)
                        {
                            rbIncome.Checked = false;
                            rbExpanse.Checked = true;
                            return;
                        }
                        else if (CheckIfAlreadyExists(income) == false)
                        {
                            update.Income_ExpansePosition = rbIncome.Text;
                            update.Income_ExpnaseID = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Select Type of Balance");
                    }
                    PositionBLL.UpdatePosition(update);
                    MessageBox.Show("Position was updated");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
