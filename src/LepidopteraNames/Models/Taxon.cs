using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepidopteraNames.Models
{
    public class Taxon
    {
        public int ArtId { get; set; }
        public int DyntaxaId { get; set; }
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public string Auctor { get; set; }
    }
}
