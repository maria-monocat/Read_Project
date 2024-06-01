using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Project
{
    internal class Quest
    {
        public bool missao;

        public void lerIntro()
        {
            char read;

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
            Console.WriteLine("Para provar sua SUPREMACIA FELPUDA, você terá que BATALHAR CONTRA SEUS IRMÃOS FELINOS extremamente habilidosos \ne mostrar que você é digno para ser tornar O NOVO REI MEOW.(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("\tBem-Vindo ao MEOW SUPREME!");
        }

        public string lutarContraRonRon(int vida, Personagem jogador)
        {
            char read;
            string confirm;
            string relatorio;

            Console.WriteLine("\nQue a luta pelo TRONO MEOW começe!(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.Clear();
            

            Console.WriteLine("\tMEOW SUPREME");

            Inimigo npcRonRon = new Inimigo("RonRon, O Gatinho Preto Assassino",100,"ASSASSINO", 80);
            
            Console.WriteLine();
            Console.WriteLine("nyan.nyan...(ENTER)");
            Console.WriteLine(jogador.vida);
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("NYAN!!(ENTER)");
            read = Console.ReadKey().KeyChar;
            int jogadorAtacado = jogador.vida - npcRonRon.dano;
            int npcAtacado = npcRonRon.vida - 0;

            
            Console.WriteLine();
            Console.WriteLine("RonRon, o Gatinho Preto Assassino apacere das sombras e CAUSA DANO EXPLOSIVO em você.(ENTER)");
            read = Console.ReadKey().KeyChar;

            imprimirBatalha(jogador,npcRonRon,npcAtacado,jogadorAtacado);
            
            Console.WriteLine("O que você QUER fazer?");
            if (jogador.classe.Equals("NINJA"))
            {
                jogador.habilidadeNinja(jogador, npcRonRon, npcAtacado, jogadorAtacado);

            }else if (jogador.classe.Equals("ASSASSINO"))
            {
                jogador.habilidadeAssassino(jogador,npcRonRon,npcAtacado,jogadorAtacado);

            }


            if (vida <= 0) {
                relatorio = "NYAN!\nVocê VENCEU RonRon, o Gatinho Preto Assassino!";
            }else {
                relatorio = "MOUW...Você PERDEU para RonRon... \nAgora ele é o REI MEOW.";

            }

            return relatorio;

        }

        public void imprimirBatalha(Personagem jogador, Inimigo npc, int npcAtacado, int jogadorAtacado)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("RELATÓRIO DA BATALHA");
            Console.WriteLine("---------------------");
            Console.WriteLine("VOCÊ");
            Console.WriteLine("Nome do Gato:" + jogador.nome + "\nClasse do Gato:" + jogador.classe + "\nVida Atual: " + jogadorAtacado + "/" + jogador.vida + "\nDano:" + jogador.dano);
            Console.WriteLine("---------------------");
            Console.WriteLine("OPONENTE");
            Console.WriteLine("Nome do Gato:" + npc.nome + "\nClasse do Gato:" + npc.classe + "\nVida Atual: " + npcAtacado + "/" + npc.vida + "\nDano:" + npc.dano);
            Console.WriteLine();
        }

    }

}
