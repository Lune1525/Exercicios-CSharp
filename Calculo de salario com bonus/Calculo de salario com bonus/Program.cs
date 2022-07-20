using System;

namespace Calculo_de_salario_com_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Calculo do salário final com comissão");
            Funcionario vendedor = new Funcionario();
            Console.WriteLine("Digite seu Nome: ");
            vendedor.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu salario: ");
            vendedor.SalarioFixo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor vendido esse mês: ");
            vendedor.ValorVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"TOTAL = R$ {vendedor.CalculaSalario(15).ToString("F2")}");
        }
    }
}
