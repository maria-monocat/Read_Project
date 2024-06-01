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

        public Personagem(string nome, int vida, string classe) {
            this.nome = nome;
            this.vida = vida;
            this.classe = classe;
        }

        public Personagem criar()
        {
            return new Personagem(nome, vida, classe);
        }

    }
}
