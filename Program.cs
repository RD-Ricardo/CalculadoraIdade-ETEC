using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Data  de nascimentos
            DateTime tempBirthDate = new DateTime(2004, 08 , 04).Date;
            string date = tempBirthDate.ToShortDateString();
            //Data de Agora
            DateTime dateNow = DateTime.Now;
            // Data de nascimento em dias
            TimeSpan tempBirth = dateNow - tempBirthDate;
            int dateDays = tempBirth.Days;
            Console.WriteLine("---------------------");
            Console.WriteLine("--Calculadora Idade--");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Eu nasci {date} e já vivi {dateDays} dias.");
        }
    }
}
