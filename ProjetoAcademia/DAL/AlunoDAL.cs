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

        public DataTable ConsultarTodos() {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM ALUNO", conn.Conectar());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Desconectar();
            return dt;
        }

        public void Atualizar(BLL.AlunoBLL aluno) {
            SqlCommand cmd = new SqlCommand(@"UPDATE ALUNO 
                SET NOME = @NOME, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, DATANASCIMENTO = @DATANASCIMENTO
                WHERE CODALUNO = @CODALUNO");

            cmd.Parameters.AddWithValue("@NOME", aluno.Nome);
            cmd.Parameters.AddWithValue("@CPF", aluno.Cpf);
            cmd.Parameters.AddWithValue("@RG", aluno.Rg);
            cmd.Parameters.AddWithValue("@EMAIL", aluno.Email);
            cmd.Parameters.AddWithValue("@DATANASCIMENTO", aluno.Data);

            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public BLL.AlunoBLL Retornar(BLL.AlunoBLL aluno) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ALUNO WHERE CODALUNO = @CODALUNO";
            cmd.Parameters.AddWithValue("@CODALUNO", aluno.CodAluno);
            cmd.Connection = conn.Conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                aluno.CodAluno = Convert.ToInt32(dr["CODALUNO"]);
                aluno.Nome = dr["NOME"].ToString();
                aluno.Cpf = dr["CPF"].ToString();
                aluno.Rg = dr["RG"].ToString();
                aluno.Email = dr["EMAIL"].ToString();
                aluno.Data = Convert.ToDateTime(dr["DATANASCIMENTO"].ToString());
            }
            dr.Close();
            conn.Desconectar();
            return aluno;
        }
    }
}
