using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Potter
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static double GetDiscount(List<string> titles)
        {
            var DeduplicatedTitles = RemoveRepeated(titles);
            var TotalBooks = titles.Count();
            if (DeduplicatedTitles.Count==TotalBooks)
                return 

        }

        public static List<string> RemoveRepeated(List<string> titles)
        {
            return titles.Distinct().ToList();
        }
    }
}

