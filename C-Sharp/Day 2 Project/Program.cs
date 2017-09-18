using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //build a connection string
            var connStr = new StringBuilder();
            connStr.Append("SERVER=devdb00.paycomhq.com;");
            connStr.Append("PORT=33005;");
            connStr.Append("DATABASE=dbonline;");
            connStr.Append("UID=qatest;");
            connStr.Append("PWD=Q@T3st;");
            connStr.Append("Convert Zero Datetime=True;");

            // Use client code 05000

            DBConnector db = new DBConnector(connStr.ToString());
            db.readFromDB("05000");

            var taxrate_list = db.getTaxRateList();

            foreach (var taxrate in taxrate_list)
            {
                Console.WriteLine(taxrate);
                Console.WriteLine("************************************************");
            }

            Console.WriteLine(db.getRateStats());

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
    }
}
