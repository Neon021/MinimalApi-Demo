using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class BandModel
    {
        public int bandId { get; set; }
        public string? name { get; set; } = null;
        public string[]? genres { get; set; }
        public string[]? albums { get; set; }
    }
}
