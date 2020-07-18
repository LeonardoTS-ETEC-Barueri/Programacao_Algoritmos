using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtvArrays_0713_PA
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("=  Atividade Arrays [13.07.2020]  =");
            Console.WriteLine("=---------------------------------=");
            Console.WriteLine("= 1 - Lista de Salários           =");
            Console.WriteLine("= 2 - Leitor de números reais     =");
            Console.WriteLine("= 3 - Listagem de Alunos          =");
            Console.WriteLine("= 0 - Sair                        =");
            Console.WriteLine("=---------------------------------=");

            int opc;
            bool fimLoop = false;

            do
            {
            Comeco:
                try
                {
                    Console.Write("- Digite a opção desejada: ");
                    opc = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite apenas números...");
                    goto Comeco;
                }

                switch (opc)
                {
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine("Okay, até a próxima!");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        fimLoop = true;
                        break;
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Iniciando" + '"' + "Lista de Salários" + '"' + " ...");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        fimLoop = true;
                        salarios();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Iniciando" + '"' + "Leitor de números reais" + '"' + " ...");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        fimLoop = true;
                        vReais();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Iniciando" + '"' + "Listagem de Alunos" + '"' + " ...");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        fimLoop = true;
                        listaAlunos();
                        break;
                    default:
                        Console.WriteLine("Digite apenas as opções permitidas");
                        break;
                }
            } while (fimLoop == false);
        }

        public static void salarios()
        {
            string[] nome = new string[5];
            double[] salario = new double[5];
            var rand = new Random();

            nome[0] = "Afonso";
            nome[1] = "Bela";
            nome[2] = "Celine";
            nome[3] = "Diego";
            nome[4] = "Elly";

            Console.WriteLine("== Valores Atuais ==");

            for (int count = 0; count < 5; count++ ) {
                Console.Write("[ {0} ] recebe R$: ", nome[count]);
                salario[count] = (500 + (rand.NextDouble() * (1100 - 500)));
                Console.WriteLine("{0:0.00}", salario[count]);
            }

            Console.WriteLine();
            Console.WriteLine("== Valores Atualizados ==");

            for (int count = 0; count < 5; count++)
            {
                if (salario[count] < 1000.0)
                {
                    salario[count] += (salario[count] * 0.10);
                    //Console.WriteLine();
                    //Console.WriteLine("[ {0} ] ganhou um aumento de 10% do seu salário por receber menos que R$: 1.000,00", nome[count]);
                    //Console.WriteLine("Seu salário agora é {0:0.00}", salario[count]);
                    //Console.WriteLine();
                }

                Console.WriteLine("[ {0} ] recebe R$: {1:0.00} ", nome[count], salario[count]);
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
            Console.Clear();
            menu();

        }

        public static void vReais()
        {
            List<double> numReal = new List<double>();
            string resp;
            do
            {
                Comeco: 
                try { 
                    Console.Write("Digite um número real: ");
                    numReal.Add(double.Parse(Console.ReadLine()));
                } catch (FormatException)
                {
                    Console.WriteLine("Digite apenas números...");
                    goto Comeco;
                }

                Console.WriteLine();
                Console.WriteLine("Deseja adicionar outro número?");
                Console.Write("[S/N]: ");
                resp = Console.ReadLine();
                Console.WriteLine();
            } while (resp == "sim" || resp == "s");

            Console.WriteLine();
            Console.WriteLine("Você adicionou {0} valores", numReal.Count());
            Console.Write("Sendo eles: ");

            int contador = 1;
            foreach (double items in numReal)
            {
                Console.Write("{0:0.00}", Math.Round(items,2));
                if (contador < numReal.Count())
                {
                    Console.Write(" ; ");
                } else
                {
                    Console.WriteLine(".");
                }
                contador++;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
            Console.Clear();
            menu();

        }

        public static void listaAlunos()
        {
            var rnd = new Random();
            int qtd = 0;
            Console.WriteLine("Quantos alunos serão analizados?");
            Comeco: 
            try {
                Console.Write("Quantidade: ");
                qtd = int.Parse(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Informe apenas números...");
                goto Comeco;
            }

            int[] qtdAlunos = new int[qtd];

            double[] g1 = new double[qtd];
            double[] g2 = new double[qtd];
            double[] media = new double[qtd];

            Console.WriteLine();
            Console.WriteLine("== Lista de Desempenho dos Alunos ==");
            Console.WriteLine();
            for (int c = 0; c < qtdAlunos.Count(); c++)
            {
                g1[c] = rnd.NextDouble() * 10;
                g2[c] = rnd.NextDouble() * 10;
                media[c] = (g1[c] + g2[c]) / 2;

                Console.WriteLine("[Aluno {0}] - [ Nota G1: {1:0.00} ] - [ Nota G2: {2:0.00} ] - [ Média: {3:0.00} ]", (c+1), g1[c], g2[c], media[c]);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
            Console.Clear();
            menu();
        }
    }
}
