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
    public class MemberRepository : IEntityRepository<Member>
    {
        private readonly string _connectionString;
        public MemberRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        public void Add(Member item)
        {
            // Stored Procedure ile verinin eklenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Person].[uspInsertMember]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@FirstName", item.MemberFirstName);
                command.Parameters.AddWithValue("@LastName", item.MemberLastName);
                command.Parameters.AddWithValue("@PhoneNumber", item.MemberPhoneNumber);
                command.Parameters.AddWithValue("@Email", item.MemberEmail);
                command.Parameters.AddWithValue("@Address", item.MemberAddress);
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
                string query = "[Person].[uspDeleteMember]";

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

        public List<Member> Find(object item)
        {
            // Function ile verinin bulunmasi (JSON formatinda)
            // SQL Query
            string query = "SELECT [Person].[FindMember](@Name)";

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
                    return new List<Member>();
                else
                {
                    reader.Read();

                    if (reader.IsDBNull(0))
                        return null;

                    string data = reader.GetValue(0).ToString();

                    return JsonConvert.DeserializeObject<List<Member>>(data);
                }
            }
        }

        public Member Get(int id)
        {
            // Baglantisiz yontem ile verinin bulunmasi
            // SQL Query
            string query = $"SELECT * FROM [Person].[Members] WHERE Id = {id}";

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
            Member member = dataTable.AsEnumerable().Select(aut => new Member()
            {
                Id = id,
                MemberFirstName = aut.Field<string>("MemberFirstName"),
                MemberLastName = aut.Field<string>("MemberLastName"),
                MemberPhoneNumber = aut.Field<string>("MemberPhoneNumber"),
                MemberEmail = aut.Field<string>("MemberEmail"),
                MemberAddress = aut.Field<string>("MemberAddress"),
                Active = aut.Field<bool>("Active")
            }).FirstOrDefault();

            return member;
        }

        public List<Member> GetAll(bool active = true)
        {
            // Function ile verilerin alinmasi
            // Json formatinda

            // SQL Query
            string query = "SELECT [Person].[GetAllMember](@Active)";

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

                    return JsonConvert.DeserializeObject<List<Member>>(data);
                }
            }
        }

        public void Update(Member item)
        {
            // Stored Procedure ile verinin guncellenmesi
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // SQL Query
                string query = "[Person].[uspUpdateMember]";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@FirstName", item.MemberFirstName);
                command.Parameters.AddWithValue("@LastName", item.MemberLastName);
                command.Parameters.AddWithValue("@PhoneNumber", item.MemberPhoneNumber);
                command.Parameters.AddWithValue("@Email", item.MemberEmail);
                command.Parameters.AddWithValue("@Address", item.MemberAddress);
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
