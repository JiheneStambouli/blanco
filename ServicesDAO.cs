using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BlancoAssist
{
    public class ServicesDAO
    {
        public List<Service> Services { get; set; }
        private string connectionString = "Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;";

        public ServicesDAO()
        {
            LoadServicesFromDatabase();
        }

        private void LoadServicesFromDatabase()
        {
            Services = new List<Service>();

            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT * FROM Services";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Service service = new Service(reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty, null)
                            {
                                Pos = reader["Pos"] != DBNull.Value ? reader["Pos"].ToString() : string.Empty,
                                Beschreibung = reader["Beschreibung"] != DBNull.Value ? reader["Beschreibung"].ToString() : string.Empty,
                                Menge = reader["Menge"] != DBNull.Value ? reader["Menge"].ToString() : string.Empty,
                                Einzelpreis = reader["Einzelpreis"] != DBNull.Value ? reader["Einzelpreis"].ToString() : string.Empty,
                            };

                            Services.Add(service);
                        }
                    }
                }
            }
        }

        public List<Service> GetServicesByParentId(string parentId)
        {
            if (this.Services == null)
            { this.LoadServicesFromDatabase(); }

            List<Service> servicesWithParentId = new List<Service>();

            // Iterate through each Rechnung's services and add those with matching parent ID
            foreach (var s in this.Services)
            {
                if (s.ParentId == parentId)
                    {
                        servicesWithParentId.Add(s);
                    }
            }


            return servicesWithParentId;

        } 

        public List<Service> UpdateServicesFromDatabase()
        {
            // Reload the Services list from the database
            LoadServicesFromDatabase();

            // Return the updated list
            return Services;
        }

        public void SaveOrUpdateServicesToDatabase(List<Service> servicesList)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                foreach (Service service in servicesList)
                {
                    string checkQuery = "SELECT COUNT(1) FROM Services WHERE ID = @ID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        // Assuming ID is the unique identifier for services
                        checkCommand.Parameters.AddWithValue("@ID", service.ID);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = @"UPDATE Services 
                                                  SET Pos = @Pos, 
                                                      Beschreibung = @Beschreibung, 
                                                      Menge = @Menge, 
                                                      Einzelpreis = @Einzelpreis
                                                  WHERE ID = @ID";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@Pos", service.Pos);
                                updateCommand.Parameters.AddWithValue("@Beschreibung", service.Beschreibung);
                                updateCommand.Parameters.AddWithValue("@Menge", service.Menge);
                                updateCommand.Parameters.AddWithValue("@Einzelpreis", service.Einzelpreis);
                                updateCommand.Parameters.AddWithValue("@ID", service.ID);

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"INSERT INTO Services (ParentId, Pos, Beschreibung, Menge, Einzelpreis) 
                                                  VALUES (@ParentId, @Pos, @Beschreibung, @Menge, @Einzelpreis)";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@ParentId", service.ParentId);
                                insertCommand.Parameters.AddWithValue("@Pos", service.Pos);
                                insertCommand.Parameters.AddWithValue("@Beschreibung", service.Beschreibung);
                                insertCommand.Parameters.AddWithValue("@Menge", service.Menge);
                                insertCommand.Parameters.AddWithValue("@Einzelpreis", service.Einzelpreis);

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        public void DeleteServices(List<string> serviceIds)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                string query = "DELETE FROM Services WHERE ID IN (@ServiceIds)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceIds", string.Join(",", serviceIds));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
