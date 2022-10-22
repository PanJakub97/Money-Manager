using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;

namespace MoneyManager
{
    public partial class FrmListTypesOfExpanse : Form
    {
        public FrmListTypesOfExpanse()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmNewTypeOfExpanse frm = new FrmNewTypeOfExpanse();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("Plese select a type from table");
            }
            else
            {
                FrmNewTypeOfExpanse frm = new FrmNewTypeOfExpanse();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                FillGrid();
            }
        }

        List<TYPESOFEXPANSE> list = new List<TYPESOFEXPANSE>();
        private void FrmListTypesOfExpanse_Load(object sender, EventArgs e)
        {
            FillGrid();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Type Of Expanse";
        }

        void FillGrid()
        {
            list = NewTypeOfExpanseBLL.GetTypesOfExpanse();
            dataGridView1.DataSource = list;
        }


        
        TypesOfExpansesDTO detail = new TypesOfExpansesDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            detail.TypeOfExpanse = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this position?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NewTypeOfExpanseBLL.DeleteTypeOfExpanse(detail.ID);
                MessageBox.Show("Category was deleted");
                FillGrid();
            }
        }
    }
}
