namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEscolaridade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorCurso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorMulta = new System.Windows.Forms.TextBox();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(389, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(429, 34);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(223, 23);
            this.txtCurso.TabIndex = 2;
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escolaridade";
            // 
            // txtEscolaridade
            // 
            this.txtEscolaridade.Location = new System.Drawing.Point(22, 101);
            this.txtEscolaridade.Name = "txtEscolaridade";
            this.txtEscolaridade.Size = new System.Drawing.Size(223, 23);
            this.txtEscolaridade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(251, 101);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(223, 23);
            this.txtDataNascimento.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Curso";
            // 
            // txtValorCurso
            // 
            this.txtValorCurso.Location = new System.Drawing.Point(22, 157);
            this.txtValorCurso.Name = "txtValorCurso";
            this.txtValorCurso.Size = new System.Drawing.Size(86, 23);
            this.txtValorCurso.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor Desconto";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(126, 157);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(86, 23);
            this.txtValorDesconto.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor Multa";
            // 
            // txtValorMulta
            // 
            this.txtValorMulta.Location = new System.Drawing.Point(234, 157);
            this.txtValorMulta.Name = "txtValorMulta";
            this.txtValorMulta.Size = new System.Drawing.Size(86, 23);
            this.txtValorMulta.TabIndex = 12;
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Location = new System.Drawing.Point(0, 210);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(800, 23);
            this.btnSalvarDados.TabIndex = 14;
            this.btnSalvarDados.Text = "Salvar Dados";
            this.btnSalvarDados.UseVisualStyleBackColor = true;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Idade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lista de Cursos";
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIdade.Location = new System.Drawing.Point(485, 101);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(86, 23);
            this.txtIdade.TabIndex = 18;
            // 
            // txtLista
            // 
            this.txtLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtLista.Enabled = false;
            this.txtLista.Location = new System.Drawing.Point(12, 278);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(764, 160);
            this.txtLista.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSalvarDados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorMulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorDesconto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEscolaridade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtCurso;
        private Label label3;
        private TextBox txtEscolaridade;
        private Label label4;
        private TextBox txtDataNascimento;
        private Label label5;
        private TextBox txtValorCurso;
        private Label label6;
        private TextBox txtValorDesconto;
        private Label label7;
        private TextBox txtValorMulta;
        private Button btnSalvarDados;
        private Label label8;
        private Label label9;
        private TextBox txtIdade;
        private TextBox txtLista;
    }
}