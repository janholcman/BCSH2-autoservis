using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Chyba: {ex.Message}");
            }
        }
    }
}
