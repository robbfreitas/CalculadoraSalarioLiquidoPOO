using System.Globalization;

namespace CalculadoraSalarioLiquidoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();

            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: {0}, $ {1}", func1.Nome, func1.SalarioLiquido());

            Console.Write("Digite a porcentagem de aumento salarial: ");
            double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func1.AumentarSalario(Porcentagem);

            Console.WriteLine("Dadaos atutalizados: {0}, {1}", func1.Nome, func1.SalarioLiquido());
        }
    }
}