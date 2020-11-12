using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenDrugiZadatak12112020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite niz znakova: ");
            string a = Console.ReadLine();
            a = a.Replace(" ", "_");
            Console.WriteLine(a);
            

            Console.ReadKey();
        }
    }
}
