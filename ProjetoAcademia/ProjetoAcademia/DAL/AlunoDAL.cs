using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAcademia.DAL {
    internal class AlunoDAL {
        Conexao conn = new Conexao();
        public void Cadastrar(BLL.AlunoBLL aluno) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO ALUNO (NOME, CPF, RG, EMAIL, DATANASCIMENTO) 
                                VALUES (@NOME, @CPF, @RG, @EMAIL, @DATANASCIMENTO)";

            cmd.Parameters.AddWithValue("@NOME", aluno.Nome);
            cmd.Parameters.AddWithValue("@CPF", aluno.Cpf);
            cmd.Parameters.AddWithValue("@RG", aluno.Rg);
            cmd.Parameters.AddWithValue("@EMAIL", aluno.Email);
            cmd.Parameters.AddWithValue("@DATANASCIMENTO", aluno.Data);

            cmd.Connection = conn.Conectar();
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }
    }
}
