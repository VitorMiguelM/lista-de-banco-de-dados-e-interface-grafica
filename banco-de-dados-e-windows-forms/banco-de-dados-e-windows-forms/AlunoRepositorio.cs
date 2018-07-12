using System;
using System.Collections.Generic;
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

        public int Inserir(Aluno aluno)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO caracteristicas_do_aluno (nome, codigo_da_matricula, nota_1, nota_2, nota_3, frequencia)  VALUES (@NOME, @CODIGO_DA_MATRICULA, @NOTA_1, @NOTA_2, @NOTA_3, @FREQUENCIA)";

            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_DE_MATRICULA", aluno.CodigoDeMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
        }
    }
}
