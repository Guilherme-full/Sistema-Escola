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
    public partial class Agenda : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;

        public Agenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=SistemaEscola;Uid=AdministradorEscola;Pwd=administrador123");
                strSQL = "insert into CadastroAgenda (turma, bimestre, evento, data) values (@turma, @bimestre, @evento, @data)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@turma", textTurma.Text);
                comando.Parameters.AddWithValue("@bimestre", textBimestre.Text);
                comando.Parameters.AddWithValue("@evento", textEvento.Text);
                comando.Parameters.AddWithValue("@data", textData.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado", "Cadastro", MessageBoxButtons.OK);
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
            textBimestre.Text = "";
            textEvento.Text = "";
            textData.Text = "";
            textTurma.Focus();
        }
    }
}
