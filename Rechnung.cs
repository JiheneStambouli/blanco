using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlancoAssist
{
    public class Rechnung
    {
        private readonly string _id;

        public string ID
        {
            get { return _id; }
        }

        private string rechnungNr; 
        public string RechnungNr {
            get { return rechnungNr; }
            set
            {
                if (rechnungNr != value)
                {
                    rechnungNr = value;
                }
            }
        }

        public DateTime BeginDate {  get; set; }
        public DateTime EndDate {  get; set; }
        public string Zeitraum
        {
            get
            {
                return BeginDate.ToString("dd.MM.yyyy") + " - " + EndDate.ToString("dd.MM.yyyy");
            }
        }

        public string ParentId { get; set; }

        //public Kunde ParentKunde { get; set; }
        private Kunde _parentKunde;
        public Kunde ParentKunde
        {
            get => _parentKunde;
            set
            {
                _parentKunde = value;
                if (_parentKunde != null)
                {
                    ParentId = _parentKunde.ID;

                }
            }
        }

        public string KundenNr
        {
            get { return ParentKunde?.KundenNummer; }
        }

        public string KundenName
        {
            get { return ParentKunde?.Name; }
        }

        public string Zeichen
        {
            get { return ParentKunde?.Zeichen; }
        }

        public KundenType Type
        {
            get { return ParentKunde.Type; }
        }

        public string Empfaenger
        {
            get
            {
                if (ParentKunde != null)
                {
                    if (ParentKunde.Versicherer != null)
                    {
                        return $"{ParentKunde.Versicherer.Name}\n{ParentKunde.Versicherer.Address}";
                    }
                    else
                    {
                        return $"{ParentKunde.Name}\n{ParentKunde.Address}";
                    }
                }
                else
                {
                    return string.Empty; // Or any default value you prefer if ParentKunde is null
                }
            }
        }

        public DateTime Datum {  get; set; }

        public string Gruss { get; set; }
        public string Intro { get; set; }
        public string EndGruss { get; set; }

        public string Content { get; set; }

        public List<Service> Services { get; set; }

        public float GesamtRechnungPreis { get; set; }
        public float Stunden { get; set; }
        public float Bezahlt { get; set; }
        public DateTime DatumBezahlt { get; set; }

        public float Rest
        {
            get { return GesamtRechnungPreis - Bezahlt; }
        }

        public enum RechnungStatus
        {
            none,
            Offen,
            Bearbeitung,
            Bezahlt
        }

        private RechnungStatus _status;
        public RechnungStatus Status
        {
            get
            {
                UpdateStatus();
                return _status;
            }
            private set { _status = value; }
        }

        public DateTime FaelligAm { get; set; }


        public Rechnung(Kunde parent) {

            _id = Guid.NewGuid().ToString();
            Services = new List<Service>();
            this.ParentKunde = parent;
            this.Datum = DateTime.Now;
            Bezahlt = 0;
        }

        public Rechnung(string id, Kunde parent)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("ID cannot be null or empty.", nameof(id));
            }
            _id = id;

            Services = new List<Service>();
            this.ParentKunde = parent;
            this.Datum = DateTime.Now;
            Bezahlt = 0;
        }

        private void UpdateStatus()
        {
            if(GesamtRechnungPreis == 0 && Rest == 0)
            {
                Status = RechnungStatus.none;
            }
            else if (Rest == 0)
            {
                Status = RechnungStatus.Bezahlt;
            }
            else if (Rest > 0 && Rest < GesamtRechnungPreis)
            {
                Status = RechnungStatus.Bearbeitung;
            }
            else 
            {

                Status = RechnungStatus.Offen; 
            }
        }
    }

}
