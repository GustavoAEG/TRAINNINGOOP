using System;
class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Selecione o funcionário para listar os valores:");
            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Subgerente");
            Console.WriteLine("3 - Secretario");
            Console.WriteLine("4 - Sair");

            int opcao = int.Parse(Console.ReadLine());


            
        }
        Gerente g = new Gerente();

        Console.WriteLine("Salário: " + g.CalcularSalario());


    }
}

// Definições das classes Funcionario, Gerente, Subgerente, Secretario
