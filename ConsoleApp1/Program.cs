using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potencia, Raiz, Sair }


        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja Bem Vindo a Calculadora, Selecione uma das Opções:");
                Console.WriteLine("1-Soma");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Divisão");
                Console.WriteLine("4-Multiplicação");
                Console.WriteLine("5-Potencia");
                Console.WriteLine("6-Raiz");
                Console.WriteLine("7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtração:
                        Sub();
                        break;
                    case Menu.Divisão:
                        Div();
                        break;
                    case Menu.Multiplicação:
                        Multi();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;


                }



                Console.Clear();

            }



        }
        static void Soma()
        {
            Console.WriteLine("Soma de Dois numeros ");
            Console.Write("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"Resultado Final: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar pro Menu!");
            Console.ReadLine();

        }
        static void Sub()
        {
            Console.WriteLine("Subtração de Dois numeros ");
            Console.Write("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"Resultado Final: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar pro Menu!");
            Console.ReadLine();

        }
        static void Div()
        {
            Console.WriteLine("Divisão de Dois numeros ");
            Console.Write("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"Resultado Final: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar pro Menu!");
            Console.ReadLine();

        }
        static void Multi()
        {
            Console.WriteLine("Multiplicação de Dois numeros ");
            Console.Write("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"Resultado Final: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar pro Menu!");
            Console.ReadLine();

        }
        static void Pot()
        {
            Console.WriteLine("Potencia de um numero ");
            Console.Write("Digite a Base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o Expoente: ");
            int Expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, Expo);
            Console.WriteLine($"Resultado Final: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar pro Menu!");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero ");
            Console.Write("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"Resultado Final: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar pro Menu!");
            Console.ReadLine();
        }


    }    


}
