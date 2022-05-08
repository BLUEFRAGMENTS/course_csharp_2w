using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlleMineVenner.TilrettelagtMateriale
{
    internal class Person
    {
        public Person()
        {
            TøjEjet = new List<string>();
        }

        public string? Fornavn { get; set; }

        public string? Efternavn { get; set; }

        public int Alder { get; set; }

        public bool BrugerBriller { get; set; }

        public Lande Land { get; set; }

        public List<string> TøjEjet { get; set; }
    }
}
