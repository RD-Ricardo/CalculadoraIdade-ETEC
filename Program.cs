using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Data  de nascimentos
            DateTime  age = new DateTime(2004, 08 , 04).Date;
            string date = age.ToShortDateString();
            DateTime now = DateTime.Now;
            // Data de nascimento em dias
            TimeSpan tempBirth = now - age;
            int days = tempBirth.Days;
            Console.WriteLine("---------------------");
            Console.WriteLine("--Calculadora Idade--");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Eu nasci {date} e já vivi {days} dias.");
        }
    }
}
