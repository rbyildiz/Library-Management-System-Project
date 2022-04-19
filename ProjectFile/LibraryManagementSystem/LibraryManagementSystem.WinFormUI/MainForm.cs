using LibraryManagementSystem.Business.Concrete;
using LibraryManagementSystem.Business.Utility;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem.WinFormUI
{
    public partial class MainForm : Form
    {
        private readonly string _connectionString;
        private bool _active = true;
        private string _name;
        private EntityContext _context;

        public MainForm()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _context = new EntityContext(_connectionString);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = _context.BookMembers.GetAll(_active);
            ResizeColumns();

            _name = "BookMembers";
        }

        // Table Data
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = _context.BookMembers.GetAll(_active);
            ResizeColumns();

            _name = "BookMembers";
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = _context.Members.GetAll(_active);
            ResizeColumns();

            _name = "Members";
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

            var data = _context.Books.GetAll(_active);
            if (data == null)
                data = new List<Book>();

            var dataSet = (from book in data
                           select new
                           {
                               book.Id,
                               book.BookName,
                               book.Author.AuthorLastName,
                               book.BookPublicationYear,
                               book.BookSummary,
                               book.BookImagePath,
                               book.BookLanguage,
                               book.Category.CategoryName,
                               book.Active
                           }).ToList();

            dgvTable.DataSource = dataSet;
            ResizeColumns();
            _name = "Books";
        }

        private void btnTypesOfBooks_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = _context.Categories.GetAll(_active);
            ResizeColumns();

            _name = "TypesOfBooks";
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = _context.Authors.GetAll(_active);
            ResizeColumns();

            _name = "Authors";
        }


        // CLOSE Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Checkbox
        private void cbxActive_CheckedChanged(object sender, EventArgs e)
        {
            _active = cbxActive.Checked;
        }

        // DataGridView sutunlarinin esitlenmesi...
        private void ResizeColumns()
        {
            for (int i = 0; i < dgvTable.Columns.Count; i++)
            {
                dgvTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            int index = dgvTable.Columns.Count - 1;

            if (index > 0)
                dgvTable.Columns["Active"].DisplayIndex = index;
        }

        // Arama textbox'i sonucunun gosterilmesi
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            List<int> rowIndex = new List<int>();

            dgvTable.ClearSelection();

            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dgvTable.Rows)
                {
                    string rowValue = row.Cells[1].Value.ToString().ToUpper();
                    searchText = searchText.ToUpper();

                    if (rowValue.Contains(searchText))
                        dgvTable.Rows[row.Index].Selected = true;
                }
            }
        }

        // Ekleme butonu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowForm(0);
        }

        // Tablodan eleman secilmesi ve gosterilmesi
        private void dgvTable_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if(dgv.SelectedRows.Count > 0)
            {
                var selectRow = dgv.SelectedRows[0];

                int id = Convert.ToInt32(selectRow.Cells["Id"].Value);
                ShowForm(id);
            }
        }

        // Gerekli formun gosterilmesi
        private void ShowForm(int id)
        {
            switch (_name)
            {
                case "Books": { BookForm form = new BookForm(id); form.ShowDialog(); break; }
                case "TypesOfBooks": { CategoryForm form = new CategoryForm(id); form.ShowDialog(); break; }
                case "Authors": { AuthorForm form = new AuthorForm(id); form.ShowDialog(); break; }
                case "Members": { MemberForm form = new MemberForm(id); form.ShowDialog(); break; }
                default: { BookMemberForm form = new BookMemberForm(id); form.ShowDialog(); break; }
            }
        }
    }
}
