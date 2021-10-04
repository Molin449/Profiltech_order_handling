using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfiltechOrderHandling.Model {
    public class LineItem {
        public int id { get; set; }
        public string name { get; set; }
        public int product_id { get; set; }
        public int variation_id { get; set; }
        public int quantity { get; set; }
        public string tax_class { get; set; }
        public string subtotal { get; set; }
        public string subtotal_tax { get; set; }
        public string total { get; set; }
        public string total_tax { get; set; }
        public List<Tax> taxes { get; set; }
        public List<MetaData> meta_data { get; set; }
        public string sku { get; set; }
        public double price { get; set; }
        public string parent_name { get; set; }
    }
}
