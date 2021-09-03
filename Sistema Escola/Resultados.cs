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
    public partial class Resultados : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Resultados()
        {
            InitializeComponent();
        }

        private void btnCadastroResultado_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=192.168.15.2;Database=SistemaEscola;Uid=AdministradorEscola;Pwd=administrador123");
                strSQL = "insert into CadastroResultado (turma, bimestre, evento, rm, resultado) values (@turma, @bimestre, @evento, @rm, @resultado)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@turma", textTurma.Text);
                comando.Parameters.AddWithValue("@bimestre", textBimestre.Text);
                comando.Parameters.AddWithValue("@evento", textEvento.Text);
                comando.Parameters.AddWithValue("@rm", textRM.Text);
                comando.Parameters.AddWithValue("@resultado", textResultado.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Resultados Cadastrados", "Cadastro", MessageBoxButtons.OK);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textTurma.Text = "";
            textBimestre.Text = "";
            textEvento.Text = "";
            textRM.Text = "";
            textResultado.Text = "";
            textTurma.Focus();
        }
    }
}
