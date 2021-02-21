using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto01 = new Auto("SUV", 20000);
            Auto auto02 = new Auto(25000);
            
            
            Console.WriteLine("Jetzt kommt Auto 01:");
            auto01.SetGeschwindigkeit(130);
            auto01.Fahr();
            auto01.SetHupton("heee");
            auto01.Hupe();
            
            Console.WriteLine("Jetzt kommt Auto 02:");
            auto02.SetGeschwindigkeit(100); 
            auto02.Fahr();
            auto02.SetHupton("hooo");
            auto02.Hupe();
            auto02.SetHupton("hiii");
            auto02.Hupe();
            auto02.SetGeschwindigkeit(120);
            auto02.Fahr();
            auto02.Schrittgeschwindigkeit();
            auto02.Fahr();






            Console.ReadKey();


        }
    }
}
