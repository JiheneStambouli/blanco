using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlancoAssist
{
    public class Service
    {
        private readonly string _id;

        public string ID
        {
            get { return _id; }
        }

        private readonly string _gesamtPreis;

        public string Gesamtpreis
        {
            get { return _gesamtPreis; }
        }

        public string ParentId { get; private set; } // ID of the parent Rechnung
        public string Pos { get; set; }
        public string Beschreibung { get; set; }
        public string Menge { get; set; }
        public string Einzelpreis { get; set; }

        private Rechnung _parentRechnung;
        public Rechnung ParentRechnung
        {
            get => _parentRechnung;
            set
            {
                _parentRechnung = value;
                if (_parentRechnung != null)
                {
                    ParentId = _parentRechnung.ID;

                }
            }
        }

        public Service(Rechnung parent) 
        {
            _id = Guid.NewGuid().ToString();
            this.ParentRechnung = parent;
            _gesamtPreis = CalculateGesamtpreis();
        }

        public Service(string id, Rechnung parent)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("ID cannot be null or empty.", nameof(id));
            }
            _id = id;

            this.ParentRechnung = parent;
        }

        private string CalculateGesamtpreis()
        {
            // Convert Menge and Einzelpreis to numeric values for calculation
            if (decimal.TryParse(Menge, out decimal mengeValue) && decimal.TryParse(Einzelpreis, out decimal einzelpreisValue))
            {
                // Calculate Gesamtpreis and format it to display as string with currency symbol
                decimal gesamtpreisValue = mengeValue * einzelpreisValue;
                return gesamtpreisValue.ToString("C");
            }
            else
            {
                return "Invalid"; // Or handle error as needed
            }
        }
    }
}
