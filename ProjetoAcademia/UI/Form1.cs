using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Opacity += 0.1;
            if (Opacity == 1) timer1.Enabled = false;
        }

        private void brnAluno_Click(object sender, EventArgs e) {
            UI.frmAluno aluno = new UI.frmAluno();
            aluno.ShowDialog();
        }
    }
}
