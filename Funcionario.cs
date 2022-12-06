using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSalarioLiquidoPOO
{
    internal class Funcionario
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Porcentagem;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }
    }
}
