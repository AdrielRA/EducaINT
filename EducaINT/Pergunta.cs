using System.Collections.Generic;

namespace EducaINT
{
    public class Pergunta
    {
        private string tema;
        private int id;
        private List<string> alternativas;
        private int resposta_Certa;
        private double pontuacao;
        private string questao;

        public string Tema { get => tema; set => tema = value; }
        public List<string> Alternativas { get => alternativas; set => alternativas = value; }
        public int Resposta_Certa { get => resposta_Certa; set => resposta_Certa = value; }
        public double Pontuacao { get => pontuacao; set => pontuacao = value; }
        public string Questao { get => questao; set => questao = value; }
        public int Id { get => id; set => id = value; }

        public Pergunta ()
        {
            Alternativas = new List<string>();
        }



    }
}