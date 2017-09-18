using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class TaxRateData
    {
        public string clientcode { get; set; }
        public string taxcode { get; set; }
        public int taxtype { get; set; }
        public decimal rate { get; set; }
        public DateTime effdate { get; set; }
        public DateTime enddate { get; set; }
        public DateTime lastupdate { get; set; }
        public string updateby { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("ClientCode: " + clientcode);
            builder.Append("\nTaxCode: " + taxcode);
            builder.Append("\nTaxType: " + taxtype);
            builder.Append("\nRate: " + rate);
            builder.Append("\nEffDate: " + effdate);
            builder.Append("\nEndDate: " + enddate);
            builder.Append("\nLastUpdate: " + lastupdate);
            builder.Append("\nUpdateBy: " + updateby);

            return builder.ToString();
        }
    }
}
