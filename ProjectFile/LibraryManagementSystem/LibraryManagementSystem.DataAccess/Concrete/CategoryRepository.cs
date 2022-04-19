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
    public class CategoryRepository : IEntityRepository<Category>
    {
        private readonly string _connectionString;
        public CategoryRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        public void Add(Category item)
        {
            // Stored Procedure ile verinin eklenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Product].[uspInsertCategory]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Name", item.CategoryName);
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
                string query = "[Product].[uspDeleteCategory]";

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

        public List<Category> Find(object item)
        {
            // Function ile verinin bulunmasi
            // SQL Query
            string query = "SELECT [Product].[FindCategory](@Name)";

            // Baglanti
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.CommandType = System.Data.CommandType.Text;
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


                // Verinin alinmasi
                if (!reader.HasRows)
                    return null;
                else
                {
                    reader.Read();

                    if (reader.IsDBNull(0))
                        return null;

                    string data = reader.GetValue(0).ToString();
                    return JsonConvert.DeserializeObject<List<Category>>(data);
                }
            }
        }

        public Category Get(int id)
        {
            // Stored Procedure ile verinin alinmasi
            // OUTPUT ile degerlerin dondurulmesi

            // SQL Query
            string query = "[Product].[uspGetCategory]";

            // Baglanti
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", id);
                // OUT parametreleri
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 30).Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add("@Active", System.Data.SqlDbType.Bit).Direction = System.Data.ParameterDirection.Output;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }


                // Parametlerin alinmasi
                Category category = new Category()
                {
                    Id = id,
                    CategoryName = command.Parameters["@Name"].Value.ToString(),
                    Active = Convert.ToBoolean(command.Parameters["@Active"].Value)
                };

                return category;
            }
        }

        public List<Category> GetAll(bool active = true)
        {
            // Baglantisiz Yontem ile tum verilerin alinmasi
            // SQL Query
            string query = "SELECT * FROM [Product].[Categories]";

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

            // Verilerin okunmasi
            List<Category> categories = dataTable.AsEnumerable().Where(c => c.Field<bool>("Active") == active).Select(c => new Category()
            {
                Id = c.Field<int>("Id"),
                CategoryName = c.Field<string>("CategoryName"),
                Active = c.Field<bool>("Active")
            }).ToList();

            return categories;
        }

        public void Update(Category item)
        {
            // Stored Procedure ile verinin guncellenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Product].[uspUpdateCategory]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@Name", item.CategoryName);
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
