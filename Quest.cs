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
            Console.WriteLine("No entanto, há um desentendimentoe entre seus irmãos...(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Seus 2 irmãos duvidam se você é digno de ser o mais novo REI MEOW,\nO mais FELPUDO e FOFO gato de todo o Reino.(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("O REI MEOW para resolver o desentendimento entre os 3 irmãos, propõe o seguinte teste:(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Para provar sua SUPREMACIA FELPUDA, você terá que BATALHAR CONTRA SEUS IRMÃOS FELINOS extremamente habilidosos \ne mostrar que você é digno para ser tornar O NOVO REI MEOW.(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("\tBem-Vindo ao MEOW SUPREME!");
        }

        public void lutarContraRonRon(Personagem jogador)
        {
            char read;
            string confirm;
            string relatorio;


            Console.WriteLine("\nQue a luta pelo TRONO MEOW começe!(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.Clear();


            Console.WriteLine("\tMEOW SUPREME");

            Inimigo npcRonRon = new Inimigo("RonRon, O Gatinho Preto Assassino", 100, "ASSASSINO", 80);



            Console.WriteLine();
            Console.WriteLine("nyan.nyan...(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("NYAN!!(ENTER)");
            read = Console.ReadKey().KeyChar;
            int jogadorAtacado = jogador.vida - npcRonRon.dano;
            int npcAtacado = npcRonRon.vida - 0;


            Console.WriteLine();
            Console.WriteLine("RonRon, o Gatinho Preto Assassino apacere das sombras e CAUSA DANO EXPLOSIVO em você.(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine("\nCUIDADO! Gato com estilo de luta " + npcRonRon.classe + " são fatais, \ncausam DANO EXPLOSIVO com seus pulos sobre o inimigo mas possuem VIDA BAIXA.(ENTER)");
            read = Console.ReadKey().KeyChar;

            do
            {

                imprimirBatalha(jogador, npcRonRon, npcAtacado, jogadorAtacado);
                Console.WriteLine("O que você QUER fazer?");
                if (jogador.classe.Equals("NINJA"))
                {


                    Console.WriteLine("1 - NYANJA ATAQUE > v < (Causa 3 golpes consecutivos no oponente com base no seu DANO.\n2 - LAMBER :P (CURA 160 do DANO RECEBIDO)");
                    confirm = Console.ReadLine();
                    switch (confirm)
                    {
                        case "1":
                            Console.WriteLine("VOCÊ usou a HABILIDADE - NYANJA ATAQUE.");

                            Console.WriteLine("Aperte a tecla (ENTER) 3 vezes para aplicar 3 Golpes Consecutivos no Oponente com base no seu DANO.(ENTER)");
                            Console.WriteLine();

                            Console.WriteLine("Nyan.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            npcAtacado = npcAtacado - jogador.dano;
                            Console.WriteLine("Vida Oponente:" + npcAtacado + "/" + npcRonRon.vida);

                            Console.WriteLine();
                            Console.WriteLine("Nyannn.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            npcAtacado = npcAtacado - jogador.dano/2;
                            Console.WriteLine("Vida Oponente:" + npcAtacado + "/" + npcRonRon.vida);

                            Console.WriteLine();
                            Console.WriteLine("NYANNN!.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            npcAtacado = npcAtacado - jogador.dano/10;
                            Console.WriteLine("Vida Oponente:" + npcAtacado + "/" + npcRonRon.vida);
                            Console.WriteLine("Você ATACOU " + npcRonRon.nome+".(ENTER)");
                            read = Console.ReadKey().KeyChar;

                            Console.WriteLine(npcRonRon.nome + " ATACA você com DANO EXPLOSIVO. NYANN!(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado - npcRonRon.dano;
                            Console.WriteLine("Sua Vida:" + jogadorAtacado + "/" + jogador.vida);
                            read = Console.ReadKey().KeyChar;
                            break;
                        case "2":
                            Console.WriteLine("VOCÊ usou a HABILIDADE - LAMBER :P.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            Console.WriteLine("Aperte ENTER 2 vezes para LAMBER seu pelo e se CURAR  do golpe do oponente.");
                            Console.WriteLine();

                            Console.WriteLine("Chlep.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado + 20 + npcRonRon.dano;
                            

                            if (jogadorAtacado > jogador.vida)
                            {
                                int overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;



                                Console.WriteLine("Chlep.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado + 20 + npcRonRon.dano / 2;


                                overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;
                            }
                            else
                            {
                                Console.WriteLine("Chlep.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado + 20 + npcRonRon.dano / 2;


                                int overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;

                                Console.WriteLine("Você CUROU 160 de VIDA.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado - npcRonRon.dano;
                                jogadorAtacado = jogadorAtacado + npcRonRon.dano;

                                Console.WriteLine(npcRonRon.nome + " ATACA você com DANO EXPLOSIVO. NYANN!(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado - npcRonRon.dano;
                                read = Console.ReadKey().KeyChar;

                            }

                            break;

                            

                    }


                }else if (jogador.classe.Equals("ASSASSINO"))
                {
                    Console.WriteLine("1 - MEOW FATAL ATAQUE OvO (Causa 1 golpe de DANO EXPLOSIVO no oponente)\n2 - LAMBER E DESVIAR:P (CURA dano recebido e DESVIA do PRÓXIMO ATAQUE INIMIGO)");
                    confirm = Console.ReadLine();
                    switch (confirm)
                    {
                        case "1":
                            Console.WriteLine("VOCÊ usou a HABILIDADE - MEOW FATAL ATAQUE OvO");

                            Console.WriteLine("Aperte a tecla (ENTER) 1 vez para aplicar 1 Golpe de DANO EXPLOSIVO no Oponente.(ENTER)");
                            Console.WriteLine();

                            Console.WriteLine("MEOW.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            npcAtacado = npcAtacado - jogador.dano;
                            Console.WriteLine("Vida Oponente:" + npcAtacado + "/" + npcRonRon.vida);


                            Console.WriteLine("Você ATACOU " + npcRonRon.nome + ".(ENTER)");
                            read = Console.ReadKey().KeyChar;

                            Console.WriteLine(npcRonRon.nome + " ATACA você com DANO EXPLOSIVO. NYANN!(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado - npcRonRon.dano;
                            read = Console.ReadKey().KeyChar;

                            break;
                        case "2":
                            Console.WriteLine("VOCÊ usou a HABILIDADE - LAMBER e DESVIAR :P.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            Console.WriteLine("Aperte ENTER 2 vezes para LAMBER seu pelo.");
                            Console.WriteLine();

                            Console.WriteLine("Chlep.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado + 20 + npcRonRon.dano;
                            if (jogadorAtacado > jogador.vida)
                            {
                                int overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;



                                Console.WriteLine("Chlep.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado + 20 + npcRonRon.dano / 2;
 

                                overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;
                            }
                            else
                            {
                                Console.WriteLine("Você CUROU sua FERIDA e DESVIA do PRÓXIMO GOLPE do inimigo. NYAN.(ENTER)");
                                read = Console.ReadKey().KeyChar;

                                jogadorAtacado = jogadorAtacado - npcRonRon.dano;
                                jogadorAtacado = jogadorAtacado + npcRonRon.dano * 2;

                                Console.WriteLine(npcRonRon.nome + " ATACA você com DANO EXPLOSIVO. NYANN!(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado - npcRonRon.dano;

                            }

                            Console.WriteLine("Você CUROU sua FERIDA e você DESVIA do PRÓXIMO GOLPE do inimigo. NYAN.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado - npcRonRon.dano;
                            jogadorAtacado = jogadorAtacado + npcRonRon.dano * 2;

                            Console.WriteLine(npcRonRon.nome + " ATACA você com DANO EXPLOSIVO. NYANN!(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado - npcRonRon.dano;

                            break;

                    }
                }

            } while (jogadorAtacado > 0 && npcAtacado > 0);


            if (npcAtacado <= 0)
            {
                Console.WriteLine("NYAN!\nVocê VENCEU RonRon, o Gatinho Preto Assassino!(ENTER)");
                read = Console.ReadKey().KeyChar;
                imprimirBatalha(jogador,npcRonRon,npcAtacado,jogadorAtacado);
            }
            else if (jogadorAtacado <= 0)
            {
                Console.WriteLine("MOUW...Você PERDEU para RonRon... \nAgora ele é o REI MEOW.(ENTER)");
                read = Console.ReadKey().KeyChar;
                imprimirBatalha(jogador, npcRonRon, npcAtacado, jogadorAtacado);
            }


        }

        public void lutarContraNyanko(Personagem jogador)
        {
            char read;
            string confirm;
            

            Console.Clear();


            Console.WriteLine("\tMEOW SUPREME");

            Console.WriteLine("\nSeu segundo Irmão aguarda calmamente...(ENTER)");
            read = Console.ReadKey().KeyChar;

            Inimigo npcNyanko = new Inimigo("Nyanko, O Gatinho Vaca Gordinho", 300, "INTIMIDADOR", 50);

            Console.WriteLine();
            Console.WriteLine("nyan~~~~(ENTER)");
            read = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Ñyannn O.O (ENTER)");
            read = Console.ReadKey().KeyChar;
            int jogadorAtacado = jogador.vida - npcNyanko.dano;
            int npcAtacado = npcNyanko.vida - 0;


            Console.WriteLine();
            Console.WriteLine(npcNyanko.nome + " apacere depois de um cochilo e começa a ENCARAR você. Você se sente ATORDOADO...(ENTER)");
            read = Console.ReadKey().KeyChar;

            Console.WriteLine("\nCUIDADO! Gato com estilo de luta "+ npcNyanko.classe + " são opressivos.\nCausam DANO CRESCENTE a cada rodada com seu olhar de desprezo e possuem VIDA ALTA (ENTER)");
            read = Console.ReadKey().KeyChar;

            do
            {

                imprimirBatalha(jogador, npcNyanko, npcAtacado, jogadorAtacado);
                Console.WriteLine("O que você QUER fazer?");
                
                if (jogador.classe.Equals("NINJA"))
                {
                    Console.WriteLine("1 - NYANJA ATAQUE > v < (Causa 3 golpes consecutivos no oponente com base no seu DANO.)\n2 - LAMBER :P (CURA com BASE no DANO RECEBIDO)");
                    confirm = Console.ReadLine();
                    switch (confirm)
                    {
                        case "1":
                            Console.WriteLine("VOCÊ usou a HABILIDADE - NYANJA ATAQUE.");


                            Console.WriteLine("Aperte a tecla (ENTER) 3 vezes para aplicar 3 Golpes Consecutivos no Oponente com base no seu DANO.(ENTER)");
                            Console.WriteLine();

                            Console.WriteLine("Nyan.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            npcAtacado = npcAtacado - jogador.dano;
                            Console.WriteLine("Vida Oponente:" + npcAtacado + "/" + npcNyanko.vida);

                            Console.WriteLine();
                            Console.WriteLine("Nyannn.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            npcAtacado = npcAtacado - jogador.dano / 2;
                            Console.WriteLine("Vida Oponente:" + npcAtacado + "/" + npcNyanko.vida);

                            Console.WriteLine();
                            Console.WriteLine("NYANNN!.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            npcAtacado = npcAtacado - jogador.dano / 10;
                            Console.WriteLine("Vida Oponente:" + npcAtacado + "/" + npcNyanko.vida);
                            Console.WriteLine("Você ATACOU " + npcNyanko.nome + ".(ENTER)");
                            read = Console.ReadKey().KeyChar;

                            Console.WriteLine(npcNyanko.nome + " ENCARA você ... OwO. Você se sente ATORDOADO.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado - npcNyanko.dano++;

                            break;
                        case "2":
                            Console.WriteLine("VOCÊ usou a HABILIDADE - LAMBER :P.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            Console.WriteLine("Aperte ENTER 2 vezes para LAMBER seu pelo e se CURAR do golpe do oponente.");
                            Console.WriteLine();

                            Console.WriteLine("Chlep.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado + 80;

                            if (jogadorAtacado > jogador.vida)
                            {
                                int overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;



                                Console.WriteLine("Chlep.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado + 80;
                                

                                overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;

                            }
                            else
                            {
                                Console.WriteLine("Chlep.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado + 80;


                                jogadorAtacado = jogadorAtacado - npcNyanko.dano;
                                jogadorAtacado = jogadorAtacado + npcNyanko.dano++;
                                Console.WriteLine("Você CUROU sua VIDA.(ENTER)");
                                read = Console.ReadKey().KeyChar;

                                Console.WriteLine(npcNyanko.nome + " ENCARA você ... OwO. Você se sente ATORDOADO.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado - npcNyanko.dano++;

                            }
                            break;
                            



                    }


                }
                else if (jogador.classe.Equals("ASSASSINO"))
                {
                    Console.WriteLine("1 - MEOW FATAL ATAQUE OvO (Causa 1 golpe de DANO EXPLOSIVO no oponente)\n2 - LAMBER e DESVIAR :P (CURA o DANO RECEBIDO e DESVIA do próximo golpe inimigo.)");
                    confirm = Console.ReadLine();
                    switch (confirm)
                    {
                        case "1":
                            Console.WriteLine("VOCÊ usou a HABILIDADE - MEOW FATAL ATAQUE OvO");

                            Console.WriteLine("Aperte a tecla (ENTER) 1 vez para aplicar 1 Golpe de DANO EXPLOSIVO no Oponente.(ENTER)");
                            Console.WriteLine();

                            Console.WriteLine("MEOW.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            npcAtacado = npcAtacado - jogador.dano;


                            Console.WriteLine("Você ATACOU " + npcNyanko.nome + ".(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            Console.WriteLine("Vida Oponente:" + npcAtacado + "/" + npcNyanko.vida);
                            read = Console.ReadKey().KeyChar;

                            Console.WriteLine(npcNyanko.nome + " ENCARA você. Você se sente ATORDOADO...(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado - npcNyanko.dano++;
                            break;
                        case "2":
                            Console.WriteLine("VOCÊ usou a HABILIDADE - LAMBER e DESVIAR :P.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            Console.WriteLine("Aperte ENTER 2 vezes para LAMBER seu pelo e se CURAR do golpe do oponente.");
                            Console.WriteLine();

                            Console.WriteLine("Chlep.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado + 20 + npcNyanko.dano;
                            if (jogadorAtacado > jogador.vida)
                            {
                                int overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;

                                Console.WriteLine("Chlep.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado + 20 + npcNyanko.dano / 2;
                                

                                overLife = jogadorAtacado - jogador.vida;
                                jogadorAtacado -= overLife;

                            }
                            else
                            {
                                Console.WriteLine("Você CUROU sua FERIDA e DESVIA do PRÓXIMO GOLPE do inimigo. NYAN.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado - npcNyanko.dano;
                                jogadorAtacado = jogadorAtacado + npcNyanko.dano * 2;

                                Console.WriteLine(npcNyanko.nome + " ENCARA você ... OwO. Você se sente ATORDOADO.(ENTER)");
                                read = Console.ReadKey().KeyChar;
                                jogadorAtacado = jogadorAtacado - npcNyanko.dano++;

                            }

                            Console.WriteLine("Você CUROU sua FERIDA e você DESVIA do PRÓXIMO GOLPE do inimigo. NYAN.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado - npcNyanko.dano;
                            jogadorAtacado = jogadorAtacado + npcNyanko.dano * 2;

                            Console.WriteLine(npcNyanko.nome + " ENCARA você ... OwO. Você se sente ATORDOADO.(ENTER)");
                            read = Console.ReadKey().KeyChar;
                            jogadorAtacado = jogadorAtacado - npcNyanko.dano++;
                            break;

                    }
                }

            } while (jogadorAtacado > 0 && npcAtacado > 0);


            if (npcAtacado <= 0)
            {
                Console.WriteLine("\nNYAN!\nVocê VENCEU " + npcNyanko.nome + "! Você é o novo REI MEOW!(ENTER)");
                read = Console.ReadKey().KeyChar;
            }
            else if (jogadorAtacado <= 0)
            {
                Console.WriteLine("\tMOUW...Você PERDEU para "+ npcNyanko.nome + "\nAgora ele é o REI MEOW.");
                read = Console.ReadKey().KeyChar;

            }

        }

        public void imprimirBatalha(Personagem jogador, Inimigo npc, int npcAtacado, int jogadorAtacado)
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("RELATÓRIO DA BATALHA");
            Console.WriteLine("---------------------");
            Console.WriteLine("VOCÊ");
            Console.WriteLine("Nome do Gato:" + jogador.nome + "\nClasse do Gato:" + jogador.classe + "\nVida Atual: " + jogadorAtacado + "/" + jogador.vida + "\nDano:" + jogador.dano);
            Console.WriteLine("---------------------");
            Console.WriteLine("OPONENTE");
            Console.WriteLine("Nome do Gato:" + npc.nome + "\nClasse do Gato:" + npc.classe + "\nVida Atual: " + npcAtacado + "/" + npc.vida + "\nDano:" + npc.dano);
            Console.WriteLine("\n");
        }

    }

}
