using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LepidopteraNames.Models;
using Newtonsoft.Json;

namespace LepidopteraNames.Services
{
    public class TaxonService : ITaxonService
    {
        private List<Taxon> taxons;

        public TaxonService()
        {
            taxons = Load<List<Taxon>>();
        } 

        public List<Taxon> Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return new List<Taxon>();
            }
            return taxons.Where(t => this.Contains(t.Name, search) || this.Contains(t.ScientificName, search)).ToList();
        }

        private bool Contains(string str, string value)
        {
            return str.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) > -1;
        }

        private T Load<T>() where T : new()
        {
            var assemblyType = typeof(App);
            var resource = string.Format("{0}.{1}.json", assemblyType.Namespace, "taxons");

            try
            {
                using (var stream = assemblyType.GetTypeInfo().Assembly.GetManifestResourceStream(resource))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("Embedded resource '{0}' could not be interpreted: {1}", resource, e.Message));
            }
        }

    }
}
