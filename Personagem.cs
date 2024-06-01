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
        public int dano;

        public Personagem() { 
        }

        public Personagem(string nome, int vida, string classe, int dano) {
            this.nome = nome;
            this.vida = vida;
            this.classe = classe;
            this.dano = dano;
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

                Console.WriteLine("\nEscolha seu ESTILO DE LUTA FELINO:\n1 - Ninja\n2 - Assassino\n3 - Intimidador");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        jogador.criarPersonagemNinja(nomeJogador);
                        Console.WriteLine("Você escolheu " + jogador.classe + ".\nGato com estilo de luta "+ jogador.classe +" são rápidos,\ncausam sequência de DANO RÁPIDO com as patinhas e possuem VIDA MÉDIA");
                        criarNovaClasse();
                        break;
                    case 2:
                        jogador.criarPersonagemAssassino(nomeJogador);
                        Console.WriteLine("Você escolheu " + jogador.classe + ".\nGato com estilo de luta "+ jogador.classe +" são fatais, \ncausam DANO EXPLOSIVO com seus pulos sobre o inimigo mas possuem VIDA BAIXA");
                        criarNovaClasse();
                        break;
                    case 3:
                        jogador.criarPersonagemIntimidador(nomeJogador);
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
            this.dano = 20;

            Personagem jogadorNinja = new Personagem(nome, vida, classe, dano);

            return jogadorNinja;
        }

        public Personagem criarPersonagemAssassino(string nome)
        {
            this.nome = nome;
            this.vida = 100;
            this.classe = "ASSASSINO";
            this.dano = 80;

            Personagem jogadorAssassino = new Personagem(nome, vida, classe, dano);

            return jogadorAssassino;
        }

        public Personagem criarPersonagemIntimidador(string nome)
        {
            this.nome = nome;
            this.vida = 100;
            this.classe = "INTIMIDADOR";
            this.dano = 10;

            Personagem jogadorIntimidador = new Personagem(nome, vida, classe, dano);

            return jogadorIntimidador;
        }

        public void habilidadeNinja(Personagem jogador, Inimigo npc, int npcAtacado, int jogadorAtacado)
        {
            Console.WriteLine("1 - NYANJA ATAQUE > v < (Causa 3 golpes consecutivos no oponente)\n2 - LAMBER :P (CURA 50% do DANO RECEBIDO)");
            string confirm = Console.ReadLine();
            switch (confirm)
            {
                case "1":
                    char read;

                    Console.WriteLine("VOCÊ usou a HABILIDADE - NYANJA ATAQUE.");
                    Console.WriteLine("Aperte a tecla (ENTER) 3 vezes para aplicar 3 Golpes Consecutivos no Oponente.(ENTER)");
                    Console.WriteLine();

                    Console.WriteLine("Nyan.(ENTER)");
                    read = Console.ReadKey().KeyChar;
                    npcAtacado = npc.vida - jogador.dano;
                    Console.WriteLine(npcAtacado);

                    Console.WriteLine();
                    Console.WriteLine("Nyannn.(ENTER)");
                    read = Console.ReadKey().KeyChar;
                    npcAtacado = npcAtacado - jogador.dano;
                    Console.WriteLine(npcAtacado);

                    Console.WriteLine();
                    Console.WriteLine("NYANNN!.(ENTER)");
                    read = Console.ReadKey().KeyChar;
                    npcAtacado = npcAtacado - jogador.dano;
                    Console.WriteLine(npcAtacado);
                    break;
                default:
                    break;

            }

        }

        public void habilidadeAssassino(Personagem jogador, Inimigo npc, int npcAtacado, int jogadorAtacado)
        {
            Console.WriteLine("1 - MEOWW ATACK O v O (Causa 1 golpe de dano explosivo no oponente)\n2 - LAMBER :P (CURA 50% do DANO RECEBIDO)");
            string confirm = Console.ReadLine();
            switch (confirm)
            {
                case "1":
                    Console.WriteLine("VOCÊ usou a HABILIDADE - NYANJA ATAQUE.(ENTER)");
                    char read = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine("Aperte ENTER 3 vezes para aplicar 3 Golpes Consecutivos no Oponente.(ENTER)");
                    read = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine("Nyan.(ENTER)");
                    read = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine("Nyan.(ENTER)");
                    read = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine("NYAN!.(ENTER)");
                    read = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    break;
                default:
                    break;

            }
        }


    }
}
