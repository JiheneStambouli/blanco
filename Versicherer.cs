using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlancoAssist
{
    public class Versicherer
    {
        private readonly string _id;

        public string ID
        {
            get { return _id; }
        }

        public string Name { get; set; }
        public string Address { get; set; }

        public List<Kunde> Kunden { get; set; }

        public Versicherer(string name, string address)
        {
            _id = Guid.NewGuid().ToString();

            this.Name = name;
            this.Address = address;

            Kunden = new List<Kunde>();

        }

        public Versicherer(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("ID cannot be null or empty.", nameof(id));
            }
            _id = id;

            this.Kunden = Helper.LoadKundenFromDatabase(this.ID);
        }

        
    }

}
