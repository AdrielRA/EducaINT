using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaINT
{
    public class Aluno
    {
        private string nome, senha;

        private int id_avatar;
        private List<Resposta> respostas;

        public struct Resposta
        {
            public int id_pergunta;
            public double pontos;
            public bool acertou;
        }

        public int Id_avatar { get => id_avatar; set => id_avatar = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public List<Resposta> Respostas { get => respostas; set => respostas = value; }

        public Aluno()
        {
            id_avatar = -1;
            Respostas = new List<Resposta>();
        }
    }

    public class Data_Aluno
    {
        private string nome;
        private int qnt_Respostas, qnt_Acertos;

        public string Nome { get => nome; set => nome = value; }
        public int Qnt_Respostas { get => qnt_Respostas; set => qnt_Respostas = value; }
        public int Qnt_Acertos { get => qnt_Acertos; set => qnt_Acertos = value; }
    }
}
