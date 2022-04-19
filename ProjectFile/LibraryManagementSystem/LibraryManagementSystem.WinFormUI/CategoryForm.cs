using LibraryManagementSystem.Business.Concrete;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.WinFormUI
{
    public partial class CategoryForm : Form
    {
        private readonly int _id;
        private readonly EntityContext _context;

        public CategoryForm(int id)
        {
            InitializeComponent();
            _id = id;

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _context = new EntityContext(connectionString);
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnDelete.Visible = true;
            btnSave.Visible = true;

            if (_id > 0)
            {
                Category category = _context.Categories.Get(_id);
                if (category != null)
                {
                    // Verilerin gosterilemesi
                    txtName.Text = category.CategoryName;

                    if (category.Active == true)
                        rbtnActive.Checked = true;
                    else
                        rbtnPassive.Checked = true;
                }
            }
            else
            {
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnSave.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckPanelControllers()
        {
            foreach (Control control in pnlForm.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    if (string.IsNullOrEmpty(control.Text))
                        return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckPanelControllers())
            {
                Category category = new Category()
                {
                    CategoryName = txtName.Text,
                    Active = rbtnActive.Checked
                };

                _context.Categories.Add(category);
                MessageBox.Show("Data Added.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incomplete data entry.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckPanelControllers())
            {
                Category category = new Category()
                {
                    Id = _id,
                    CategoryName = txtName.Text,
                    Active = rbtnActive.Checked
                };


                DialogResult result = MessageBox.Show("Existing data will be destroyed. Are you sure you want to update the data?", "Update Data", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _context.Categories.Update(category);
                    MessageBox.Show("Data has been updated.");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Incomplete data entry.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Delete Data", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _context.Categories.Delete(_id);
                MessageBox.Show("Data was deleted.");
            }
            this.Close();
        }
    }
}
