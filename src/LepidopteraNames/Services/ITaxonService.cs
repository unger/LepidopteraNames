using System.Collections.Generic;
using LepidopteraNames.Models;

namespace LepidopteraNames.Services
{
    public interface ITaxonService
    {
        List<Taxon> Search(string search);
    }
}