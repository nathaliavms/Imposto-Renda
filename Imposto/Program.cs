using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu salário: ");
            var salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Calcular calculo = new Calcular(salario);

            Console.WriteLine(calculo);

        }
    }
}
