using System.Collections.Generic;

namespace EducaINT
{
    public class Pergunta
    {
        // Aqui todos os metodos e propriedades para esta classe!
        private string tema;

        private List<string> alternativas;
        private int resposta_Certa;
        private double pontuacao;
        private string questao;

        public string Tema { get => tema; set => tema = value; }
        public List<string> Alternativas { get => alternativas; set => alternativas = value; }
        public int Resposta_Certa { get => resposta_Certa; set => resposta_Certa = value; }
        public double Pontuacao { get => pontuacao; set => pontuacao = value; }
        public string Questao { get => questao; set => questao = value; }

        public Pergunta ()
        {
            Alternativas = new List<string>();
        }



    }
}