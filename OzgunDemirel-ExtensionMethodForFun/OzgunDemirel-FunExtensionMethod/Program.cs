using System;
using System.Runtime.InteropServices.WindowsRuntime;
using FunExtensionMethod.Extensions;

namespace FunExtensionMethod
{
    class Program

    {
        

        static void Main(string[] args)
        {
            
            Console.WriteLine("Lütfen adınızı küçük harflerle yazınız: ");
            string name = Console.ReadLine();
            Console.WriteLine("2021 yılı numeroloji tahmininiz: " );
            Console.WriteLine(name.NameNumerologyCalculator());


        }
    }

}