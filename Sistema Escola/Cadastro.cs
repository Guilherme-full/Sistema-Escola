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
    public partial class Cadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbLogin_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Visible = false;
        }

        private void pbCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=192.168.15.5;Database=cadastrousuariosescola;Uid=Escola;Pwd=escola19098");
                strSQL = "insert into cadastrosusuarioses (nome, sobrenome, estado, cidade, email, senha) values (@nome, @sobrenome, @estado, @cidade, @email, @senha)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", textNOME.Text);
                comando.Parameters.AddWithValue("@sobrenome", textSOBRENOME.Text);
                comando.Parameters.AddWithValue("@estado", textESTADO.Text);
                comando.Parameters.AddWithValue("@cidade", textCIDADE.Text);
                comando.Parameters.AddWithValue("@email", textEMAIL.Text);
                comando.Parameters.AddWithValue("@senha", textSENHA.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso");

            }
            catch (Exception ex)
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
    }
}
