using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    Sair();
                    break;
                default:
                    Menu();
                    break;
            }
        }
        static void Sair()
        {
            Console.WriteLine("Obrigado por usar o nosso aplicativo!");
            System.Environment.Exit(0);
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 + valor2;

            Console.WriteLine("O resultado da adição de {0} + {1} é {2}.", valor1, valor2, resultado.ToString("F2"));
            Console.WriteLine("Tecle Enter para voltar ao Menu");
            Console.ReadKey();

            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = -(valor1 - valor2);

            Console.WriteLine("O resultado da subtração de {0} - {1} é {2}.", valor1, valor2, resultado.ToString("F2"));
            Console.WriteLine("Tecle Enter para voltar ao Menu");
            Console.ReadKey();

            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 / valor2;

            Console.WriteLine("O resultado da divisão de {0} / {1} é {2}.", valor1, valor2, resultado.ToString("F2"));
            Console.WriteLine("Tecle Enter para voltar ao Menu");
            Console.ReadKey();

            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 * valor2;

            Console.WriteLine("O resultado da divisão de {0} * {1} é {2}.", valor1, valor2, resultado.ToString("F2"));
            Console.WriteLine("Tecle Enter para voltar ao Menu");
            Console.ReadKey();

            Menu();
        }
    }
}
