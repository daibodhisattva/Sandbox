using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //build a connection string
            var connStr = new StringBuilder();
            connStr.Append("SERVER=192.168.80.13;");
            connStr.Append("PORT=33005;");
            connStr.Append("DATABASE=dbonline;");
            connStr.Append("UID=qatest;");
            connStr.Append("PWD=Q@T3st;");
            connStr.Append("Convert Zero Datetime=True;");

            var rdr = new AdoReader(connStr.ToString());

            //extra credit.  Load the rates in a task, then write stats in a task continuewith expression
            var loaderTsk = Task.Factory.StartNew(() => rdr.LoadTaxRates("05017")).ContinueWith(t => Console.WriteLine(rdr.PrintStats()));
            //we can write this out to  see that execution is continuing here even though we triggered a task. We'll see this line printed out
            //before the stats from the line above, since that's on a background thread.
            Console.WriteLine("async DB load happening!");
            
            //leave this here so that we don't kill the program before we're done with our DB query/stats.  This will also make execution pause
            //before the "press any key" close logic come up on the screen.
            loaderTsk.Wait(); //wait for async stuff to go.

            //pause execution for debugging purposes.
            Console.WriteLine("Press any key...");
            Console.ReadKey();

        }
    }
}
