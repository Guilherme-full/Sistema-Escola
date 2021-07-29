
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
            this.atsmAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.atsmAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.rtsmResultado = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actsAlunosCad = new System.Windows.Forms.ToolStripMenuItem();
            this.ectsEventCad = new System.Windows.Forms.ToolStripMenuItem();
            this.rtsReultados = new System.Windows.Forms.ToolStripMenuItem();
            this.stpSobre = new System.Windows.Forms.ToolStripMenuItem();
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
            this.stpSobre,
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
            this.atsmAluno,
            this.atsmAgenda,
            this.rtsmResultado});
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultaToolStripMenuItem.Text = "Cadastro";
            // 
            // atsmAluno
            // 
            this.atsmAluno.BackColor = System.Drawing.Color.Gray;
            this.atsmAluno.Name = "atsmAluno";
            this.atsmAluno.Size = new System.Drawing.Size(131, 22);
            this.atsmAluno.Text = "Aluno";
            this.atsmAluno.Click += new System.EventHandler(this.atsmAluno_Click);
            // 
            // atsmAgenda
            // 
            this.atsmAgenda.BackColor = System.Drawing.Color.Gray;
            this.atsmAgenda.Name = "atsmAgenda";
            this.atsmAgenda.Size = new System.Drawing.Size(131, 22);
            this.atsmAgenda.Text = "Agenda";
            this.atsmAgenda.Click += new System.EventHandler(this.atsmAgenda_Click);
            // 
            // rtsmResultado
            // 
            this.rtsmResultado.BackColor = System.Drawing.Color.Gray;
            this.rtsmResultado.Name = "rtsmResultado";
            this.rtsmResultado.Size = new System.Drawing.Size(131, 22);
            this.rtsmResultado.Text = "Resultado";
            this.rtsmResultado.Click += new System.EventHandler(this.rtsmResultado_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actsAlunosCad,
            this.ectsEventCad,
            this.rtsReultados});
            this.consultaToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // actsAlunosCad
            // 
            this.actsAlunosCad.BackColor = System.Drawing.Color.Gray;
            this.actsAlunosCad.Name = "actsAlunosCad";
            this.actsAlunosCad.Size = new System.Drawing.Size(193, 22);
            this.actsAlunosCad.Text = "Alunos Cadastrados";
            this.actsAlunosCad.Click += new System.EventHandler(this.actsAlunosCad_Click);
            // 
            // ectsEventCad
            // 
            this.ectsEventCad.BackColor = System.Drawing.Color.Gray;
            this.ectsEventCad.Name = "ectsEventCad";
            this.ectsEventCad.Size = new System.Drawing.Size(193, 22);
            this.ectsEventCad.Text = "Eventos Cadastrados";
            this.ectsEventCad.Click += new System.EventHandler(this.ectsEventCad_Click);
            // 
            // rtsReultados
            // 
            this.rtsReultados.BackColor = System.Drawing.Color.Gray;
            this.rtsReultados.Name = "rtsReultados";
            this.rtsReultados.Size = new System.Drawing.Size(193, 22);
            this.rtsReultados.Text = "Resultados";
            this.rtsReultados.Click += new System.EventHandler(this.rtsReultados_Click);
            // 
            // stpSobre
            // 
            this.stpSobre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stpSobre.Name = "stpSobre";
            this.stpSobre.Size = new System.Drawing.Size(52, 20);
            this.stpSobre.Text = "Sobre";
            this.stpSobre.Click += new System.EventHandler(this.stpSobre_Click);
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
            this.pbResultados.Click += new System.EventHandler(this.pbResultados_Click);
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
            this.pbConsultar.Click += new System.EventHandler(this.pbConsultar_Click);
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
        private System.Windows.Forms.ToolStripMenuItem stpSobre;
        private System.Windows.Forms.ToolStripMenuItem stsmSAIR;
        private System.Windows.Forms.ToolStripMenuItem atsmAluno;
        private System.Windows.Forms.ToolStripMenuItem atsmAgenda;
        private System.Windows.Forms.ToolStripMenuItem rtsmResultado;
        private System.Windows.Forms.ToolStripMenuItem actsAlunosCad;
        private System.Windows.Forms.ToolStripMenuItem ectsEventCad;
        private System.Windows.Forms.ToolStripMenuItem rtsReultados;
    }
}