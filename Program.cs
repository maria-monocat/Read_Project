using Microsoft.VisualBasic.FileIO;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Read_Project
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Personagem jogador = new Personagem();
            Quest missao = new Quest();

            missao.lerIntro();

            jogador.inputClasseJogador(jogador);
            
        }

    }
}
