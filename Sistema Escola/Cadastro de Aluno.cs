using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Sistema_Escola
{
    public partial class Cadastro_de_Aluno : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro_de_Aluno()
        {
            InitializeComponent();
        }

        private void btnCadastroAluno_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=SistemaEscola;Uid=AdministradorEscola;Pwd=administrador123");
                strSQL = "insert into CadastroAluno(turma, Nome_Completo, Data_de_Nascimento, Responsável, email) values (@turma, @Nome_Completo, @Data_de_Nascimento, @Responsável, @email)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@turma", textTurma.Text);
                comando.Parameters.AddWithValue("@Nome_Completo", textNomeCompleto.Text);
                comando.Parameters.AddWithValue("@Data_de_Nascimento", textDataDeNascimento.Text);
                comando.Parameters.AddWithValue("@Responsável", textResponsável.Text);
                comando.Parameters.AddWithValue("@email", textEmail.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textTurma.Text = "";
            textNomeCompleto.Text = "";
            textDataDeNascimento.Text = "";
            textResponsável.Text = "";
            textEmail.Text = "";
            textTurma.Focus();
        }
    }
}
