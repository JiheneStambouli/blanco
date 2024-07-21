using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlancoAssist
{
    public class Kunde
    {
        private readonly string _id;

        public string ID
        {
            get { return _id; }
        }
        public string KundenNummer { get; set; }
        public string Name => $"{LastName}, {FirstName}";
        public string Address { get; set; }
        public KundenType Type { get; set; }

        public List<Rechnung> Rechnungen { get; set; }

        public string VersichererID { get; set; }
        public Versicherer _versicherer;
        public Versicherer Versicherer {
            get => _versicherer;
            set
            {
                _versicherer = value;
                if (_versicherer != null)
                {
                    VersichererID = _versicherer.ID;

                }
            }
        }
        public string Zeichen { get; set; }


        /// <summary>
        /// new properties
        /// </summary>

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime CreationDate { get; set; }


        public Kunde(string kundenNummer, KundenType ktype, Versicherer versicherer)
        {
            _id = Guid.NewGuid().ToString();
            Type = ktype;
            KundenNummer = kundenNummer;
            
            Rechnungen = new List<Rechnung>();

            //FirstName = firstName; LastName = this.LastName;
            //Birthdate = Birthdate; CreationDate = creationDate;

            //if (this.Versicherer != null)
            //{
            //    this.Versicherer = versicherer;
            //    this.VersichererID = this.Versicherer.ID;
            //}
        }


        public Kunde(KundenType ktype, string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("ID cannot be null or empty.", nameof(id));
            }
            _id = id;
            Type = ktype; 
            //KundenNummer = this.GetNewKundenNummer(ktype);
            this.Rechnungen = LoadRechnungenFromDatabase();
        }

        public List<Rechnung> LoadRechnungenFromDatabase()
        {
            RechnungenDAO rechnungenDAO = new RechnungenDAO(); // Assuming ServiceDAO is implemented and available
            return rechnungenDAO.GetRechnungByParentId(this.ID);
        }
    }

    public enum KundenType
    {
        H, // Haushilfe
        P, // Privat
        E, // Entlastung
        V, // Verhinderung
        R, // Renovierung
        G  // Gebäudereinigung
    }

    public static class KundenTypeExtensions
    {
        public static string GetFullName(this KundenType type)
        {
            switch (type)
            {
                case KundenType.H:
                    return "Haushilfe";
                case KundenType.P:
                    return "Privat";
                case KundenType.E:
                    return "Entlastung";
                case KundenType.V:
                    return "Verhinderung";
                case KundenType.R:
                    return "Renovierung";
                case KundenType.G:
                    return "Gebäudereinigung";
                default:
                    return string.Empty;
            }
        }
    }
}
