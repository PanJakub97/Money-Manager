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
    public partial class FrmNewTypeOfExpanse : Form
    {
        public FrmNewTypeOfExpanse()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewTypeOfExpanse.Text.Trim()=="")
            {
                MessageBox.Show("Please fill the Type Of Expanse field.");
            }
            else
            {
                TYPESOFEXPANSE typeOfExpanse = new TYPESOFEXPANSE();
                if (!isUpdate) // adding new positions
                {
                    typeOfExpanse.TypeOfExpanse = txtNewTypeOfExpanse.Text;
                    BLL.NewTypeOfExpanseBLL.AddNewTypeOfExpanse(typeOfExpanse);
                    MessageBox.Show("Type Of Expanse was added");
                    txtNewTypeOfExpanse.Clear();
                }
                else if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) // update
                    {
                        typeOfExpanse.ID = detail.ID;
                        typeOfExpanse.TypeOfExpanse = txtNewTypeOfExpanse.Text;
                        NewTypeOfExpanseBLL.UpdateTypesOfExpanse(typeOfExpanse);
                        MessageBox.Show("Type Of Expanse was updated");
                        this.Close();
                    }
                }
            }
        }
        public bool isUpdate = false;
        public TypesOfExpansesDTO detail = new TypesOfExpansesDTO();
        private void FrmNewTypeOfExpanse_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtNewTypeOfExpanse.Text = detail.TypeOfExpanse;
            }
        }
    }
}
