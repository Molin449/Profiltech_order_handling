using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfiltechOrderHandling.Model {
    public class ShippingLine {
        public int id { get; set; }
        public string method_title { get; set; }
        public string method_id { get; set; }
        public string instance_id { get; set; }
        public string total { get; set; }
        public string total_tax { get; set; }
        public List<object> taxes { get; set; }
        public List<MetaData> meta_data { get; set; }
    }
}
