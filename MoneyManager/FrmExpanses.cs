using BLL;
using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;



namespace MoneyManager
{
    public partial class FrmExpanses : Form
    {
        public FrmExpanses()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnNewPositions_Click(object sender, EventArgs e)
        {
            FrmNewPosition frm = new FrmNewPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            FillGrid();
            ResetFilters();
        }

        private void ResetFilters()
        {
            cmbMonth.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbTypeOfExpanse.SelectedIndex = -1;
            txtTotalMonthExpanse.Text = String.Empty;
            txtMonthBalance.Text = String.Empty;
            MakeInviisible(userID);
        }

        private void btnUpdatePositions_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("Please select a position");
            }
            else
            {
                FrmUpdatePosition frmUpdate = new FrmUpdatePosition();
                frmUpdate.isUpdate = true;
                frmUpdate.detail = detail;
                this.Hide();
                frmUpdate.ShowDialog();
                this.Visible = true;
                FillGrid();
                ResetFilters();
            }
        }
        
        void FillGrid()
        {
            positionList = PositionBLL.GetPositions();
            dataGridView1.DataSource = positionList;
            
            if (positionList.Count > 0)
            {
                txtDate.Text = positionList.Last().CreationDate.ToString("dddd, dd MMMM yyyy");
                txtAmount.Text = positionList.Last().Amount_of_Expanse.ToString();
                txtType.Text = positionList.Last().TypeOfExpanse.ToString();
                RowsColor();
                MakeInviisible(userID);
            }
            
        }

        int userID = UserStatic.ID;
        List<MONTH> months = new List<MONTH>();
        List<YEAR> years = new List<YEAR>();
        List<TYPESOFEXPANSE> typeOfExpanseList = new List<TYPESOFEXPANSE>();
        List<PositionDTO> positionList = new List<PositionDTO>();
        private void FrmExpanses_Load(object sender, EventArgs e)
        {
                FillGrid();
                dataGridView1.Columns[0].HeaderText = "Position ID";
                dataGridView1.Columns[1].HeaderText = "Type Of Expanse";
                dataGridView1.Columns[2].HeaderText = "Month";
                dataGridView1.Columns[3].HeaderText = "Amount of Expanse";
                dataGridView1.Columns[4].HeaderText = "Creation Date";
                dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                dataGridView1.Columns[5].HeaderText = "Year";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Width = 170;
                dataGridView1.Columns[13].Visible = false;


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

                typeOfExpanseList = NewTypeOfExpanseBLL.GetTypesOfExpanse();
                cmbTypeOfExpanse.DataSource = typeOfExpanseList;
                cmbTypeOfExpanse.DisplayMember = "TypeOfExpanse";
                cmbTypeOfExpanse.ValueMember = "ID";
                cmbTypeOfExpanse.SelectedIndex = -1;

                RowsColor();

                txtInstruction.Visible = false;  // displaying field with instruction

                MakeInviisible(userID);
        }

        private void MakeInviisible(int userID)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value) != userID)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        public void RowsColor()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[12].Value.ToString() == "Income")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void cmbTypeOfExpanse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DISPLAYING TOTAL MONTH BALANCE
            if (cmbTypeOfExpanse.SelectedIndex == -1)
            {
                txtTotalMonthExpanse.Text = String.Empty;
                txtEpansePerMonth.Text = String.Empty;
                FillGrid();
            }
            else
            {
                // Filter from already filtered positions

                if ((cmbMonth.SelectedIndex != -1 && cmbTypeOfExpanse.SelectedIndex != -1) || (cmbYear.SelectedIndex != -1 && cmbTypeOfExpanse.SelectedIndex != -1))
                {
                    var selectedMonth = cmbMonth.SelectedItem as MONTH;
                    var selectedYear = cmbYear.SelectedItem as YEAR;
                    List<PositionDTO> list = positionList;
                    if (cmbMonth.SelectedIndex != -1 && cmbYear.SelectedIndex != -1)
                    {
                        list = list.Where(x => (x.MonthName == selectedMonth.MonthName) && (x.YearNumber == selectedYear.YearNumber)).ToList();
                    }
                    else if (cmbYear.SelectedIndex != -1)
                    {
                        list = list.Where(y => y.YearNumber == selectedYear.YearNumber).ToList();
                    }
                    else if (cmbMonth.SelectedIndex != -1)
                    {
                        list = list.Where(m => m.MonthName == selectedMonth.MonthName).ToList();
                    }


                    // filtering from already filtered list
                    var selectedTypeOfExpanse = cmbTypeOfExpanse.SelectedItem as TYPESOFEXPANSE;
                    List<PositionDTO> listTypeOfExpanse = list;
                    if (cmbTypeOfExpanse.SelectedIndex != -1)
                    {
                        listTypeOfExpanse = listTypeOfExpanse.Where(t => t.TypeOfExpanse == selectedTypeOfExpanse.TypeOfExpanse).ToList();
                    }
                    dataGridView1.DataSource = listTypeOfExpanse;
                    CalculateBalance(dataGridView1);
                    
                    txtMonthBalance.Text = string.Empty;
                }
                //Filter from all positions
                else
                {
                    var selectedTypeOfExpanse = cmbTypeOfExpanse.SelectedItem as TYPESOFEXPANSE;
                    List<PositionDTO> listTypeOfExpanse = positionList;
                    if (cmbTypeOfExpanse.SelectedIndex != -1)
                    {
                        listTypeOfExpanse = listTypeOfExpanse.Where(t => t.TypeOfExpanse == selectedTypeOfExpanse.TypeOfExpanse).ToList();
                    }

                    dataGridView1.DataSource = listTypeOfExpanse;

                    CalculateBalance(dataGridView1);
                    txtEpansePerMonth.Text = CalculateBalance(dataGridView1).Item1;



                    txtMonthBalance.Text = string.Empty;
                }
                txtEpansePerMonth.Text = CalculateBalance(dataGridView1).Item2;
            }
            RowsColor();
            MakeInviisible(userID);
            
        }

        public Tuple<string,string> CalculateBalance(DataGridView dataGridView)
        {
            try
            {
                decimal sum = 0;
                decimal numberOfMonths = 12;
                decimal average = 0;
                decimal round = 0;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value) == UserStatic.ID)
                    {
                        decimal rowValue = 0;
                        if (dataGridView.Rows[i].Cells[3].Value != null)
                            decimal.TryParse(dataGridView.Rows[i].Cells[3].Value.ToString(), out rowValue);
                        sum += rowValue;
                        average = sum / numberOfMonths;
                        round = Math.Round(average, 2);
                    }
                }
                return Tuple.Create(txtTotalMonthExpanse.Text = sum.ToString(),Convert.ToString(round));
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var selectedMonth = cmbMonth.SelectedItem as MONTH;
            var selectedYear = cmbYear.SelectedItem as YEAR;
            List<PositionDTO> list = positionList;
            if (cmbMonth.SelectedIndex != -1 && cmbYear.SelectedIndex != -1)
            {
                list = list.Where(x => (x.MonthName == selectedMonth.MonthName) && (x.YearNumber == selectedYear.YearNumber)).ToList();

                // If both filters are turned on - calculate month balance
                dataGridView1.DataSource = list;
                CalculateMonthBalance(dataGridView1);

            }
            else if (cmbYear.SelectedIndex != -1)
            {
                list = list.Where(y => y.YearNumber == selectedYear.YearNumber).ToList();
            }
            else if (cmbMonth.SelectedIndex != -1)
            {
                list = list.Where(m => m.MonthName == selectedMonth.MonthName).ToList();
            }
            dataGridView1.DataSource = list;

            txtTotalMonthExpanse.Text = String.Empty;
            cmbTypeOfExpanse.SelectedIndex = -1;
            RowsColor();
            MakeInviisible(userID);
        }

        private string CalculateMonthBalance(DataGridView dataGridView)
        {
            try
            {
                decimal sum = 0;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value) == UserStatic.ID)
                    {
                        decimal rowValue = 0;
                        if (dataGridView.Rows[i].Cells[3].Value != null && dataGridView.Rows[i].Cells[12].Value.ToString() == "Income")
                        {
                            decimal.TryParse(dataGridView.Rows[i].Cells[3].Value.ToString(), out rowValue);
                            rowValue = rowValue;
                        }
                        else if (dataGridView.Rows[i].Cells[3].Value != null && dataGridView.Rows[i].Cells[12].Value.ToString() == "Expanse")
                        {
                            decimal.TryParse(dataGridView.Rows[i].Cells[3].Value.ToString(), out rowValue);
                            rowValue = -rowValue;
                        }
                        else
                        {
                            txtMonthBalance.Text = "Something went wrong";
                        }

                        sum += rowValue;
                    }
                }
                return txtMonthBalance.Text = sum.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMonth.SelectedIndex != -1)
                {
                    cmbMonth.SelectedIndex = -1;
                    FillGrid();

                }
                else if (cmbYear.SelectedIndex != -1)
                {
                    cmbYear.SelectedIndex = -1;
                    FillGrid();
                }
                else if (cmbTypeOfExpanse.SelectedIndex != -1)
                {
                    cmbTypeOfExpanse.SelectedIndex = -1;
                    FillGrid();
                }
                cmbTypeOfExpanse.SelectedIndex = -1;
                cmbYear.SelectedIndex = -1;
                cmbMonth.SelectedIndex = -1;
                txtMonthBalance.Text = String.Empty;
                FillGrid();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtMonthBalance_MouseClick(object sender, MouseEventArgs e)
        {
        }

        

        private void txtMonthBalance_MouseMove(object sender, MouseEventArgs e)
        {
            //jeśli jest puste i sie najedzie to 
            if (!(txtMonthBalance.Text != string.Empty))
            {
                txtInstruction.Visible = true;
                txtInstruction.Text = "Select month and year filter to get a balance";
               
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            txtInstruction.Hide();
        }

        int selectedRowIndex;
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }


        PositionDTO detail = new PositionDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // those data are related to POSITIONDTO (NUMBERING/CELLS)
            detail.ID = ((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.TypeOfExpanse = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            detail.Income_ExpansePosition = (string)dataGridView1.Rows[e.RowIndex].Cells[12].Value;
            detail.MonthName = (string)(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.YearNumber = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.Amount_of_Expanse = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this position?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PositionBLL.DeletePosition(detail.ID);
                MessageBox.Show("Position was deleted");
                FillGrid();
                ResetFilters();
            }
        }
    }
}
