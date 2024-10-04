using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProfªLeticiaExerc03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Double Celsius, Fahrenheit;

            Console.WriteLine("Informe a Temperatura em Celsius: ");
            Temperatura = Convert.ToDouble(Console.ReadLine());
            Fahrenheit = (Celsius * 1.8) + 32;

            Console.WriteLine("Exiba o resultado " +Celsius+ "para" +Fahrenheit);

            Console.ReadKey();

        }
    }
}
