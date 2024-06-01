using Microsoft.VisualBasic.FileIO;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Read_Project
{
    internal class Program
    {
        public char read;
        public char confirm;
        public int input;

        public Program()
        {
            mostrarHistoria();
            escolherEstilo();
        }

        static void Main(string[] args)
        {

            new Program();
            
        }
        public void mostrarHistoria()
        {
            Console.WriteLine("\tMEOW SUPREME");
            Console.WriteLine("Você é o Gato Príncipe do Reino Meow.(ENTER)");
            read = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine("O Rei Meow, seu pai, é o gato mais FELPUDO e FOFO do Reino.(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("\nPorém ele está velho e logo irá partir para o Reino dos Felinos Eternos,\nO lugar onde todas as almas felinas descansam.(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("No entanto, há um desentendimentoe entre os irmãos...(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Seus irmãos duvidam se você é digno de ser o mais novo REI MEOW,\nO mais FELPUDO e FOFO gato de todo o Reino.(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("O REI MEOW para resolver o desentendimento entre os irmãos propõe o seguinte teste:(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Para provar sua SUPREMACIA FELPUDA, você terá que BATALHAR CONTRA SEUS IRMÃOS FELINOS extremamente habilidosos \ne mostrar que você é digno para ser tornar \n\tO NOVO REI MEOW.(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("\tBem-Vindo ao MEOW SUPREME!");

            Console.WriteLine("Insira seu nome de LUTADOR FELINO para o torneio pelo TRONO:");
            string nomeInput = Console.ReadLine();
        }

        public void escolherEstilo()
        {

            do
            {

                Console.WriteLine("\nEscolha seu ESTILO DE LUTA FELINO:\n1 - Ninja\n2 - Carismático\n3 - Assassino\n4 - Intimidador");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Você escolheu NINJA.\nGato com estilo de luta NINJA são rápidos,\ncausam sequência de DANO RÁPIDO com as patinhas e possuem VIDA MÉDIA");
                        novoEstilo();
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu CARISMÁTICO.\nGato com estilo de luta CARISMÁTICO são manhosos,\n causam sequência de DANO ATORDOADOR com suas poses mais fofas e possuem VIDA MÉDIA");
                        novoEstilo();
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu ASSASSINO.\nGato com estilo de luta ASSASSINO são fatais, \ncausam DANO EXPLOSIVO com seus pulos sobre o inimigo mas possuem VIDA BAIXA");
                        novoEstilo();
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu INTIMIDADOR.\nGato com estilo de luta INTIMIDADOR são opressivos, \ncausam DANO CONSTANTE com seu olhar de desprezo e possuem VIDA ALTA");
                        novoEstilo();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("NYAN?? Parece que algo deu errado.\nEscolha uma opção de 1 a 4.");
                        break;
                }

            } while (input < 0 || input > 4);

            

        }

        public void novoEstilo()
        {
            do
            {
                Console.WriteLine("\nDeseja escolher outra ESTILO DE LUTA FELINO ? S/N");
                confirm = Console.ReadKey().KeyChar;

                if(confirm.Equals('S') || confirm.Equals('s'))
                {
                    escolherEstilo();
                }else if(confirm.Equals('N') || confirm.Equals('n'))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nNYAN?? Parece que algo deu errado.\nDigite S ou N.");
                }

            } while (!confirm.Equals('S') && !confirm.Equals('s') && !confirm.Equals('N') && !confirm.Equals('n'));
        }
    }
}
