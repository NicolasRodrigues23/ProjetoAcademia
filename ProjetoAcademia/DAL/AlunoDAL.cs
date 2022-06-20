using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.DAL {
    internal class AlunoDAL {
        public void Cadastrar(BLL.AlunoBLL aluno) {
            //verificar se o valor do form chega aqui
            System.Windows.Forms.MessageBox.Show("Nome: " + aluno.Nome);
        }
    }
}
