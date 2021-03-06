using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryManagementSystem.DataAccess.Concrete
{
    public class AuthorRepository : IEntityRepository<Author>
    {
        private readonly string _connectionString;
        public AuthorRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        public void Add(Author item)
        {
            // Stored Procedure ile verinin eklenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Person].[uspInsertAuthor]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@FirstName", item.AuthorFirstName);
                command.Parameters.AddWithValue("@LastName", item.AuthorLastName);
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
                string query = "[Person].[uspDeleteAuthor]";

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

        public List<Author> Find(object item)
        {
            // Baglantili yontem ile verinin bulunmasi
            // SQL Query
            string query = "SELECT * FROM [Person].[Authors] WHERE AuthorFirstName LIKE '%' + @Name + '%'";

            // Baglantili yontem
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Name", item);

                // Verinin okunmasi
                SqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }

                // verinin alinmasi
                if (!reader.HasRows)
                    return null;
                else
                {
                    List<Author> authors = new List<Author>();
                    while (reader.Read())
                        authors.Add(new Author()
                        {
                            Id = reader.GetInt32(0),
                            AuthorFirstName = reader.GetString(1),
                            AuthorLastName = reader.GetString(2),
                            Active = reader.GetBoolean(3)
                        });

                    return authors;
                }
            }
        }

        public Author Get(int id)
        {
            // Baglantisiz yontem ile verinin bulunmasi
            // SQL Query
            string query = $"SELECT * FROM [Person].[Authors] WHERE Id = {id}";

            // Baglantisiz yontem
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connectionString);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }

            // Verinin alinmasi
            Author author = dataTable.AsEnumerable().Select(aut => new Author()
            {
                Id = id,
                AuthorFirstName = aut.Field<string>("AuthorFirstName"),
                AuthorLastName = aut.Field<string>("AuthorLastName"),
                Active = aut.Field<bool>("Active")
            }).FirstOrDefault();

            return author;
        }

        public List<Author> GetAll(bool active = true)
        {
            // Function ile verilerin alinmasi
            // Json formatinda

            // SQL Query
            string query = "SELECT [Person].[GetAllAuthor](@Active)";

            // Baglanti
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Active", active);

                // verinin okunmasi
                SqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }


                // verinin alinmasi
                if (!reader.HasRows)
                    return null;
                else
                {
                    reader.Read();

                    if (reader.IsDBNull(0))
                        return null;

                    string data = reader.GetString(0).ToString();

                    return JsonConvert.DeserializeObject<List<Author>>(data);
                }
            }
        }

        public void Update(Author item)
        {
            // Stored Procedure ile verinin guncellenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Person].[uspUpdateAuthor]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@FirstName", item.AuthorFirstName);
                command.Parameters.AddWithValue("@LastName", item.AuthorLastName);
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
