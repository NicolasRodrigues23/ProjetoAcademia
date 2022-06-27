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
            dgvAluno.DataSource = aDAL.ConsultarTodos();
        }

        private void frmAluno_Load(object sender, EventArgs e) {
            dgvAluno.DataSource = aDAL.ConsultarTodos();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            aBLL.CodAluno = Convert.ToInt16(dgvAluno[0, dgvAluno.CurrentRow.Index].Value);
            aBLL = aDAL.Retornar(aBLL);
            txtNome.Text = aBLL.Nome;
            txtCPF.Text = aBLL.Cpf;
            txtRG.Text = aBLL.Rg;
            txtEmail.Text = aBLL.Email;
            txtNascimento.Value = aBLL.Data;

            tabControl1.SelectedTab = tabPage1;
        }
    }
}
