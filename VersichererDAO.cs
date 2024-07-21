using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlancoAssist
{
    public class VersichererDAO
    {
        public List<Versicherer> VersichererList { get; set; }

        public VersichererDAO()
        {
            LoadVersichererFromDatabase();
        }

        private void LoadVersichererFromDatabase()
        {
            VersichererList = new List<Versicherer>();

            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT * FROM Versicherer";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Versicherer versicherer = new Versicherer(reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty)
                            {
                                Name = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : string.Empty,
                                Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty
                            };


                            VersichererList.Add(versicherer);
                        }
                    }
                }
            }
        }

        public List<Versicherer> UpdateVersichererFromDatabase()
        {
            // Reload the Versicherer list from the database
            LoadVersichererFromDatabase();

            // Return the updated list
            return VersichererList;
        }

        public void SaveOrUpdateVersichererToDatabase(List<Versicherer> versichererList)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                foreach (Versicherer versicherer in versichererList)
                {
                    string checkQuery = "SELECT COUNT(1) FROM Versicherer WHERE ID = @ID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@ID", versicherer.ID);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = @"UPDATE Versicherer 
                                                   SET Name = @Name, 
                                                       Address = @Address
                                                   WHERE ID = @ID";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@Name", versicherer.Name);
                                updateCommand.Parameters.AddWithValue("@Address", versicherer.Address);
                                updateCommand.Parameters.AddWithValue("@ID", versicherer.ID);

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"INSERT INTO Versicherer (ID, Name, Address) 
                                                   VALUES (@ID, @Name, @Address)";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@ID", versicherer.ID);
                                insertCommand.Parameters.AddWithValue("@Name", versicherer.Name);
                                insertCommand.Parameters.AddWithValue("@Address", versicherer.Address);

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        public void DeleteVersicherer(List<string> versichererIds)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                string query = "DELETE FROM Versicherer WHERE ID IN (@VersichererIds)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VersichererIds", string.Join(",", versichererIds));
                    command.ExecuteNonQuery();
                }
            }
        }

        public Versicherer GetVersichererById(string versichererId)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT * FROM Versicherer WHERE ID = @VersichererId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VersichererId", versichererId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Versicherer versicherer = new Versicherer(reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty)
                            {
                                Name = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : string.Empty,
                                Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty
                            };


                            return versicherer;
                        }
                    }
                }
            }

            return null;
        }

        internal Versicherer GetVersichererByParentId(string kundeId)
        {
            if (this.VersichererList == null)
            {
                this.LoadVersichererFromDatabase();
            }

            foreach (var ver in this.VersichererList)
            {
                if (ver.Kunden != null && ver.Kunden.Any(r => r.ID == kundeId))
                {
                    return ver;
                }
            }
            return null;
        }
    }
}
