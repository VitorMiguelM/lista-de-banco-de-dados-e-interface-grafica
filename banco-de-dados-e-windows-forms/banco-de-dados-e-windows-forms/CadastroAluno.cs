using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_de_dados_e_windows_forms
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }
        private int codigo;

        public void PreencherCampos(Aluno aluno)
        {

            txtNome.Text = aluno.Nome;
            txtCodigoDaMatricula.Text = aluno.CodigoDeMatricula;
            txtFrequencia.Text = aluno.Frequencia.ToString();
            txtId.Text = aluno.Id.ToString();
            txtNota1.Text = aluno.Nota1.ToString();
            txtNota2.Text = aluno.Nota2.ToString();
            txtNota3.Text = aluno.Nota3.ToString();
            
        }
        public CadastroAluno(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            Aluno aluno = new AlunoRepositorio().ObterPeloCodigoDeMatricula(codigo);
            PreencherCampos(aluno);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.CodigoDeMatricula = txtCodigoDaMatricula.Text;
            aluno.Frequencia = Convert.ToByte(txtCodigoDaMatricula.Text);
            aluno.Nota1 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota2 = Convert.ToDouble(txtNota2.Text);
            aluno.Nota3 = Convert.ToDouble(txtNota3.Text);
            aluno.Id = Convert.ToInt32(txtId.Text);

            if(string.IsNullOrEmpty(txtId.Text))
            {
                int id = new AlunoRepositorio().Inserir(aluno);
                txtId.Text = Convert.ToString(id);
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                aluno.Id = id;
                bool editou = new AlunoRepositorio().Editar(aluno);
                if(editou)
                {
                    MessageBox.Show("Editado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível editar =(");
                }
            }


            

            LimparCampos();
            ShowDialog();
        }

        public void LimparCampos()
        {
            txtNome.Text = "";
            txtCodigoDaMatricula.Text = "";
            txtFrequencia.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtId.Text = "";
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodigoDaMatricula.Text))
            {
                try
                {
                    int CodigoDaMatricula = Convert.ToInt32(txtCodigoDaMatricula.Text);
                    Aluno aluno = new AlunoRepositorio().ObterPeloCodigoDeMatricula(codigo);
                    if(aluno != null)
                    {
                        PreencherCampos(aluno);
                    }
                    else
                    {
                        MessageBox.Show("Esse aluno não existe!");
                        txtCodigoDaMatricula.Focus();
                        txtCodigoDaMatricula.SelectionStart = 0;
                        txtCodigoDaMatricula.SelectionLength = txtCodigoDaMatricula.Text.Length;
                    }
                }
                catch
                {
                    MessageBox.Show("Digite um código válido!");
                }
            }
        }
    }
}
