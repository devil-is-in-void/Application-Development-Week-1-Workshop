using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetailsAppWeek1Workshop
{
    internal class Quote
    {
        private string quote;
        public Quote()
        {
            quote = "The best way to predict the future is to create it. - Peter Drucker";
        }

        public void PrintQuote()
        {
            Console.WriteLine("=== Inspirational Quote ===");
            Console.WriteLine(quote);
        }
    }
}
