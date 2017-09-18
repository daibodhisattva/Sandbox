using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Day2Assignment
{
    class DBConnector
    {
        private string connection;
        private List<TaxRateData> taxrate_list;

        public DBConnector(string connection)
        {
            this.connection = connection;    
        }

        public void readFromDB(string clientcode) 
        {
            if (taxrate_list == null)
            {
                taxrate_list = new List<TaxRateData>();
            }

            taxrate_list.Clear();

            using (MySqlConnection sql_connection = new MySqlConnection(connection))
            {
                sql_connection.Open();
                
                string cmd_text = "SELECT * FROM cl_taxrate WHERE clientcode=?clientcode ";
                using (MySqlCommand cmd = sql_connection.CreateCommand())
                {
                    cmd.CommandText = cmd_text;

                    var parameter = new MySqlParameter("clientcode", MySqlDbType.VarChar);
                    parameter.Value = clientcode;

                    cmd.Parameters.Add(parameter);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) 
                    {                     
                        while(reader.Read()) 
                        {
                            TaxRateData txd = new TaxRateData();

                            txd.clientcode = reader.GetString(reader.GetOrdinal("clientcode"));
                            txd.taxcode = reader.GetString(reader.GetOrdinal("taxcode"));
                            txd.taxtype = reader.GetInt32(reader.GetOrdinal("taxtype"));
                            txd.rate = reader.GetDecimal(reader.GetOrdinal("rate"));
                            txd.effdate = reader.GetDateTime(reader.GetOrdinal("effdate"));
                            txd.enddate = reader.GetDateTime(reader.GetOrdinal("enddate"));
                            txd.lastupdate = reader.GetDateTime(reader.GetOrdinal("lastupdate"));
                            txd.updateby = reader.GetString(reader.GetOrdinal("updateby"));

                            taxrate_list.Add(txd);
                        }
                        
                    }
                }
            }
        }

        public List<TaxRateData> getTaxRateList()
        {
            return taxrate_list;
        }

        public string getRateStats()
        {
            decimal min = taxrate_list.Min(tax => tax.rate);
            decimal max = taxrate_list.Max(tax => tax.rate);
            decimal average = taxrate_list.Average(tax => tax.rate);
            decimal count = taxrate_list.Count();

            return string.Format("Tax Rate Stats:\nMin: {0}, Max: {1}, Average: {2}, Count: {3}", min, max, average, count);
        }
    }
}
