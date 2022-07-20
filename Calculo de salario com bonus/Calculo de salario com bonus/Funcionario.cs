using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_salario_com_bonus
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public double SalarioFixo { get; set; }

        public double ValorVendas { get; set; }

        public double CalculaSalario(double porcentagem)

        {
            return (ValorVendas * porcentagem) / 100 + SalarioFixo;
        }
    }
}
