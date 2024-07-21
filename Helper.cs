using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlancoAssist
{
    public class Helper
    {
        private static RechnungenDAO _rechnungenDAO;
        public static RechnungenDAO RechnungenDAO;


        public static KundenDAO KundenDAO;
        public static VersichererDAO VersichererDAO;
        public static ServicesDAO ServicesDAO;

        public List<Rechnung> Rechnungen { get; set; }
        public List<Kunde> Kunden { get; set; }
        public List<Versicherer> Versicherer { get; set; }
        public List<Service> Services { get; set; }

        // Initialize RechnungenDAO if not already initialized
        public static RechnungenDAO GetRechnungenDAO()
        {
            if (_rechnungenDAO == null)
            {
                _rechnungenDAO = new RechnungenDAO();
            }
            return _rechnungenDAO;
        }

        public Helper() {

            RechnungenDAO = new RechnungenDAO();
            Rechnungen = RechnungenDAO.Rechnungen;

            ServicesDAO = new ServicesDAO();
            Services = ServicesDAO.Services;

            KundenDAO = new KundenDAO();
            Kunden = KundenDAO.Kunden;

            VersichererDAO = new VersichererDAO();
            Versicherer = VersichererDAO.VersichererList;


            foreach (var rechnung in Rechnungen) 
            {
                rechnung.Services = ServicesDAO.GetServicesByParentId(rechnung.ID);
                rechnung.ParentKunde = KundenDAO.GetKundeByRechnungId(rechnung.ID);
            }

            foreach (var versicherer in Versicherer)
            {
                versicherer.Kunden = KundenDAO.GetKundenByParentId(versicherer.ID);
            }

            foreach (var kunde in Kunden)
            {
                kunde.Rechnungen = RechnungenDAO.GetRechnungByParentId(kunde.ID);
                kunde.Versicherer = VersichererDAO.GetVersichererByParentId(kunde.ID);

            }

        }

        internal Rechnung CreateNewRechnung(KundenType selectedEnum)
        {
            string kundenNummer = GetNewKundenNummer(selectedEnum);
            Kunde kunde = new Kunde(kundenNummer, selectedEnum, null);
            Rechnung rechnung = new Rechnung(kunde);
            rechnung.RechnungNr = GetNewRechnungNummer();

            rechnung.Gruss = "Sehr geehrte Damen und Herren,";
            rechnung.Intro = "hiermit erstatten wir Sie folgende Leistungen:";

            rechnung.Content = "Bitte begleichen Sie den Gesamtbetrag von $gesamtPreis$ innerhalb von 14 Tage auf den unten genannten Bankkonto\n Bei Rückfragen stehen wir selbstvertändlich jederzeit gerne zur Verfügung.";
            rechnung.EndGruss = "Mit freundlichen Grüssen";

            rechnung.ParentKunde = kunde;

            return rechnung;
        }

        private string GetNewRechnungNummer()
        {
            // Extracting the numeric part from each RechnungNummer and sorting them
            var sortedNumbers = Rechnungen
                .Select(r => int.TryParse(r.RechnungNr.TrimEnd('R'), out int num) ? num : 0)
                .OrderByDescending(num => num)
                .ToList();

            // If the list is empty, start from 1
            int highestNumber = sortedNumbers.Any() ? sortedNumbers.First() : 0;

            // Increment the highest number and format it as RechnungNummer
            string newRechnungNummer = $"{highestNumber + 1:D5} R";

            return newRechnungNummer;
        }

        public string GetNewKundenNummer(KundenType kundenType)
        {
            // Get the prefix based on the KundenType
            string prefix = kundenType.ToString().Substring(0, 1);

            List<int> kundenNummernList = new List<int>();

            // Loop through the kundenList to find customer numbers with the specified prefix
            foreach (var kunde in Kunden)
            {
                if (kunde.KundenNummer.StartsWith(prefix))
                {
                    // Trim the prefix and convert the rest to an integer
                    if (int.TryParse(kunde.KundenNummer.Substring(1), out int number))
                    {
                        kundenNummernList.Add(number);
                    }
                }
            }

            // Find the maximum number and increment it by 1
            int newNumber = (kundenNummernList.Count > 0 ? kundenNummernList.Max() : 0) + 1;

            // Format the new number with leading zeros to maintain a consistent length (e.g., 0001)
            string newKundenNummer = $"{prefix} {newNumber:D4}";

            return newKundenNummer;
        }

        //public static string GetNewKundenNummer(KundenType kundenType)
        //{
        //    // Get the prefix based on the KundenType
        //    string prefix = kundenType.ToString().Substring(0, 1);

        //    List<int> kundenNummernList = new List<int>();

        //    using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
        //    {
        //        connection.Open();

        //        string query = "SELECT KundenNummer FROM Kunden WHERE KundenNummer LIKE @prefix + '%'";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@prefix", prefix);

        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    string kundenNummer = reader["KundenNummer"].ToString();

        //                    // Trim the prefix and convert the rest to an integer
        //                    if (int.TryParse(kundenNummer.Substring(1), out int number))
        //                    {
        //                        kundenNummernList.Add(number);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    // Find the maximum number and increment it by 1
        //    int newNumber = (kundenNummernList.Count > 0 ? kundenNummernList.Max() : 0) + 1;

        //    // Format the new number with leading zeros to maintain a consistent length (e.g., 0001)
        //    string newKundenNummer = $"{prefix}{newNumber:D4}";

        //    return newKundenNummer;
        //}




        //public static string GetNewKundenNummer(KundenType kundenType)
        //{
        //    string prefix = kundenType.ToString().Substring(0, 1); // Get the prefix based on the KundenType

        //    List<string> kundenNummernList = new List<string>();


        //    using (SqlConnection connection = new SqlConnection("Server=(localdb)\\blancodb;Database=RECHNUNGDB;Integrated Security=True;"))
        //    {
        //        connection.Open();

        //        string query = "SELECT KundenNummer FROM Kunden WHERE KundenNummer LIKE @prefix + '%'";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@prefix", prefix);

        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    kundenNummernList.Add(reader["KundenNummer"].ToString());
        //                }
        //            }
        //        }
        //    }

        //    if (kundenNummernList.Count == 0)
        //    {
        //        // No existing customers for this type, start from 0001
        //        return $"{prefix} 0001";
        //    }

        //    string newKundenNummer;
        //    int numberPart = 1;
        //    bool exists = false;
        //    do
        //    {
        //        newKundenNummer = $"{prefix} {numberPart:D4}";
        //        if (kundenNummernList.Contains(newKundenNummer))
        //        {
        //            exists = true;
        //            break;
        //        }
        //        numberPart++;
        //    }
        //    while (kundenNummernList.Contains(newKundenNummer));

        //    if (exists)
        //    {
        //        return newKundenNummer; // Return existing KundenNummer if found
        //    }

        //    // Find the highest existing KundenNummer and increment it
        //    string highestKundenNummer = kundenNummernList.OrderByDescending(kn => kn).First();
        //    numberPart = int.Parse(highestKundenNummer.Substring(2)) + 1;

        //    return $"{prefix} {numberPart:D4}"; // Generate the next KundenNummer

        //    //if (highestKundenNummer == null)
        //    //{
        //    //    // No existing customers for this type, start from 0001
        //    //    return $"{prefix} 0001";
        //    //}

        //    //// Extract the numerical part, increment it, and format it back to the correct string
        //    //int numberPart = int.Parse(highestKundenNummer.Substring(2));
        //    //numberPart++;

        //    //return $"{prefix} {numberPart:D4}"; // D4 ensures leading zeros up to 4 digits
        //}

        internal static Kunde GetParentKundeById()
        {
            //throw new NotImplementedException();
            return null;
        }

        internal static List<Kunde> LoadKundenFromDatabase(string id)
        {
            return KundenDAO.GetKundenByParentId(id);
        }

        internal object UpdateRechnungenFromDatabase()
        {
            throw new NotImplementedException();
        }

        internal void DeleteRechnungen(List<string> selectedRechnungIds)
        {
            throw new NotImplementedException();
        }

        internal void SaveOrUpdateRechnungenToDatabase(List<Rechnung> updateRechnungenList)
        {
            RechnungenDAO.SaveOrUpdateRechnungenToDatabase(updateRechnungenList);
        }
            
        
    }
}
