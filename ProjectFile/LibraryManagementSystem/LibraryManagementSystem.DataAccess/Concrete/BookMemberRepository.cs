using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryManagementSystem.DataAccess.Concrete
{
    public class BookMemberRepository : IEntityRepository<BookMember>
    {
        private readonly string _connectionString;
        public BookMemberRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        public void Add(BookMember item)
        {
            // Stored Procedure ile Verinin Eklenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Product].[uspInsertBookMember]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@BookID", item.BookID);
                command.Parameters.AddWithValue("@MemberID", item.MemberID);
                command.Parameters.AddWithValue("@BookMemberRentalDate", item.BookMemberRentalDate);
                command.Parameters.AddWithValue("@BookMemberLeaseEndDate", item.BookMemberLeaseEndDate);
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
                string query = "[Product].[uspDeleteBookMember]";

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

        public List<BookMember> Find(object item)
        {
            // Baglantili yontem ile verilerin alinmasi (FUNCTION)
            // SQL Query
            string query = "SELECT [Product].[FindBookMember](@Name)";

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

                    return JsonConvert.DeserializeObject<List<BookMember>>(data);
                }
            }
        }

        public BookMember Get(int id)
        {
            // Baglantili yontem ile verilerin alinmasi
            // JSON Formatinda

            // SQL Query
            string query = "SELECT [Product].[GetBookMember](@Id)";

            // Baglantili yontem
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@Id", id);

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

                    return JsonConvert.DeserializeObject<List<BookMember>>(data).FirstOrDefault();
                }
            }
        }

        public List<BookMember> GetAll(bool active = true)
        {
            // Baglantili yontem ile verilerin alinmasi
            // JSON Formatinda

            // SQL Query
            string query = "SELECT [Product].[GetAllBookMember](@Active)";

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

                reader.Read();

                // verilerin alinmasi
                if (!reader.HasRows)
                    return null;
                else
                {
                    if (reader.IsDBNull(0))
                        return null;

                    string data = reader.GetString(0).ToString();

                    return JsonConvert.DeserializeObject<List<BookMember>>(data);
                }
            }
        }

        public void Update(BookMember item)
        {
            // Stored Procedure ile verinin guncellenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Product].[uspUpdateBookMember]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@BookID", item.BookID);
                command.Parameters.AddWithValue("@MemberID", item.MemberID);
                command.Parameters.AddWithValue("@BookMemberRentalDate", item.BookMemberRentalDate);
                command.Parameters.AddWithValue("@BookMemberLeaseEndDate", item.BookMemberLeaseEndDate);
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
