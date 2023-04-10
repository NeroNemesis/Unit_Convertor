using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Shared.Models
{
    public class Weight
    {
        public Guid Id { get; set; }
        public string Ufrom { get; set; }
        public string Uto { get; set; }
        public List<Unit> Units { get; set; } = new List<Unit>();
        public List<Factor> Factors { get; set; } = new List<Factor>();
    }
}
