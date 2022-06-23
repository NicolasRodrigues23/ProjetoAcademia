using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL {
    internal class AlunoBLL {

        //gerar get e set atalho: Ctrl + R + E
        private int codAluno;
        private string nome;
        private string cpf;
        private string rg;
        private string email;
        private DateTime data;

        public int CodAluno { get => codAluno; set => codAluno = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
