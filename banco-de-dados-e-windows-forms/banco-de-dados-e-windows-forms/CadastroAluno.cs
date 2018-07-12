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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.CodigoDeMatricula = txtCodigoDaMatricula.Text;
            aluno.Frequencia = Convert.ToByte(txtCodigoDaMatricula.Text);
            aluno.Nota1 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota2 = Convert.ToDouble(txtNota2.Text);
            aluno.Nota3 = Convert.ToDouble(txtNota3.Text);

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
        }
    }
}
