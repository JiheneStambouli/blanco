using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlancoAssist.Rechnung;

namespace BlancoAssist
{
    public class RechnungenDAO
    {
        public List<Rechnung> Rechnungen { get; set; }

        public RechnungenDAO()
        {
            LoadRechnungenFromDatabase();
        }


        private void LoadRechnungenFromDatabase()
        {
            Rechnungen = new List<Rechnung>();

            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT * FROM Rechnungen";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rechnung rechnung = new Rechnung(reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty, null)
                            {
                                //ID = reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty,
                                RechnungNr = reader["RechnungNr"] != DBNull.Value ? reader["RechnungNr"].ToString() : string.Empty,
                                //Empfaenger = reader["Empfaenger"] != DBNull.Value ? reader["Empfaenger"].ToString() : string.Empty,
                                BeginDate = reader["BeginDate"] != DBNull.Value ? Convert.ToDateTime(reader["BeginDate"]) : DateTime.MinValue,
                                EndDate = reader["EndDate"] != DBNull.Value ? Convert.ToDateTime(reader["EndDate"]) : DateTime.MinValue,
                                //KundenNr = reader["KundenNr"] != DBNull.Value ? reader["KundenNr"].ToString() : string.Empty,
                                Datum = reader["Datum"] != DBNull.Value ? Convert.ToDateTime(reader["Datum"]) : DateTime.MinValue,
                                Gruss = reader["Gruss"] != DBNull.Value ? reader["Gruss"].ToString() : string.Empty,
                                Content = reader["Content"] != DBNull.Value ? reader["Content"].ToString() : string.Empty,
                                EndGruss = reader["EndGruss"] != DBNull.Value ? reader["EndGruss"].ToString() : string.Empty,
                                Intro = reader["Intro"] != DBNull.Value ? reader["Intro"].ToString() : string.Empty,
                                ParentId = reader["KundenID"] != DBNull.Value ? reader["KundenID"].ToString() : string.Empty,

                                //GesamtRechnungPreis = reader["GesamtRechnungPreis"] != DBNull.Value ? Convert.ToDecimal(reader["GesamtRechnungPreis"]) : 0,
                                //Stunden = reader["Stunden"] != DBNull.Value ? Convert.ToInt32(reader["Stunden"]) : 0,
                                //Bezahlt = reader["Bezahlt"] != DBNull.Value ? Convert.ToDecimal(reader["Bezahlt"]) : 0,

                                GesamtRechnungPreis = reader["GesamtRechnungPreis"] != DBNull.Value ? float.TryParse(reader["GesamtRechnungPreis"].ToString(), out float gesamtRechnungPreis) ? gesamtRechnungPreis : 0 : 0,
                                Stunden = reader["Stunden"] != DBNull.Value ? int.TryParse(reader["Stunden"].ToString(), out int stunden) ? stunden : 0 : 0,
                                Bezahlt = reader["Bezahlt"] != DBNull.Value ? float.TryParse(reader["Bezahlt"].ToString(), out float bezahlt) ? bezahlt : 0 : 0,

                                DatumBezahlt = reader["DatumBezahlt"] != DBNull.Value ? Convert.ToDateTime(reader["DatumBezahlt"]) : DateTime.MinValue,

                                FaelligAm = reader["FaelligAm"] != DBNull.Value ? Convert.ToDateTime(reader["FaelligAm"]) : DateTime.MinValue,

                            };

                            // Load associated Kunde
                            //string kundenId = reader["KundenID"] != DBNull.Value ? reader["KundenID"].ToString() : string.Empty;
                            //Kunde parentKunde = GetKundeById(kundenId);
                            //if (parentKunde != null)
                            //{
                            //    rechnung.ParentKunde = parentKunde;
                            //}

                            Rechnungen.Add(rechnung);
                        }
                    }
                }
            }
        }

        public List<Rechnung> UpdateRechnungenFromDatabase()
        {
            // Reload the Rechnungen list from the database
            LoadRechnungenFromDatabase();

            // Return the updated list
            return Rechnungen;
        }
        public void SaveOrUpdateRechnungenToDatabase(List<Rechnung> rechnungenList)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                foreach (Rechnung rechnung in rechnungenList)
                {
                    string checkQuery = "SELECT COUNT(1) FROM Rechnungen WHERE ID = @ID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@ID", rechnung.ID);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = @"UPDATE Rechnungen 
                                           SET RechnungNr = @RechnungNr, 
                                               Empfaenger = @Empfaenger, 
                                               BeginDate = @BeginDate, 
                                               EndDate = @EndDate, 
                                               KundenNr = @KundenNr, 
                                               Datum = @Datum, 
                                               Gruss = @Gruss, 
                                               Intro = @Intro, 
                                               Content = @Content, 
                                               EndGruss = @EndGruss,

                                               ParentId = @ParentId,
                                               GesamtRechnungPreis = @GesamtRechnungPreis,
                                               Stunden = @Stunden,
                                               Bezahlt = @Bezahlt,
                                               DatumBezahlt = @DatumBezahlt,
                                               FaelligAm = @FaelligAm,
                                               Status = @Status


                                           WHERE ID = @ID";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@RechnungNr", rechnung.RechnungNr);
                                updateCommand.Parameters.AddWithValue("@Empfaenger", (object)rechnung.Empfaenger ?? DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@BeginDate", rechnung.BeginDate);
                                updateCommand.Parameters.AddWithValue("@EndDate", rechnung.EndDate);
                                updateCommand.Parameters.AddWithValue("@KundenNr", (object)rechnung.KundenNr ?? DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@Datum", rechnung.Datum);
                                updateCommand.Parameters.AddWithValue("@Gruss", (object)rechnung.Gruss ?? DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@Intro", (object)rechnung.Intro ?? DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@Content", (object)rechnung.Content ?? DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@EndGruss", (object)rechnung.EndGruss ?? DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@ParentId", (object)rechnung.ParentId ?? DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@GesamtRechnungPreis", rechnung.GesamtRechnungPreis);
                                updateCommand.Parameters.AddWithValue("@Stunden", rechnung.Stunden);
                                updateCommand.Parameters.AddWithValue("@Bezahlt", rechnung.Bezahlt);
                                updateCommand.Parameters.AddWithValue("@DatumBezahlt", rechnung.DatumBezahlt != DateTime.MinValue ? (object)rechnung.DatumBezahlt : DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@FaelligAm", (object)rechnung.FaelligAm != null ? (object)rechnung.FaelligAm : DBNull.Value);
                                updateCommand.Parameters.AddWithValue("@Status", rechnung.Status.ToString());
                                updateCommand.Parameters.AddWithValue("@ID", rechnung.ID);

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"INSERT INTO Rechnungen (ID, RechnungNr, Empfaenger, BeginDate, EndDate, KundenNr, Datum, Gruss, Content, Intro, EndGruss,KundenId, GesamtRechnungPreis, Stunden, Bezahlt, DatumBezahlt, FaelligAm, Status) 
                                           VALUES (@ID, @RechnungNr, @Absaender, @Empfaenger, @BeginDate, @EndDate, @KundenNr, @Datum, @Gruss, @Content, @Intro , @EndGruss, @KundenId, @GesamtRechnungPreis, @Stunden, @Bezahlt, @DatumBezahlt, @FaelligAm, @Status)";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@ID", rechnung.ID);
                                insertCommand.Parameters.AddWithValue("@RechnungNr", rechnung.RechnungNr );
                                insertCommand.Parameters.AddWithValue("@Empfaenger", (object)rechnung.Empfaenger ?? DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@BeginDate", rechnung.BeginDate);
                                insertCommand.Parameters.AddWithValue("@EndDate", rechnung.EndDate);
                                insertCommand.Parameters.AddWithValue("@KundenNr", (object)rechnung.KundenNr ?? DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@Datum", rechnung.Datum);
                                insertCommand.Parameters.AddWithValue("@Gruss", (object)rechnung.Gruss ?? DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@Content", (object)rechnung.Content ?? DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@Intro", (object)rechnung.Intro ?? DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@EndGruss", (object)rechnung.EndGruss ?? DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@KundenId", (object)rechnung.ParentId ?? DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@GesamtRechnungPreis", rechnung.GesamtRechnungPreis);
                                insertCommand.Parameters.AddWithValue("@Stunden", rechnung.Stunden);
                                insertCommand.Parameters.AddWithValue("@Bezahlt", rechnung.Bezahlt);
                                insertCommand.Parameters.AddWithValue("@DatumBezahlt", rechnung.DatumBezahlt != DateTime.MinValue ? (object)rechnung.DatumBezahlt : DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@FaelligAm", (object)rechnung.FaelligAm != null ? (object)rechnung.FaelligAm : DBNull.Value);
                                insertCommand.Parameters.AddWithValue("@Status", rechnung.Status.ToString());

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        public void DeleteRechnungen(List<string> rechnungIds)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
            {
                connection.Open();

                string query = "DELETE FROM Rechnungen WHERE ID IN (@RechnungIds)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RechnungIds", string.Join(",", rechnungIds));
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Rechnung> GetRechnungByParentId(string parentId)
        {
                if (this.Rechnungen == null)
                { this.LoadRechnungenFromDatabase(); }

                List<Rechnung> rechnungenWithKundenId = new List<Rechnung>();

                // Iterate through each Rechnung's services and add those with matching parent ID
                foreach (var rechnung in this.Rechnungen)
                {
                    if (rechnung.ParentId == parentId)
                    {
                    rechnungenWithKundenId.Add(rechnung);
                    }
                }


                return rechnungenWithKundenId;
        }

    }

}
