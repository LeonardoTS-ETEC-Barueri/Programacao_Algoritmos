using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atv_LoopsFinalS1_0607_PA
{
    class Program
    {
        static void Main(string[] args)
        {
            bool EhLetra;
            string entrada, qtdProduto;
            string maisPedidos;
            List<double> vTotPedidos = new List<double>();
            List<string> totPedidos = new List<string>();

        // Começo do cardápio de Lanches. 

            string[] codLanches = { "101", "102", "103", "201", "202" };

            // Apresentação do cardápio de Lanches.

            Console.WriteLine("=========================================");
            Console.WriteLine("= LAN XONETE - Cardápio de LANCHES      =");
            Console.WriteLine("=========================================");
            Console.WriteLine("= Produto      |   Código  |   Preço    =");
            Console.WriteLine("=---------------------------------------=");
            Console.WriteLine("= Coxinha      |   101     |  R$: 3,50  =");
            Console.WriteLine("= Bauru        |   102     |  R$: 4,00  =");
            Console.WriteLine("= Pizza        |   103     |  R$: 6,00  =");
            Console.WriteLine("= Batatinhas   |   201     |  R$: 5,50  =");
            Console.WriteLine("= Doce Abóbora |   202     |  R$: 1,50  =");
            Console.WriteLine("=========================================");

            
            do 
            { // Loop caso usuário desejar pedir outra coisa.

                do
                { // Início do Pedido - Verifica entrada do usuário.
                    Console.Write("- Digite o código do seu pedido: ");
                    entrada = Console.ReadLine();
                    //string qtdPedido;

                    if (codLanches.Contains(entrada))
                    {
                        switch (int.Parse(entrada))
                        {
                            case 101:
                                do {
                                    Console.Write("- Digite quantas coxinhas você deseja: ");
                                    qtdProduto = Console.ReadLine();

                                    EhLetra = qtdProduto.All(char.IsLetter);
                                    while (EhLetra || qtdProduto.Contains(" "))
                                    {
                                        Console.Write("- Digite o número de Coxinhas que deseja: ");
                                        qtdProduto = Console.ReadLine();
                                        EhLetra = qtdProduto.All(char.IsLetter);
                                    }

                                    if (int.Parse(qtdProduto) <= 0)
                                    {
                                        Console.WriteLine("- Não há como pedir zero Coxinhas.");
                                    }
                                } while (int.Parse(qtdProduto) <= 0);

                                Console.WriteLine("\n- Você pediu por " + qtdProduto + " Coxinhas.");
                                Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 3.50));
                                totPedidos.Add(qtdProduto + " Coxinha(s); ");   // Nomeia qntd e item.
                                vTotPedidos.Add(int.Parse(qtdProduto) * 3.50); // Guarda instância do valor total do pedido.
                                break;

                            case 102:
                                do { 
                                    Console.Write("- Digite quantos Baurus você deseja: ");
                                    qtdProduto = Console.ReadLine();

                                    EhLetra = qtdProduto.All(char.IsLetter);
                                    while (EhLetra || qtdProduto.Contains(" "))
                                    {
                                        Console.Write("- Digite o número de Baurus que deseja: ");
                                        qtdProduto = Console.ReadLine();
                                        EhLetra = qtdProduto.All(char.IsLetter);
                                    }

                                    if (int.Parse(qtdProduto) <= 0)
                                    {
                                        Console.WriteLine("- Não há como pedir zero Baurus.");
                                    }
                                } while (int.Parse(qtdProduto) <= 0);

                                Console.WriteLine("\n- Você pediu por " + qtdProduto + " Baurus.");
                                Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 4.00));
                                totPedidos.Add(qtdProduto + " Bauru(s); ");   // Nomeia qntd e item.
                                vTotPedidos.Add(int.Parse(qtdProduto) * 4.00); // Guarda instância do valor total do pedido.
                                break;

                            case 103:
                                do { 
                                    Console.Write("- Digite quantas Pizzas você deseja: ");
                                    qtdProduto = Console.ReadLine();

                                    EhLetra = qtdProduto.All(char.IsLetter);
                                    while (EhLetra || qtdProduto.Contains(" "))
                                    {
                                        Console.Write("- Digite o número de Pizzas que deseja: ");
                                        qtdProduto = Console.ReadLine();
                                        EhLetra = qtdProduto.All(char.IsLetter);
                                    }

                                    if (int.Parse(qtdProduto) <= 0)
                                    {
                                        Console.WriteLine("- Não há como pedir zero Pizzas.");
                                    }
                                } while (int.Parse(qtdProduto) <= 0);

                                Console.WriteLine("\n- Você pediu por " + qtdProduto + " Pizzas.");
                                Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 6.00));
                                totPedidos.Add(qtdProduto + " Pizza(s); ");   // Nomeia qntd e item.
                                vTotPedidos.Add(int.Parse(qtdProduto) * 6.00); // Guarda instância do valor total do pedido.
                                break;

                            case 201:
                                do {
                                    Console.Write("- Digite quantas Batatinhas você deseja: ");
                                    qtdProduto = Console.ReadLine();

                                    EhLetra = qtdProduto.All(char.IsLetter);
                                    while (EhLetra || qtdProduto.Contains(" "))
                                    {
                                        Console.Write("- Digite o número de Batatinhas que deseja: ");
                                        qtdProduto = Console.ReadLine();
                                        EhLetra = qtdProduto.All(char.IsLetter);
                                    }

                                    if (int.Parse(qtdProduto) <= 0)
                                    {
                                        Console.WriteLine("- Não há como pedir zero Batatinhas.");
                                    }
                                } while (int.Parse(qtdProduto) <= 0);

                                Console.WriteLine("\n- Você pediu por " + qtdProduto + " Batatinhas.");
                                Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 5.50));
                                totPedidos.Add(qtdProduto + " Batatinhas; ");   // Nomeia qntd e item.
                                vTotPedidos.Add(int.Parse(qtdProduto) * 5.50); // Guarda instância do valor total do pedido.
                                break;

                            case 202:
                                do { 
                                    Console.Write("- Digite quantos Doces de Abóbora você deseja: ");
                                    qtdProduto = Console.ReadLine();

                                    EhLetra = qtdProduto.All(char.IsLetter);
                                    while (EhLetra || qtdProduto.Contains(" "))
                                    {
                                        Console.Write("- Digite o número de Doces de Abóbora que deseja: ");
                                        qtdProduto = Console.ReadLine();
                                        EhLetra = qtdProduto.All(char.IsLetter);
                                    }

                                    if (int.Parse(qtdProduto) <= 0)
                                    {
                                        Console.WriteLine("- Não há como pedir zero Doces de Abóbora.");
                                    }
                                } while (int.Parse(qtdProduto) <= 0);

                                Console.WriteLine("\n- Você pediu por " + qtdProduto + " Doce(s) de Abóbora.");
                                Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 1.50));
                                totPedidos.Add(qtdProduto + " Doce(s) de Abóbora; ");   // Nomeia qntd e item.
                                vTotPedidos.Add(int.Parse(qtdProduto) * 1.50); // Guarda instância do valor total do pedido.
                                break;
                        }

                    }
                    // Fim (Loop2 - Verificação de entrada do usuário)
                } while (!codLanches.Contains(entrada));

            // Finalização do pedido (Loop1 - deseja pedir mais?)... 

                    Console.WriteLine("\n- Você deseja pedir mais algum lanche? [s/n]");
                    Console.Write("- Resposta: ");
                    maisPedidos = Console.ReadLine().ToLower();
                    Console.WriteLine();
            } while (maisPedidos == "sim" || maisPedidos == "s"); // Loop caso necessário.

        // Pergunte se o usuário deseja alguma bebida.
            Console.WriteLine("- Deseja uma bebida como acompanhamento?");
            Console.Write("- Resposta: ");
            entrada = Console.ReadLine().ToLower();
            Console.WriteLine();

            // Começo do cardápio de Bebidas.
            if ((entrada == "sim") || (entrada == "s"))
            {

                Console.WriteLine("- Okay, quais bebidas deseja tomar?");
                Console.WriteLine();

                string[] codBebidas = { "301", "302", "303", "304", "305" };

                // Apresentação do cardápio de lanches.

                Console.WriteLine("=========================================");
                Console.WriteLine("= LAN XONETE - Cardápio de BEBIDAS      =");
                Console.WriteLine("=========================================");
                Console.WriteLine("= Produto      |   Código  |   Preço    =");
                Console.WriteLine("=---------------------------------------=");
                Console.WriteLine("= Refrigerante |   301     |  R$: 5,80  =");
                Console.WriteLine("= Cerveja      |   302     |  R$: 7,00  =");
                Console.WriteLine("= Suco         |   303     |  R$: 4,00  =");
                Console.WriteLine("= Vinho        |   304     |  R$: 8,00  =");
                Console.WriteLine("= Achocolatado |   305     |  R$: 4,50  =");
                Console.WriteLine("=========================================");


                do
                { // Loop caso usuário desejar pedir outra coisa.

                    do
                    { // Início do Pedido - Verifica entrada do usuário.
                        Console.Write("- Digite o código do seu pedido: ");
                        entrada = Console.ReadLine();
                        //string qtdPedido;

                        if (codBebidas.Contains(entrada))
                        {
                            switch (int.Parse(entrada))
                            {
                                case 301:
                                    do
                                    {
                                        Console.Write("- Digite quantos Refrigerantes você deseja: ");
                                        qtdProduto = Console.ReadLine();

                                        EhLetra = qtdProduto.All(char.IsLetter);
                                        while (EhLetra || qtdProduto.Contains(" "))
                                        {
                                            Console.Write("- Digite o número de Refrigerantes que deseja: ");
                                            qtdProduto = Console.ReadLine();
                                            EhLetra = qtdProduto.All(char.IsLetter);
                                        }

                                        if (int.Parse(qtdProduto) <= 0)
                                        {
                                            Console.WriteLine("- Não há como pedir zero Refrigerantes.");
                                        }
                                    } while (int.Parse(qtdProduto) <= 0);

                                    Console.WriteLine("\n- Você pediu por " + qtdProduto + " Refrigerante(s).");
                                    Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 5.80));
                                    totPedidos.Add(qtdProduto + " Refrigerante(s); ");   // Nomeia qntd e item.
                                    vTotPedidos.Add(int.Parse(qtdProduto) * 5.80); // Guarda instância do valor total do pedido.
                                    break;

                                case 302:
                                    do
                                    {
                                        Console.Write("- Digite quantas Cervejas você deseja: ");
                                        qtdProduto = Console.ReadLine();

                                        EhLetra = qtdProduto.All(char.IsLetter);
                                        while (EhLetra || qtdProduto.Contains(" "))
                                        {
                                            Console.Write("- Digite o número de Cervejas que deseja: ");
                                            qtdProduto = Console.ReadLine();
                                            EhLetra = qtdProduto.All(char.IsLetter);
                                        }

                                        if (int.Parse(qtdProduto) <= 0)
                                        {
                                            Console.WriteLine("- Não há como pedir zero Cervejas.");
                                        }
                                    } while (int.Parse(qtdProduto) <= 0);

                                    Console.WriteLine("\n- Você pediu por " + qtdProduto + " Cerveja(s).");
                                    Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 7.00));
                                    totPedidos.Add(qtdProduto + " Cerveja(s); ");   // Nomeia quantidade e item, guardando na array.
                                    vTotPedidos.Add(int.Parse(qtdProduto) * 7.00); // Guarda o valor total do pedido na array.
                                    break;

                                case 303:
                                    do
                                    {
                                        Console.Write("- Digite quantos Sucos você deseja: ");
                                        qtdProduto = Console.ReadLine();

                                        EhLetra = qtdProduto.All(char.IsLetter);
                                        while (EhLetra || qtdProduto.Contains(" "))
                                        {
                                            Console.Write("- Digite o número de Sucos que deseja: ");
                                            qtdProduto = Console.ReadLine();
                                            EhLetra = qtdProduto.All(char.IsLetter);
                                        }

                                        if (int.Parse(qtdProduto) <= 0)
                                        {
                                            Console.WriteLine("- Não há como pedir zero Sucos.");
                                        }
                                    } while (int.Parse(qtdProduto) <= 0);

                                    Console.WriteLine("\n- Você pediu por " + qtdProduto + " Suco(s).");
                                    Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 4.00));
                                    totPedidos.Add(qtdProduto + " Suco(s); ");   // Nomeia quantidade e item, guardando na array.
                                    vTotPedidos.Add(int.Parse(qtdProduto) * 4.00); // Guarda o valor total do pedido na array.
                                    break;

                                case 304:
                                    do
                                    {
                                        Console.Write("- Digite quantos Vinhos você deseja: ");
                                        qtdProduto = Console.ReadLine();

                                        EhLetra = qtdProduto.All(char.IsLetter);
                                        while (EhLetra || qtdProduto.Contains(" "))
                                        {
                                            Console.Write("- Digite o número de Vinhos que deseja: ");
                                            qtdProduto = Console.ReadLine();
                                            EhLetra = qtdProduto.All(char.IsLetter);
                                        }

                                        if (int.Parse(qtdProduto) <= 0)
                                        {
                                            Console.WriteLine("- Não há como pedir zero Vinhos.");
                                        }
                                    } while (int.Parse(qtdProduto) <= 0);

                                    Console.WriteLine("\n- Você pediu por " + qtdProduto + " Vinho(s).");
                                    Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 8.00));
                                    totPedidos.Add(qtdProduto + " Vinho(s); ");   // Nomeia quantidade e item, guardando na array.
                                    vTotPedidos.Add(int.Parse(qtdProduto) * 8.00); // Guarda o valor total do pedido na array.
                                    break;

                                case 305:
                                    do
                                    {
                                        Console.Write("- Digite quantos Achocolatados você deseja: ");
                                        qtdProduto = Console.ReadLine();

                                        EhLetra = qtdProduto.All(char.IsLetter);
                                        while (EhLetra || qtdProduto.Contains(" "))
                                        {
                                            Console.Write("- Digite o número de Achocolatados que deseja: ");
                                            qtdProduto = Console.ReadLine();
                                            EhLetra = qtdProduto.All(char.IsLetter);
                                        }

                                        if (int.Parse(qtdProduto) <= 0)
                                        {
                                            Console.WriteLine("- Não há como pedir zero Achocolatados.");
                                        }
                                    } while (int.Parse(qtdProduto) <= 0);

                                    Console.WriteLine("\n- Você pediu por " + qtdProduto + " Achocolatado(s).");
                                    Console.WriteLine("- Total R$: " + (int.Parse(qtdProduto) * 4.50));
                                    totPedidos.Add(qtdProduto + " Achocolatado(s); ");   // Nomeia quantidade e item, guardando na array.
                                    vTotPedidos.Add(int.Parse(qtdProduto) * 4.50); // Guarda o valor total do pedido na array.
                                    break;
                            }

                        }
                        // Fim (Loop2 - Verificação de entrada do usuário)
                    } while (!codBebidas.Contains(entrada));

                    // Finalização do pedido (Loop1 - deseja pedir mais?)... 

                    Console.WriteLine("\n- Você deseja pedir mais alguma bebida? [s/n]");
                    Console.Write("- Resposta: ");
                    maisPedidos = Console.ReadLine().ToLower();
                    Console.WriteLine();
                } while (maisPedidos == "sim" || maisPedidos == "s"); // Loop caso necessário.

            }

        // Check-out do pedido. Exibindo o conteúdo das arrays.
        string[] listaProdutos = totPedidos.ToArray();
        double[] custoTotal = vTotPedidos.ToArray();
        Console.Write("- Seus pedidos foram: ");
        foreach (string items in listaProdutos)
        {
            Console.Write(items);
        }
        Console.Write("\n- Preço Total - ");
        double total = 0.0;
        foreach (double items in custoTotal)
        {
            total += items;
        }

        Console.Write("R$: {0:0.00}\n", total);
            // Adicionar a pergunta sobre o pagamento...
        Console.WriteLine("\n- Você pagará com quantos reais?");
        Console.Write("- R$: ");

            string pagamento;
            do {
                pagamento = Console.ReadLine();
                EhLetra = pagamento.All(char.IsLetter);
                while (EhLetra || pagamento.Contains(" "))
                {
                    Console.WriteLine("- Digite apenas números. ");
                    Console.Write("- R$: ");
                    pagamento = Console.ReadLine();
                    EhLetra = pagamento.All(char.IsLetter);
                }
                if (double.Parse(pagamento) < total) { 
                Console.WriteLine("\n- Você está devendo R$: {0:0.00}, nem mais, nem menos.", total);
                Console.WriteLine("- Você vai pagar com quantos reais?");
                Console.Write("- R$: ");
                }

            } while (double.Parse(pagamento) < total) ;

            if (double.Parse(pagamento) > total)
            {
                Console.WriteLine("\n- O seu troco é R$: {0:0.00}", (double.Parse(pagamento) - total));
            }

        Console.WriteLine("\n- Tudo certo, seu pedido ficará pronto em breve. Muito obrigado!");
        Console.WriteLine("\nPressione qualquer tecla para encerrar");
        Console.ReadKey();
        }
    }
}