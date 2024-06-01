using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Project
{
    internal class Personagem
    {
        public string nome;
        public int vida;
        public string classe;

        public Personagem() { 
        }

        public Personagem(string nome, int vida, string classe) {
            this.nome = nome;
            this.vida = vida;
            this.classe = classe;
        }

        public void criarNovaClasse()
        {
            char confirm;
            int input;
            do
            {

                Console.WriteLine("\nDeseja escolher outra ESTILO DE LUTA FELINO ? S/N");
                confirm = Console.ReadKey().KeyChar;

                if (confirm.Equals('S') || confirm.Equals('s'))
                {
                    inputClasseJogador(new Personagem());
                }
                else if (confirm.Equals('N') || confirm.Equals('n'))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nNYAN?? Parece que algo deu errado.\nDigite S ou N.");
                }

            } while (!confirm.Equals('S') && !confirm.Equals('s') && !confirm.Equals('N') && !confirm.Equals('n'));
        }


        public Personagem inputClasseJogador(Personagem jogador)
        {
            int input;

            Console.WriteLine("\nInsira seu nome de LUTADOR FELINO para o torneio pelo TRONO:");
            string nomeJogador = Console.ReadLine();

            do
            {

                Console.WriteLine("\nEscolha seu ESTILO DE LUTA FELINO:\n1 - Ninja\n2 - Carismático\n3 - Assassino\n4 - Intimidador");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        jogador.criarPersonagemNinja(nomeJogador);
                        Console.WriteLine("Você escolheu " + jogador.classe + ".\nGato com estilo de luta "+ jogador.classe +" são rápidos,\ncausam sequência de DANO RÁPIDO com as patinhas e possuem VIDA MÉDIA");

                        criarNovaClasse();
                        break;
                    case 2:
                        jogador.criarPersonagemCarismatico(nomeJogador);
                        Console.WriteLine("Você escolheu " + jogador.classe + ".\nGato com estilo de luta "+ jogador.classe +" são manhosos,\n causam sequência de DANO ATORDOADOR com suas poses mais fofas e possuem VIDA MÉDIA");
                        criarNovaClasse();
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu " + jogador.classe + ".\nGato com estilo de luta "+ jogador.classe +" são fatais, \ncausam DANO EXPLOSIVO com seus pulos sobre o inimigo mas possuem VIDA BAIXA");
                        criarNovaClasse();
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu " + jogador.classe + ".\nGato com estilo de luta "+ jogador.classe +" são opressivos, \ncausam DANO CONSTANTE com seu olhar de desprezo e possuem VIDA ALTA");
                        criarNovaClasse();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("NYAN?? Parece que algo deu errado.\nEscolha uma opção de 1 a 4.");
                        break;
                }



            } while (input < 0 || input > 4);


            return jogador;
        }

        public Personagem criarPersonagemNinja(string nome)
        {
            this.nome = nome;
            this.vida = 250;
            this.classe = "NINJA";

            Personagem jogadorNinja = new Personagem(nome, vida, classe);

            return jogadorNinja;
        }

        public Personagem criarPersonagemCarismatico(string nome)
        {
            this.nome = nome;
            this.vida = 250;
            this.classe = "CARISMÁTICO";

            Personagem jogadorCarismatico = new Personagem(nome, vida, classe);

            return jogadorCarismatico;
        }

        public Personagem criarPersonagemAssassino(string nome)
        {
            this.nome = nome;
            this.vida = 100;
            this.classe = "ASSASSINO";

            Personagem jogadorAssassino = new Personagem(nome, vida, classe);

            return jogadorAssassino;
        }

        public Personagem criarPersonagemIntimidador(string nome)
        {
            this.nome = nome;
            this.vida = 100;
            this.classe = "INTIMIDADOR";

            Personagem jogadorIntimidador = new Personagem(nome, vida, classe);

            return jogadorIntimidador;
        }

    }
}
