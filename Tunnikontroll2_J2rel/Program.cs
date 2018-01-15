using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll2_J2rel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta erinevaid sõnu, lõpetamiseks sisest -1 ");

            string input = " ";

            List<string> sõnad = new List<string>();


            while (input != "-1")
            {
                Console.Write("Sisesta sõna: ");
                input = Console.ReadLine();
                if (input != "-1")
                {
                    sõnad.Add(input);
                }
                
            }

            Console.WriteLine("Sisetatud sõnad: ");
        
            Console.WriteLine(String.Join(" ,", sõnad));

            Console.WriteLine("Valin nendest välja suvalise sõna: ");
            Random rnd = new Random();
            int suvalineSõna = rnd.Next(0, sõnad.Count);
            Console.Write(sõnad[suvalineSõna]);

            
            Console.ReadKey();



           
            
        }
    }
}
