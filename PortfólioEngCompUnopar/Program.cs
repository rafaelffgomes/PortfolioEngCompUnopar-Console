using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfólioEngCompUnopar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaração de variáveis referentes aos integrantes do grupo. Desnecessário, somente para fins didáticos... */
            string aluno1 = "RAFAEL FIGUEIREDO FERREIRA GOMES";
            string aluno2 = "JOSÉ RAIMUNDO ALVES";
            string aluno3 = "MARCOS FONSECA DE MOURA";
            string aluno4 = "JHONATA DA SILVA RAMOS";
            string login, senha, opcao;
            float tensao, corrente, resistor1, resistor2, resistor3, somaresistor;

            /* Escreve dados do aplicativo na tela. */
            Console.WriteLine("\nPortfólio de Engenharia da Computação \nUNOPAR 5º PERÍODO");
            Console.WriteLine("\nIntegrantes do grupo:");

            /* Escreve os integrantes do grupo na tela. */
            Console.WriteLine("\n" +aluno1+ "");
            Console.WriteLine(aluno2);
            Console.WriteLine(aluno3);
            Console.WriteLine(aluno4);

            /* Firulas... */
            Console.WriteLine("\n\nPressione qualquer tecla para continuar ou ESC para sair...");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); /* Lê tecla digitada */
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                System.Environment.Exit(0); /* Fecha o programa */
            }
            else
                /* A execução continua... */                  
            {
                Console.Clear(); /* Limpa a tela */
                Console.WriteLine("\nLogin Padrão: admin"); /* Tela de login */
                Console.WriteLine("Senha Padrão: 1234");
                Console.Write("\n\nDigite o Login: ");
                login = Console.ReadLine();
                Console.Write("\nDigite a Senha: ");
                senha = Console.ReadLine();
                if ((login != "admin") || (senha != "1234")) /* Login inverso */
                {
                    Console.WriteLine("\n\nLogin e Senha não conferem, tente novamente.");
                    Console.WriteLine("\n\nPressione qualquer tecla para sair...");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                else
                Console.Clear();
                Console.WriteLine("Escolha a opção desejada:");
                Console.WriteLine("\n\n  1  - PARA CALCULAR A POTÊNCIA ELÉTRICA");
                Console.WriteLine("\n  2  - PARA CALCULAR A CORRENTE ELÉTRICA");
                Console.WriteLine("\n  3  - PARA CALCULAR A TENSÃO ELÉTRICA");
                Console.WriteLine("\n  4  - PARA CALCULAR A RESISTÊNCIA ELÉTRICA");
                Console.WriteLine("\n  0  - PARA ENCERRAR");
                Console.Write("\nOpção selecionada: ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case ("1"): /* Para calcular a potência temos de multiplicar a tensão pela corrente */
                        Console.Clear();
                        Console.Write("\nDigite a tensão de entrada no circuito: ");
                        tensao = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite a corrente de entrada no circuito: ");
                        corrente = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nA potência elétrica do circuito é de "+tensao * corrente+" watts.");
                        Console.WriteLine("\n\n\nDigite qualquer tecla para sair.");
                        break;

                    case ("2"): /* Para calcular a corrente temos de dividir a tensão pela soma das resistências */
                        Console.Clear();
                        Console.Write("\nDigite a tensão de entrada no circuito: ");
                        tensao = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor do Resistor R1: ");
                        resistor1 = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor do Resistor R2: ");
                        resistor2 = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor do Resistor R3: ");
                        resistor3 = float.Parse(Console.ReadLine());
                        somaresistor = resistor1 + resistor2 + resistor3;
                        Console.WriteLine("\nA corrente elétrica do circuito é de " + tensao / somaresistor + " amperes.");
                        Console.WriteLine("\n\n\nDigite qualquer tecla para sair.");
                        break;

                    case ("3"): /* Para calcular a tensão temos de multiplicar a corrente pela soma das resistências */
                        Console.Clear();
                        Console.Write("\nDigite a corrente elétrica de entrada no circuito: ");
                        corrente = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor do Resistor R1: ");
                        resistor1 = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor do Resistor R2: ");
                        resistor2 = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor do Resistor R3: ");
                        resistor3 = float.Parse(Console.ReadLine());
                        somaresistor = resistor1 + resistor2 + resistor3;
                        Console.WriteLine("\nA tensão elétrica do circuito é de " + somaresistor * corrente + " volts.");
                        Console.WriteLine("\n\n\nDigite qualquer tecla para sair.");
                        break;

                    case ("4"): /* Para calcular a resistência temos de dividir a tensão pela corrente */
                        Console.Clear();
                        Console.Write("\nDigite a tensão de entrada no circuito: ");
                        tensao = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite a corrente elétrica de entrada no circuito: ");
                        corrente = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nA resistência elétrica do circuito é de " + tensao / corrente + " ohms.");
                        Console.WriteLine("\n\n\nDigite qualquer tecla para sair.");
                        break;

                    case ("0"):
                        System.Environment.Exit(0);
                        break;

                    default: /* Se a pessoa digitar uma opção inválida, esse comando envia uma mensagem de erro. Funciona como um "else" */
                        Console.WriteLine("\n\nOpção Inválida.");
                        Console.WriteLine("\nDigite qualquer tecla para sair.");
                        break;
                }
                Console.ReadKey(); /* Impede que a tela feche antes de ter os resultados */
            }
        }
    }
}