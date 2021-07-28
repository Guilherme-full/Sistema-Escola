
namespace Sistema_Escola
{
    partial class Sistema_Escola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Escola));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCadAluno = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsmSAIR = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAgenda = new System.Windows.Forms.PictureBox();
            this.pbResultados = new System.Windows.Forms.PictureBox();
            this.pbConsultar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadAluno)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbCadAluno
            // 
            this.pbCadAluno.BackColor = System.Drawing.Color.White;
            this.pbCadAluno.Image = ((System.Drawing.Image)(resources.GetObject("pbCadAluno.Image")));
            this.pbCadAluno.Location = new System.Drawing.Point(15, 9);
            this.pbCadAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCadAluno.Name = "pbCadAluno";
            this.pbCadAluno.Size = new System.Drawing.Size(92, 75);
            this.pbCadAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCadAluno.TabIndex = 1;
            this.pbCadAluno.TabStop = false;
            this.pbCadAluno.Click += new System.EventHandler(this.pbCadAluno_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.consultaToolStripMenuItem1,
            this.sobreToolStripMenuItem,
            this.stsmSAIR});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.resultadoToolStripMenuItem});
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultaToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // resultadoToolStripMenuItem
            // 
            this.resultadoToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.resultadoToolStripMenuItem.Name = "resultadoToolStripMenuItem";
            this.resultadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resultadoToolStripMenuItem.Text = "Resultado";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosCadastradosToolStripMenuItem,
            this.eventosCadastradosToolStripMenuItem,
            this.resultadosCadastradosToolStripMenuItem});
            this.consultaToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // alunosCadastradosToolStripMenuItem
            // 
            this.alunosCadastradosToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.alunosCadastradosToolStripMenuItem.Name = "alunosCadastradosToolStripMenuItem";
            this.alunosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.alunosCadastradosToolStripMenuItem.Text = "Alunos Cadastrados";
            // 
            // eventosCadastradosToolStripMenuItem
            // 
            this.eventosCadastradosToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.eventosCadastradosToolStripMenuItem.Name = "eventosCadastradosToolStripMenuItem";
            this.eventosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eventosCadastradosToolStripMenuItem.Text = "Eventos Cadastrados";
            // 
            // resultadosCadastradosToolStripMenuItem
            // 
            this.resultadosCadastradosToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.resultadosCadastradosToolStripMenuItem.Name = "resultadosCadastradosToolStripMenuItem";
            this.resultadosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.resultadosCadastradosToolStripMenuItem.Text = "Resultados";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // stsmSAIR
            // 
            this.stsmSAIR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsmSAIR.Name = "stsmSAIR";
            this.stsmSAIR.Size = new System.Drawing.Size(41, 20);
            this.stsmSAIR.Text = "Sair";
            this.stsmSAIR.Click += new System.EventHandler(this.stsmSAIR_Click);
            // 
            // pbAgenda
            // 
            this.pbAgenda.Image = ((System.Drawing.Image)(resources.GetObject("pbAgenda.Image")));
            this.pbAgenda.Location = new System.Drawing.Point(155, 9);
            this.pbAgenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbAgenda.Name = "pbAgenda";
            this.pbAgenda.Size = new System.Drawing.Size(94, 75);
            this.pbAgenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgenda.TabIndex = 3;
            this.pbAgenda.TabStop = false;
            this.pbAgenda.Click += new System.EventHandler(this.pbAgenda_Click);
            // 
            // pbResultados
            // 
            this.pbResultados.Image = ((System.Drawing.Image)(resources.GetObject("pbResultados.Image")));
            this.pbResultados.Location = new System.Drawing.Point(296, 9);
            this.pbResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbResultados.Name = "pbResultados";
            this.pbResultados.Size = new System.Drawing.Size(101, 74);
            this.pbResultados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResultados.TabIndex = 4;
            this.pbResultados.TabStop = false;
            // 
            // pbConsultar
            // 
            this.pbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("pbConsultar.Image")));
            this.pbConsultar.Location = new System.Drawing.Point(450, 9);
            this.pbConsultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbConsultar.Name = "pbConsultar";
            this.pbConsultar.Size = new System.Drawing.Size(98, 75);
            this.pbConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConsultar.TabIndex = 5;
            this.pbConsultar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pbConsultar);
            this.panel1.Controls.Add(this.pbResultados);
            this.panel1.Controls.Add(this.pbAgenda);
            this.panel1.Controls.Add(this.pbCadAluno);
            this.panel1.Location = new System.Drawing.Point(120, 211);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 94);
            this.panel1.TabIndex = 6;
            // 
            // Sistema_Escola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sistema_Escola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Escola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sistema_Escola_FormClosed);
            this.Load += new System.EventHandler(this.Sistema_Escola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadAluno)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbCadAluno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbAgenda;
        private System.Windows.Forms.PictureBox pbResultados;
        private System.Windows.Forms.PictureBox pbConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stsmSAIR;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosCadastradosToolStripMenuItem;
    }
}