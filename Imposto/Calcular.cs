using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Calcular
    {
        public double Salario { get; private set; }
       
        public Calcular(double salario)
        {
            Salario = salario;
        }
        private double DescontoImposto()
        {
            double[] faixa1 = new double[] { 0, 2000 };
            double[] faixa2 = new double[] { 2000.01, 3000 };
            double[] faixa3 = new double[] { 3000.01, 4500 };

            if (Salario > faixa1[0] && Salario <= faixa1[1])
            {
                return 0;
            }
            else if (Salario >= faixa2[0] && Salario <= faixa2[1])
            {
                return (Salario - 2000) * 0.08;
            }
            else if (Salario >= faixa3[0] && Salario <= faixa3[1])
            {
                return (Salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                return (Salario - 4500) * 0.28 + 1000 * 0.08 + 1500 * 0.18 ;
            }
        }
        public override string ToString()
        {
            var desconto = DescontoImposto();
            return desconto == 0 ? "Isento" : "R$ " + desconto.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
