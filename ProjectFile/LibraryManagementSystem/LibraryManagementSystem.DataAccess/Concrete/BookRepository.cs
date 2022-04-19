using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryManagementSystem.DataAccess.Concrete
{
    public class BookRepository : IEntityRepository<Book>
    {
        private readonly string _connectionString;
        public BookRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        public void Add(Book item)
        {
            // Stored Procedure ile verinin eklenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Product].[uspInsertBook]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@BookName", item.BookName);
                command.Parameters.AddWithValue("@AuthorID", item.AuthorID);
                command.Parameters.AddWithValue("@BookPublicationYear", item.BookPublicationYear);
                command.Parameters.AddWithValue("@BookSummary", item.BookSummary);
                command.Parameters.AddWithValue("@CategoryID", item.CategoryID);
                command.Parameters.AddWithValue("@BookLanguage", item.BookLanguage);
                command.Parameters.AddWithValue("@BookImagePath", item.BookImagePath);
                command.Parameters.AddWithValue("@Active", item.Active);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Delete(int id)
        {
            // Stored Procedure ile verinin silinmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Product].[uspDeleteBook]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Book> Find(object item)
        {
            // Baglantili yontem ile verilerin alinmasi (FUNCTION)
            // SQL Query
            string query = "SELECT [Product].[FindBook](@Name)";

            // Baglantili yontem
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Name", item);

                // verinin okunmasi icin
                SqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }

                // Verinin okunmasi
                if (!reader.HasRows)
                    return null;
                else
                {
                    reader.Read();

                    if (reader.IsDBNull(0))
                        return null;

                    string data = reader.GetString(0).ToString();

                    return JsonConvert.DeserializeObject<List<Book>>(data);
                }
            }
        }

        public Book Get(int id)
        {
            // Baglantili yontem ile verilerin alinmasi (FUNCTION)
            // SQL Query
            string query = "SELECT [Product].[GetBook](@Id)";

            // Baglantili yontem
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", id);

                // verinin okunmasi icin
                SqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }

                // Verinin okunmasi
                if (!reader.HasRows)
                    return null;
                else
                {
                    reader.Read();

                    if (reader.IsDBNull(0))
                        return null;

                    string data = reader.GetString(0).ToString();

                    return JsonConvert.DeserializeObject<List<Book>>(data).FirstOrDefault();
                }
            }
        }

        public List<Book> GetAll(bool active = true)
        {
            // Baglantili yontem ile verilerin alinmasi
            // JSON Formatinda

            // SQL Query
            string query = "SELECT [Product].[GetAllBook](@Active)";

            // Baglantili yontem
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@Active", active);

                // Verilerin okunmasi
                SqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }

                // verilerin alinmasi
                if (!reader.HasRows)
                    return null;
                else
                {
                    reader.Read();

                    if (reader.IsDBNull(0))
                        return null;

                    string data = reader.GetString(0).ToString();

                    return JsonConvert.DeserializeObject<List<Book>>(data);
                }
            }
        }

        public void Update(Book item)
        {
            // Stored Procedure ile verinin guncellenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Product].[uspUpdateBook]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@BookName", item.BookName);
                command.Parameters.AddWithValue("@AuthorID", item.AuthorID);
                command.Parameters.AddWithValue("@BookPublicationYear", item.BookPublicationYear);
                command.Parameters.AddWithValue("@BookSummary", item.BookSummary);
                command.Parameters.AddWithValue("@CategoryID", item.CategoryID);
                command.Parameters.AddWithValue("@BookLanguage", item.BookLanguage);
                command.Parameters.AddWithValue("@BookImagePath", item.BookImagePath);
                command.Parameters.AddWithValue("@Active", item.Active);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
