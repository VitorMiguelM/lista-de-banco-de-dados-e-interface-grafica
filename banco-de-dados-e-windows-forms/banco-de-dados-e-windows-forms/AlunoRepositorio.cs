using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_de_dados_e_windows_forms
{
    class AlunoRepositorio
    {
         
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\105013\Documents\Lista de Banco de dados e Interface Gráfica.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;

        public AlunoRepositorio()
        {
            connection = new SqlConnection(connectionString);
        }

        public bool Editar(Aluno aluno)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Update caracteristicas_do_aluno SET nome = @NOME, codigo_de_matricula = @CODIGO_DE_MATRICULA, nota_1 = @NOTA_1, nota_2 = @NOTA_2, nota_3 = @NOTA_3, frequencia = @FREQUENCIA WHERE id = @ID";

            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_DE_MATRICULA", aluno.CodigoDeMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            command.Parameters.AddWithValue("@ID", aluno.Id);

            int quantidadeEditados = command.ExecuteNonQuery();
            connection.Close();
            return quantidadeEditados == 1;
        }

        public int Inserir(Aluno aluno)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO caracteristicas_do_aluno (nome, codigo_da_matricula, nota_1, nota_2, nota_3, frequencia, id) OUTPUT INSERTED.ID VALUES (@NOME, @CODIGO_DA_MATRICULA, @NOTA_1, @NOTA_2, @NOTA_3, @FREQUENCIA, @ID)";

            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_DE_MATRICULA", aluno.CodigoDeMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            command.Parameters.AddWithValue("@ID", aluno.Id);

            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            return id;
        }

        public List<Aluno> ObterTodos(string textoParaPesquisar = "%%", string colunaOrdenar = "nome", string tipoOrdenar = "ASC")
        {               
            textoParaPesquisar = "%" + textoParaPesquisar + "%";
            List<Aluno> alunos = new List<Aluno>();
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "SELECT nome, codigo_de_matricula, nota_1, nota_2, nota_3, (nota_1 + nota_2 + nota_3)/4 'Média' FROM caracteristicas_do_aluno WHERE nome LIKE @PESQUISA OR codigo_de_matricula LIKE @PESQUISA ORDER BY" + colunaOrdenar + " " + tipoOrdenar;

            command.Parameters.AddWithValue("@PESQUISA", textoParaPesquisar);

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(command.ExecuteReader());

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                Aluno aluno = new Aluno();
                aluno.Nome = tabelaEmMemoria.Rows[i][0].ToString();
                aluno.CodigoDeMatricula = tabelaEmMemoria.Rows[i][1].ToString();
                aluno.Nota1 = Convert.ToDouble(tabelaEmMemoria.Rows[i][2].ToString());
                aluno.Nota2 = Convert.ToDouble(tabelaEmMemoria.Rows[i][3].ToString());
                aluno.Nota3 = Convert.ToDouble(tabelaEmMemoria.Rows[i][4].ToString());
                alunos.Add(aluno);
            }

            connection.Close();
            return alunos;
        }

        public bool Deletar(int id)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "DELETE FROM caracteristicas_do_aluno WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);

            int quantidadeDeletada = command.ExecuteNonQuery();
            connection.Close();
            return quantidadeDeletada == 1;
        }

        public Aluno ObterPeloCodigoDeMatricula(int codigoDeMatricula)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            Aluno aluno = new Aluno();
            command.CommandText = "SELECT nome. codigo_de_matricula, frequencia, nota_1, nota_2, nota_3, id FROM caracteristicas_do_aluno WHERE id = @CODIGODEMATRICULA";
            command.Parameters.AddWithValue("@CODIGODEMATRICULA", aluno.CodigoDeMatricula);
            
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(command.ExecuteReader());
            if(tabelaEmMemoria.Rows.Count == 0)
            {
                return null;
            }

            aluno.Nome = tabelaEmMemoria.Rows[0][1].ToString();
            aluno.CodigoDeMatricula = tabelaEmMemoria.Rows[0][2].ToString();
            aluno.Frequencia = Convert.ToByte(tabelaEmMemoria.Rows[0][3].ToString());
            aluno.Nota1 = Convert.ToDouble(tabelaEmMemoria.Rows[0][4].ToString());
            aluno.Nota2 = Convert.ToDouble(tabelaEmMemoria.Rows[0][5].ToString());
            aluno.Nota3 = Convert.ToDouble(tabelaEmMemoria.Rows[0][6].ToString());
            aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[0][7].ToString());
            connection.Close();
            return aluno;
        }
    }
}
