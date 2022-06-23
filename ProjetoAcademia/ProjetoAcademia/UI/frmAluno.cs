using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia.UI {
    public partial class frmAluno : Form {

        //referenciar BLL e DAL
        BLL.AlunoBLL aBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL aDAL = new DAL.AlunoDAL();

        public frmAluno() {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            //enviar valores para BLL
            aBLL.Nome   = txtNome.Text;
            aBLL.Cpf    = txtCPF.Text;
            aBLL.Rg     = txtRG.Text;
            aBLL.Email  = txtEmail.Text;
            aBLL.Data   = txtNascimento.Value;
            
            //executar o método da DAL enviando os dados BLL
            aDAL.Cadastrar(aBLL);
            MessageBox.Show("DADOS GRAVADOS COM SUCESSO!");
        }
    }
}
