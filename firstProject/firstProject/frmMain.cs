using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{

    public partial class frmMain : Form
    {
        private List<Product> productList;
        private ListStorage liststorage = new ListStorage();
        public frmMain()
        {
            InitializeComponent();
            productList = new List<Product>();
            // Subscribe to the TextChanged event of txtID
            txtID.TextChanged += txtID_TextChanged;
            cmbMUnit.SelectedIndex = 0;

        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int enteredID))
            {
                // Check if the entered ID exists in the list
                Product product = productList.Find(p => p.ID == enteredID);

                if (product != null)
                {
                    // ID exists in the list, autofill Name and MeasurementUnit
                    txtName.Text = product.Name;
                    cmbMUnit.Text = product.MeasurementUnit;
                }
                else
                {
                    
                    txtName.Clear();

                }
            }
            else
            {

                txtName.Clear();

            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = General.isNumber(e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmEntry frm = new frmEntry();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string idText = txtID.Text;

            // Check if txtID is not null or empty and can be parsed as an integer
            if (!string.IsNullOrEmpty(idText) && int.TryParse(idText, out int idToUpdate))
            {

                liststorage.UpdateProduct(idToUpdate, txtName.Text, cmbMUnit.Text);

                // Update the DataGridView to reflect the changes
                PopulateDataGridView(productList);
                txtID.Clear();
                txtName.Clear();

            }
            else
            {
                MessageBox.Show("Invalid or empty ID. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idToDelete = int.TryParse(txtID.Text, out int id) ? id : -1; // Default to -1 if ID is not provided

            if (idToDelete != -1)
            {
                liststorage.DeleteProduct(idToDelete);
                PopulateDataGridView(productList);
                txtID.Clear();
                txtName.Clear();

            }
            else
            {
                MessageBox.Show("Invalid or empty ID. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (rbDatabase.Checked)
            {
                // DBCODE
            }
            else if (rbMemory.Checked)
            {
                if (int.TryParse(txtID.Text, out int id))
                {
                    // Check if the ID already exists in the list
                    if (productList.Any(p => p.ID == id))
                    {
                        MessageBox.Show("Product with the same ID already exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Product p = new Product
                        {
                            ID = id,
                            Name = txtName.Text,
                            MeasurementUnit = cmbMUnit.Text
                        };
                        liststorage.InsertProduct(p);
                        productList.Add(p);
                        PopulateDataGridView(productList);
                        txtID.Clear();
                        txtName.Clear();
                       // cmbMUnit.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid or empty ID. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void PopulateDataGridView(List<Product> productList)
        {
            dataGridView1.Rows.Clear();
            foreach (var product in productList)
            {
                dataGridView1.Rows.Add(product.ID, product.Name, product.MeasurementUnit);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index != dataGridView1.NewRowIndex)
                {
                    int idColumnIndex = 0;
                    int nameColumnIndex = 1;
                    int measurementUnitColumnIndex = 2;
                    int id = Convert.ToInt32(row.Cells[idColumnIndex].Value);
                    string name = row.Cells[nameColumnIndex].Value.ToString();
                    string measurementUnit = row.Cells[measurementUnitColumnIndex].Value.ToString();
                    liststorage.UpdateProduct(id, name, measurementUnit);
                    txtID.Clear();
                    txtName.Clear();

                }
            }
        }
    }
}
