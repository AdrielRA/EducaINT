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

        public int Id_avatar { get => id_avatar; set => id_avatar = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }

        public Aluno()
        {
            id_avatar = -1;
        }
    }
}
