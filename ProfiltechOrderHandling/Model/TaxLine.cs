using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfiltechOrderHandling.Model {
    public class TaxLine {
        public int id { get; set; }
        public string rate_code { get; set; }
        public int rate_id { get; set; }
        public string label { get; set; }
        public bool compound { get; set; }
        public string tax_total { get; set; }
        public string shipping_tax_total { get; set; }
        public int rate_percent { get; set; }
        public List<object> meta_data { get; set; }
    }
}
