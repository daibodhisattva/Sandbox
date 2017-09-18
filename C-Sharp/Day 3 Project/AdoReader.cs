using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Day3Solution
{
    class AdoReader
    {
        private string _connStr;
        private IList<TaxRateData> _taxRates;

        /// <summary>
        /// This is an XML comment block. this will affect Intellisense and can be used to create documentation too.
        /// </summary>
        /// <param name="connStr"></param>
        public AdoReader(string connStr)
        {
            _connStr = connStr;
            _taxRates = new List<TaxRateData>();
        }

        /// <summary>
        /// Load tax rates for a given client code. if the tax rates already exist, they will be overwritten.
        /// </summary>
        /// <param name="clientCode"></param>
        public void LoadTaxRates(string clientCode)
        {
            //select statement for the table
            string selTaxRates =
             "SELECT clientcode, taxcode, taxtype, rate, effdate, enddate, lastupdate, updateby  FROM cl_taxrate WHERE ClientCode = ?CliCode";

            //ensure the collection is created, then empty items from it.
            if (_taxRates == null)
            {
                _taxRates = new List<TaxRateData>();
            }
            _taxRates.Clear();


            //start off by creating the connection.  Connections implement IDispoable, so make sure you wrap it up in a using blcok
            using (MySqlConnection conn = new MySqlConnection(_connStr))
            {
                conn.Open();

                //command associated with the connection
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = selTaxRates;

                    //client code parameter
                    var param = new MySqlParameter("CliCode", MySqlDbType.VarChar);
                    param.Value = clientCode; //parameter value is set to the value passed in.
                    cmd.Parameters.Add(param);

                    //get the cursor back.
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())  
                        {
                            //a new row, a new object. Make it and add it to our list to return!
                            var tr = new TaxRateData();

                            tr.ClientCode = rdr.GetString(rdr.GetOrdinal("ClientCode"));
                            tr.TaxCode = rdr.GetString(rdr.GetOrdinal("taxcode"));
                            tr.TaxType = rdr.GetInt32(rdr.GetOrdinal("taxtype"));
                            tr.Rate = rdr.GetDecimal(rdr.GetOrdinal("rate"));
                            tr.EffDate = rdr.GetDateTime(rdr.GetOrdinal("EffDate"));
                            tr.EndDate = rdr.GetDateTime(rdr.GetOrdinal("enddate"));
                            tr.LastUpdate = rdr.GetDateTime(rdr.GetOrdinal("lastupdate"));
                            tr.UpdateBy = rdr.GetString(rdr.GetOrdinal("updateby"));

                            //make sure it gets added to our member list variable
                            _taxRates.Add(tr);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Given a set of tax rates, will generate a report on basic statistics.
        /// </summary>
        /// <returns>a min/max/avg and count of tax rates currently loaded</returns>
        /// <remarks>If there are no tax rates loaded, a bail message will be returned instead.</remarks>
        public string PrintStats()
        {
            if(_taxRates.Count <= 0)
            {
                return "No Tax Rates were loaded. Bailing.";
            }

            decimal minval = _taxRates.Min(tr => tr.Rate);
            decimal maxval = _taxRates.Max(tr => tr.Rate);
            decimal avg = _taxRates.Average(tr => tr.Rate);
            int count = _taxRates.Count;

            //print out the numbers, with the hundredths decimal places required, and the thousandths & ten-thousandths places to print if they are non-zero
            return string.Format("Count: {0}, MinRate: {1}, Maxrate: {2}, AvgRate: {3}", 
                            count, minval.ToString("0.00##"), maxval.ToString("0.00##"), avg.ToString("0.00##"));
        }
    }
}
