using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Uso: dotnet run <num1> <operação> <num2>");
            return;
        }

        if (!double.TryParse(args[0], out double num1))
        {
            Console.WriteLine("Erro: O primeiro argumento não é um número válido.");
            return;
        }

        string operacao = args[1];

        if (!double.TryParse(args[2], out double num2))
        {
            Console.WriteLine("Erro: O terceiro argumento não é um número válido.");
            return;
        }

        double resultado = 0;

        switch (operacao)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operação inválida! Use +, -, *, /");
                return;
        }

        Console.WriteLine($"O resultado é: {resultado}");
    }
}
