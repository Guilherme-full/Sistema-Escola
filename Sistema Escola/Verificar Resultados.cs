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
    public partial class Verificar_Resultados : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Verificar_Resultados()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=192.168.15.2;Database=SistemaEscola;Uid=AdministradorEscola;Pwd=administrador123");
                strSQL = "select pp.Turma as Turma,pp.bimestre as Bimestre, pp.rm as RM, pc.nome_completo as 'Nome do Aluno', pp.evento as Evento, pp.Resultado from CadastroResultado pp inner join CadastroAluno pc on pp.rm = pc.rm";
                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultados.DataSource = dt;
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

        private void Verificar_Resultados_Load(object sender, EventArgs e)
        {
            pnlResultados.Location = new Point(this.Width / 2 - 461, this.Height / 2 - 260);
        }
    }
}
