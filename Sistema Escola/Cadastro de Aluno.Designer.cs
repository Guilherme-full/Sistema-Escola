
namespace Sistema_Escola
{
    partial class Cadastro_de_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Aluno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNomeCompleto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDataDeNascimento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textResponsável = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnCadastroAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textTurma = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(866, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro Aluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome Completo";
            // 
            // textNomeCompleto
            // 
            this.textNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeCompleto.Location = new System.Drawing.Point(205, 160);
            this.textNomeCompleto.Multiline = true;
            this.textNomeCompleto.Name = "textNomeCompleto";
            this.textNomeCompleto.Size = new System.Drawing.Size(600, 21);
            this.textNomeCompleto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de Nascimento";
            // 
            // textDataDeNascimento
            // 
            this.textDataDeNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDataDeNascimento.Location = new System.Drawing.Point(205, 224);
            this.textDataDeNascimento.Multiline = true;
            this.textDataDeNascimento.Name = "textDataDeNascimento";
            this.textDataDeNascimento.Size = new System.Drawing.Size(600, 21);
            this.textDataDeNascimento.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(79, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Responsável";
            // 
            // textResponsável
            // 
            this.textResponsável.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResponsável.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResponsável.Location = new System.Drawing.Point(205, 290);
            this.textResponsável.Multiline = true;
            this.textResponsável.Name = "textResponsável";
            this.textResponsável.Size = new System.Drawing.Size(600, 21);
            this.textResponsável.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(144, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(205, 363);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(600, 21);
            this.textEmail.TabIndex = 13;
            // 
            // btnCadastroAluno
            // 
            this.btnCadastroAluno.BackColor = System.Drawing.Color.Blue;
            this.btnCadastroAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAluno.ForeColor = System.Drawing.Color.White;
            this.btnCadastroAluno.Location = new System.Drawing.Point(687, 479);
            this.btnCadastroAluno.Name = "btnCadastroAluno";
            this.btnCadastroAluno.Size = new System.Drawing.Size(118, 32);
            this.btnCadastroAluno.TabIndex = 14;
            this.btnCadastroAluno.Text = "Cadastrar";
            this.btnCadastroAluno.UseVisualStyleBackColor = false;
            this.btnCadastroAluno.Click += new System.EventHandler(this.btnCadastroAluno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Turma";
            // 
            // textTurma
            // 
            this.textTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTurma.Location = new System.Drawing.Point(205, 111);
            this.textTurma.Multiline = true;
            this.textTurma.Name = "textTurma";
            this.textTurma.Size = new System.Drawing.Size(600, 21);
            this.textTurma.TabIndex = 16;
            // 
            // Cadastro_de_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 538);
            this.Controls.Add(this.textTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastroAluno);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textResponsável);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDataDeNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNomeCompleto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_de_Aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNomeCompleto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDataDeNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textResponsável;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnCadastroAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTurma;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}