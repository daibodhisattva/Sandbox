using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Solution
{
    class TaxRateData
    {
        public string ClientCode { get; set; }
        public string TaxCode { get; set; }
        public int TaxType { get; set; }
        public decimal Rate { get; set; }
        public DateTime EffDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UpdateBy { get; set; }
    }
}
