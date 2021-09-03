
namespace Sistema_Escola
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastroResultado = new System.Windows.Forms.Button();
            this.textBimestre = new System.Windows.Forms.TextBox();
            this.textTurma = new System.Windows.Forms.TextBox();
            this.textEvento = new System.Windows.Forms.TextBox();
            this.textRM = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Evento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bimestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "RM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Resultado";
            // 
            // btnCadastroResultado
            // 
            this.btnCadastroResultado.BackColor = System.Drawing.Color.Gray;
            this.btnCadastroResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroResultado.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroResultado.Location = new System.Drawing.Point(629, 420);
            this.btnCadastroResultado.Name = "btnCadastroResultado";
            this.btnCadastroResultado.Size = new System.Drawing.Size(118, 32);
            this.btnCadastroResultado.TabIndex = 15;
            this.btnCadastroResultado.Text = "Cadastrar";
            this.btnCadastroResultado.UseVisualStyleBackColor = false;
            this.btnCadastroResultado.Click += new System.EventHandler(this.btnCadastroResultado_Click);
            // 
            // textBimestre
            // 
            this.textBimestre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBimestre.Location = new System.Drawing.Point(171, 162);
            this.textBimestre.Multiline = true;
            this.textBimestre.Name = "textBimestre";
            this.textBimestre.Size = new System.Drawing.Size(575, 24);
            this.textBimestre.TabIndex = 17;
            // 
            // textTurma
            // 
            this.textTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTurma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTurma.Location = new System.Drawing.Point(171, 105);
            this.textTurma.Multiline = true;
            this.textTurma.Name = "textTurma";
            this.textTurma.Size = new System.Drawing.Size(575, 22);
            this.textTurma.TabIndex = 21;
            // 
            // textEvento
            // 
            this.textEvento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEvento.Location = new System.Drawing.Point(171, 231);
            this.textEvento.Multiline = true;
            this.textEvento.Name = "textEvento";
            this.textEvento.Size = new System.Drawing.Size(575, 24);
            this.textEvento.TabIndex = 22;
            // 
            // textRM
            // 
            this.textRM.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRM.Location = new System.Drawing.Point(171, 284);
            this.textRM.Multiline = true;
            this.textRM.Name = "textRM";
            this.textRM.Size = new System.Drawing.Size(575, 24);
            this.textRM.TabIndex = 23;
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(171, 347);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(575, 24);
            this.textResultado.TabIndex = 24;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(145, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 32);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textRM);
            this.Controls.Add(this.textEvento);
            this.Controls.Add(this.textTurma);
            this.Controls.Add(this.textBimestre);
            this.Controls.Add(this.btnCadastroResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastroResultado;
        private System.Windows.Forms.TextBox textBimestre;
        private System.Windows.Forms.TextBox textTurma;
        private System.Windows.Forms.TextBox textEvento;
        private System.Windows.Forms.TextBox textRM;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}