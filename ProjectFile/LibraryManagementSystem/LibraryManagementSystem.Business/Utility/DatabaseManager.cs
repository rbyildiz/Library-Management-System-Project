using LibraryManagementSystem.Business.Concrete;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Utility
{
    public class DatabaseManager
    {
        private readonly EntityContext _context;
        public DatabaseManager(string connectionString)
        {
            _context = new EntityContext(connectionString);
        }


        public bool CreateBookTable()
        {
            string path = @"C:\Users\rberh\OneDrive\Masaüstü\1091000\Projects\LibraryManagementSystemProject\DataSets\dataset_books.csv";
            CsvFileManager csvFile = new CsvFileManager(path);

            List<Book> dataList = csvFile.Read<Book>();
            if (dataList != null)
            {
                foreach (var data in dataList)
                    _context.Books.Add(data);

                return true;
            }

            return false;
        }

        public bool CreateBookMemberTable()
        {
            string path = @"C:\Users\rberh\OneDrive\Masaüstü\1091000\Projects\LibraryManagementSystemProject\DataSets\dataset_bookmembers.csv";
            CsvFileManager csvFile = new CsvFileManager(path);

            List<BookMember> dataList = csvFile.Read<BookMember>();
            if (dataList != null)
            {
                foreach (var data in dataList)
                    _context.BookMembers.Add(data);

                return true;
            }

            return false;
        }

        public bool CreateMemberTable()
        {
            string path = @"C:\Users\rberh\OneDrive\Masaüstü\1091000\Projects\LibraryManagementSystemProject\DataSets\dataset_members.csv";
            CsvFileManager csvFile = new CsvFileManager(path);

            List<Member> dataList = csvFile.Read<Member>();
            if (dataList != null)
            {
                foreach (var data in dataList)
                    _context.Members.Add(data);

                return true;
            }

            return false;
        }

        public bool CreateCategoryTable()
        {
            string path = @"C:\Users\rberh\OneDrive\Masaüstü\1091000\Projects\LibraryManagementSystemProject\DataSets\dataset_categories.csv";
            CsvFileManager csvFile = new CsvFileManager(path);

            List<Category> dataList = csvFile.Read<Category>();
            if (dataList != null)
            {
                foreach (var data in dataList)
                    _context.Categories.Add(data);

                return true;
            }

            return false;
        }

        public bool CreateAuthorTable()
        {
            string path = @"C:\Users\rberh\OneDrive\Masaüstü\1091000\Projects\LibraryManagementSystemProject\DataSets\dataset_authors.csv";
            CsvFileManager csvFile = new CsvFileManager(path);

            List<Author> dataList = csvFile.Read<Author>();
            if (dataList != null)
            {
                foreach (var data in dataList)
                    _context.Authors.Add(data);

                return true;
            }

            return false;
        }
    }
}
