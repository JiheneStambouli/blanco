using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BlancoAssist
{
    public class KundenDAO
    {
        public List<Kunde> Kunden { get; set; }

        public KundenDAO()
        {
            LoadKundenFromDatabase();
        }

        private void LoadKundenFromDatabase()
        {
            Kunden = new List<Kunde>();

            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT * FROM Kunden";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Kunde kunde = new Kunde(
                                    (KundenType)Enum.Parse(typeof(KundenType), reader["Type"].ToString()),
                                     reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty)
                           {
                                KundenNummer = reader["KundenNummer"] != DBNull.Value ? reader["KundenNummer"].ToString() : string.Empty,
                                VersichererID = reader["VersichererID"] != DBNull.Value ? reader["VersichererID"].ToString() : string.Empty,
                                Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty,
                                FirstName = reader["Firstname"] != DBNull.Value ? reader["Firstname"].ToString() : string.Empty,
                                LastName = reader["Lastname"] != DBNull.Value ? reader["Lastname"].ToString() : string.Empty,
                                Zeichen = reader["Zeichen"] != DBNull.Value ? reader["Zeichen"].ToString() : string.Empty,
                                Birthdate = reader["Birthdate"] != DBNull.Value ? Convert.ToDateTime(reader["Datum"]) : DateTime.MinValue,
                                CreationDate = reader["CreationDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreationDate"]) : DateTime.Now
                            };


                            //// Load associated Kunde
                            //string rechnungenID = reader["KundenID"] != DBNull.Value ? reader["KundenID"].ToString() : string.Empty;
                            //Kunde parentKunde = GetKundeById(rechnungenID);
                            //if (parentKunde != null)
                            //{
                            //    rechnung.ParentKunde = parentKunde;
                            //}

                            Kunden.Add(kunde);
                        }
                    }
                }
            }
        }

        public void UpdateKundenToDatabase(List<Kunde> kundenList)
        {
            // Implement update logic here
        }

        public void SaveOrUpdateKundenToDatabase(List<Kunde> kundenList)
        {
            // Implement save or update logic here
        }

        public void DeleteKunden(List<string> kundeIds)
        {
            // Implement delete logic here
        }

        internal List<Kunde> GetKundenByParentId(string parentId)
        {
            //List<Kunde> kundenList = new List<Kunde>();

            //using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            //{
            //    connection.Open();

            //    string query = "SELECT * FROM KUNDEN WHERE VersichererID = @ParentId";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@ParentId", parentId);

            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                Kunde kunde = new Kunde((KundenType)Enum.Parse(typeof(KundenType), reader["Type"].ToString()), reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty)
            //                {
            //                    KundenNummer = reader["KundenNummer"] != DBNull.Value ? reader["KundenNummer"].ToString() : string.Empty,
            //                    Name = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : string.Empty,
            //                    Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty
            //                };

            //                kundenList.Add(kunde);
            //            }
            //        }
            //    }
            //}

            //return kundenList;+++++

            if (this.Kunden == null)
            { this.LoadKundenFromDatabase(); }

            List<Kunde> kundenWithParentId = new List<Kunde>();

            // Iterate through each Rechnung's services and add those with matching parent ID
            foreach (var kunde in this.Kunden)
            {
                if (kunde.VersichererID == parentId)
                {
                    kundenWithParentId.Add(kunde);
                }
            }

            return kundenWithParentId;

        }

        public Kunde GetKundeByRechnungId(string rechnungId)
        {
            if (this.Kunden == null)
            {
                this.LoadKundenFromDatabase();
            }

            // Iterate through each Kunde and check their Rechnungen
            foreach (var kunde in this.Kunden)
            {
                if (kunde.Rechnungen != null && kunde.Rechnungen.Any(r => r.ID == rechnungId))
                {
                    return kunde; 
                }
            }
            return null; 
        }
    }
}
