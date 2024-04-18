using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDanceMAUI.Model
{
    public class RecordLocation
    {
        public string Stato { get; set; }
        public string Regione { get; set; }
        public string Provincia { get; set; }
        public string Sindaco { get; set; }
        public Coordinate Coordinate { get; set; }
        public int Altitudine { get; set; }
        public string Superficie { get; set; }
        public string Abitanti { get; set; }
        public string Densità { get; set; }
        public string Stemma { get; set; }
    }
}
