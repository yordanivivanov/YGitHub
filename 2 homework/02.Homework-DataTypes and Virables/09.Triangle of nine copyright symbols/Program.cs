using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_of_nine_copyright_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char copyRight = '©';
            Console.OutputEncoding = Encoding.UTF8; //без този ред не излиза правилно в конзолата
            Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", copyRight);       
               
        }
    }
}
