using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    internal class Program
    {

        enum Menu { Soma = 1 , Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) //enquanto o usuario não escolher o Sair , continue a exibir o menu
            {
                Console.WriteLine("Seja bem vindo ao CALC\n\nSelecione uma das Opções:");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao " +
                    "\n5-Potencia\n6-Raiz\n7-Sair");

                /*Opção menos verbosa de conversão de string para enum(menu)*/
                //string opcaoTXT = Console.ReadLine();
                //int opcaoInt = int.Parse(opcaoTXT);
                //Menu opcao = (Menu)opcaoInt


                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:    
                        Multiplicacao();
                        break;
                    case Menu.Potencia: 
                        Potencia();
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
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O Resultado é:{resultado} ");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Subtracao() 
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisao de dois números: ");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O Resultado da divisão é : {resultado} ");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O Resultado da divisão é : {resultado} ");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();
        }
         static void Potencia()
        {
            Console.WriteLine("Potência de um número: ");
            Console.Write("Digite a base: ");
            int  baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo); 
            Console.WriteLine($"O Resultado da divisão é : {resultado} ");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();


        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um número: ");
            Console.Write("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O Resultado da divisão é : {resultado} ");
            Console.WriteLine("Aperte Enter para voltar para o menu");
            Console.ReadLine();


        }


    }
}
