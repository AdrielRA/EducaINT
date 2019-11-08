using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaINT
{
    public class Aluno
    {
        // Aqui todos os metodos e propriedades para esta classe!
        private int id_avatar;

        public int Id_avatar { get => id_avatar; set => id_avatar = value; }

        public Aluno()
        {
            id_avatar = -1;
        }
    }
}
