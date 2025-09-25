using System;

namespace Projeto_Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora Simples!");
            Console.WriteLine("---------------------------------");

            while (true)
            {
                Console.WriteLine("
Escolha uma operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "5")
                {
                    break;
                }

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                    continue;
                }

                Console.Write("Digite o segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                    continue;
                }

                double resultado = 0;
                switch (opcao)
                {
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero.");
                            continue;
                        }
                        break;
                }

                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.WriteLine("Obrigado por usar a Calculadora Simples!");
        }
    }
}