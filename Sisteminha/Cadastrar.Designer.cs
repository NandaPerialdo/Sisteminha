namespace Sisteminha
{
    partial class Cadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finalizarCadastro = new System.Windows.Forms.Button();
            this.voltarCadastro = new System.Windows.Forms.Button();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.codigo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(88, 149);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(167, 20);
            this.nome.TabIndex = 3;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(88, 201);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(167, 20);
            this.cidade.TabIndex = 7;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(88, 227);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(167, 20);
            this.estado.TabIndex = 9;
            this.estado.TextChanged += new System.EventHandler(this.estado_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cadastrar Pessoa";
            // 
            // finalizarCadastro
            // 
            this.finalizarCadastro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.finalizarCadastro.Location = new System.Drawing.Point(122, 273);
            this.finalizarCadastro.Name = "finalizarCadastro";
            this.finalizarCadastro.Size = new System.Drawing.Size(92, 35);
            this.finalizarCadastro.TabIndex = 11;
            this.finalizarCadastro.Text = "Finalizar";
            this.finalizarCadastro.UseVisualStyleBackColor = false;
            this.finalizarCadastro.Click += new System.EventHandler(this.finalizarCadastro_Click);
            // 
            // voltarCadastro
            // 
            this.voltarCadastro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.voltarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarCadastro.Location = new System.Drawing.Point(122, 323);
            this.voltarCadastro.Name = "voltarCadastro";
            this.voltarCadastro.Size = new System.Drawing.Size(92, 35);
            this.voltarCadastro.TabIndex = 12;
            this.voltarCadastro.Text = "Voltar";
            this.voltarCadastro.UseVisualStyleBackColor = false;
            this.voltarCadastro.Click += new System.EventHandler(this.voltarCadastro_Click);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(88, 175);
            this.telefone.Mask = "(99)99999-9999";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(167, 20);
            this.telefone.TabIndex = 13;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(88, 123);
            this.codigo.Mask = "99999";
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(167, 20);
            this.codigo.TabIndex = 14;
            this.codigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigo_MaskInputRejected);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 445);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.voltarCadastro);
            this.Controls.Add(this.finalizarCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button finalizarCadastro;
        private System.Windows.Forms.Button voltarCadastro;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox codigo;
    }
}