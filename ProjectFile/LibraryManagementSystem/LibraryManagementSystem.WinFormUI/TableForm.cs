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
    public partial class TableForm : Form
    {
        private readonly bool _table;
        private readonly EntityContext _context;

        public TableForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }

        // BookMemberForm
        BookMemberForm _bookMemberForm;
        public TableForm(BookMemberForm bookMemberForm, bool table)
        {
            InitializeComponent();

            // table -> 0 : Book, 1 : Member
            _bookMemberForm = bookMemberForm;
            _table = table;

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _context = new EntityContext(connectionString);

            if (table)
                dgvTable.DataSource = _context.Members.GetAll();
            else
            {
                var data = _context.Books.GetAll();
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
            }

            ResizeColumns();
        }

        private void dgvTable_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                var selectRow = dgv.SelectedRows[0];

                int id = Convert.ToInt32(selectRow.Cells["Id"].Value);

                if (_table)
                    _bookMemberForm._memberID = id;
                else
                    _bookMemberForm._bookID = id;

                this.Close();
            }
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
    }
}
