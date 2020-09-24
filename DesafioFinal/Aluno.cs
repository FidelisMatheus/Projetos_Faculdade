using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal
{
    public class Aluno
    {
        private string nome;
        private string cidade;
        private string nivel;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Nivel { get => nivel; set => nivel = value; }

        public string mostra()
        {
            string aux = "";
            aux += "Nome: " + nome + "\t\t\tIdade: " + idade.ToString() + "\t\tNível de conhecimento: " + nivel;
            aux += "\t\tCidade: " + cidade;
            return aux;
        }
    }
}
