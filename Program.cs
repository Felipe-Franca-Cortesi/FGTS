using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            double porcentagemEntrada = 8;

            Console.Clear();
            Console.WriteLine("----FGTS");
            Console.Write("Informe o valor do salário (R$)..: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            
            double contaPorcentagem = porcentagemEntrada / 100 * salario;
            Console.WriteLine($"FGTS (R$): {contaPorcentagem}");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
