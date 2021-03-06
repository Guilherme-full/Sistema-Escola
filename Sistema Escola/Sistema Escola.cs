using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escola
{
    public partial class Sistema_Escola : Form
    {
        public Sistema_Escola()
        {
            InitializeComponent();
        }

        private void Sistema_Escola_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.Width / 2 - 282 , this.Height / 2 - 44);
        }

        private void pbCadAluno_Click(object sender, EventArgs e)
        {
            Cadastro_de_Aluno cadAluno = new Cadastro_de_Aluno();
            cadAluno.Show();
        }

        private void stsmSAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sistema_Escola_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbAgenda_Click(object sender, EventArgs e)
        {
            Agenda age = new Agenda();
            age.Show();
        }

        private void pbResultados_Click(object sender, EventArgs e)
        {
            Resultados result = new Resultados();
            result.Show();
        }

        private void pbConsultar_Click(object sender, EventArgs e)
        {
            Verificar_Resultados vR = new Verificar_Resultados();
            vR.Show();
        }

        private void atsmAluno_Click(object sender, EventArgs e)
        {
            Cadastro_de_Aluno cadAluno = new Cadastro_de_Aluno();
            cadAluno.Show();
        }

        private void atsmAgenda_Click(object sender, EventArgs e)
        {
            Agenda age = new Agenda();
            age.Show();
        }

        private void rtsmResultado_Click(object sender, EventArgs e)
        {
            Resultados result = new Resultados();
            result.Show();
        }

        private void actsAlunosCad_Click(object sender, EventArgs e)
        {
            Alunos_Cadastrados AluCad = new Alunos_Cadastrados();
            AluCad.Show();
        }

        private void rtsReultados_Click(object sender, EventArgs e)
        {
            Verificar_Resultados vR = new Verificar_Resultados();
            vR.Show();
        }

        private void ectsEventCad_Click(object sender, EventArgs e)
        {
            Agenda_Cadastrada AgeCad = new Agenda_Cadastrada();
            AgeCad.Show();
        }

        private void stpSobre_Click(object sender, EventArgs e)
        {
            Sobre sob = new Sobre();
            sob.Show();
        }
    }
}
