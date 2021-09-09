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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var conexao = "Server=127.0.0.1;Database=cadastrousuariosescola;Uid=Escola;Pwd=escola19098";
            var connection = new MySqlConnection(conexao);
            var comand = connection.CreateCommand();
            MySqlCommand query = new MySqlCommand("select count(*) from cadastrosusuarioses where email='" + textEmail.Text + "'and senha='" + textSenha.Text + "'", connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);

            foreach (DataRow list in dataTable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    MessageBox.Show("Usuario valido", "validação", MessageBoxButtons.OK);
                    Sistema_Escola sisEs = new Sistema_Escola();
                    sisEs.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario Invalido", "validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connection.Close();
            }
            
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
