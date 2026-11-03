namespace ATIVIDADE__ESTAGIO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_Saude = new System.Windows.Forms.RadioButton();
            this.rdb_Enge = new System.Windows.Forms.RadioButton();
            this.rdb_Comp = new System.Windows.Forms.RadioButton();
            this.rdb_Adm = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Escolaridade = new System.Windows.Forms.ComboBox();
            this.ckb_Versp = new System.Windows.Forms.CheckBox();
            this.ckb_Noturno = new System.Windows.Forms.CheckBox();
            this.ckb_Mat = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Mes = new System.Windows.Forms.TextBox();
            this.txt_Ano = new System.Windows.Forms.TextBox();
            this.txt_Dia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.rdb_Saude);
            this.panel1.Controls.Add(this.rdb_Enge);
            this.panel1.Controls.Add(this.rdb_Comp);
            this.panel1.Controls.Add(this.rdb_Adm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbx_Escolaridade);
            this.panel1.Controls.Add(this.ckb_Versp);
            this.panel1.Controls.Add(this.ckb_Noturno);
            this.panel1.Controls.Add(this.ckb_Mat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Calcular);
            this.panel1.Controls.Add(this.txt_idade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Mes);
            this.panel1.Controls.Add(this.txt_Ano);
            this.panel1.Controls.Add(this.txt_Dia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 721);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rdb_Saude
            // 
            this.rdb_Saude.AutoSize = true;
            this.rdb_Saude.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Saude.Location = new System.Drawing.Point(18, 357);
            this.rdb_Saude.Name = "rdb_Saude";
            this.rdb_Saude.Size = new System.Drawing.Size(74, 27);
            this.rdb_Saude.TabIndex = 26;
            this.rdb_Saude.TabStop = true;
            this.rdb_Saude.Text = "Saúde";
            this.rdb_Saude.UseVisualStyleBackColor = true;
            // 
            // rdb_Enge
            // 
            this.rdb_Enge.AutoSize = true;
            this.rdb_Enge.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Enge.Location = new System.Drawing.Point(18, 324);
            this.rdb_Enge.Name = "rdb_Enge";
            this.rdb_Enge.Size = new System.Drawing.Size(109, 27);
            this.rdb_Enge.TabIndex = 25;
            this.rdb_Enge.TabStop = true;
            this.rdb_Enge.Text = "Engenharia";
            this.rdb_Enge.UseVisualStyleBackColor = true;
            // 
            // rdb_Comp
            // 
            this.rdb_Comp.AutoSize = true;
            this.rdb_Comp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Comp.Location = new System.Drawing.Point(20, 291);
            this.rdb_Comp.Name = "rdb_Comp";
            this.rdb_Comp.Size = new System.Drawing.Size(117, 27);
            this.rdb_Comp.TabIndex = 24;
            this.rdb_Comp.TabStop = true;
            this.rdb_Comp.Text = "Computação";
            this.rdb_Comp.UseVisualStyleBackColor = true;
            // 
            // rdb_Adm
            // 
            this.rdb_Adm.AutoSize = true;
            this.rdb_Adm.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Adm.Location = new System.Drawing.Point(18, 258);
            this.rdb_Adm.Name = "rdb_Adm";
            this.rdb_Adm.Size = new System.Drawing.Size(126, 27);
            this.rdb_Adm.TabIndex = 23;
            this.rdb_Adm.TabStop = true;
            this.rdb_Adm.Text = "Administração";
            this.rdb_Adm.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Escolaridade:";
            // 
            // cbx_Escolaridade
            // 
            this.cbx_Escolaridade.FormattingEnabled = true;
            this.cbx_Escolaridade.Items.AddRange(new object[] {
            "Médio",
            "Técnico ",
            "Superior"});
            this.cbx_Escolaridade.Location = new System.Drawing.Point(20, 638);
            this.cbx_Escolaridade.Name = "cbx_Escolaridade";
            this.cbx_Escolaridade.Size = new System.Drawing.Size(134, 21);
            this.cbx_Escolaridade.TabIndex = 21;
            // 
            // ckb_Versp
            // 
            this.ckb_Versp.AutoSize = true;
            this.ckb_Versp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Versp.Location = new System.Drawing.Point(20, 468);
            this.ckb_Versp.Name = "ckb_Versp";
            this.ckb_Versp.Size = new System.Drawing.Size(126, 26);
            this.ckb_Versp.TabIndex = 20;
            this.ckb_Versp.Text = "Verspertino";
            this.ckb_Versp.UseVisualStyleBackColor = true;
            // 
            // ckb_Noturno
            // 
            this.ckb_Noturno.AutoSize = true;
            this.ckb_Noturno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Noturno.Location = new System.Drawing.Point(20, 498);
            this.ckb_Noturno.Name = "ckb_Noturno";
            this.ckb_Noturno.Size = new System.Drawing.Size(95, 26);
            this.ckb_Noturno.TabIndex = 19;
            this.ckb_Noturno.Text = "Noturno";
            this.ckb_Noturno.UseVisualStyleBackColor = true;
            // 
            // ckb_Mat
            // 
            this.ckb_Mat.AutoSize = true;
            this.ckb_Mat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Mat.Location = new System.Drawing.Point(20, 438);
            this.ckb_Mat.Name = "ckb_Mat";
            this.ckb_Mat.Size = new System.Drawing.Size(99, 26);
            this.ckb_Mat.TabIndex = 17;
            this.ckb_Mat.Text = "Matutino";
            this.ckb_Mat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Disponibilidade para estágio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Área de atuação:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Calcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(172, 150);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 33);
            this.btn_Calcular.TabIndex = 10;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_idade
            // 
            this.txt_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idade.Location = new System.Drawing.Point(90, 152);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(76, 29);
            this.txt_idade.TabIndex = 9;
            this.txt_idade.TextChanged += new System.EventHandler(this.txt_idade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "idade:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Mes
            // 
            this.txt_Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mes.Location = new System.Drawing.Point(289, 94);
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Size = new System.Drawing.Size(61, 29);
            this.txt_Mes.TabIndex = 7;
            // 
            // txt_Ano
            // 
            this.txt_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ano.Location = new System.Drawing.Point(356, 94);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.Size = new System.Drawing.Size(61, 29);
            this.txt_Ano.TabIndex = 6;
            // 
            // txt_Dia
            // 
            this.txt_Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dia.Location = new System.Drawing.Point(222, 94);
            this.txt_Dia.Name = "txt_Dia";
            this.txt_Dia.Size = new System.Drawing.Size(61, 29);
            this.txt_Dia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(94, 33);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(337, 29);
            this.txt_Nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CANDIDATO DE ESTÁGIO";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Limpar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(474, 777);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(100, 33);
            this.btn_Limpar.TabIndex = 23;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Enviar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Location = new System.Drawing.Point(234, 777);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(100, 33);
            this.btn_Enviar.TabIndex = 24;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(804, 822);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cadastro estágio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Dia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Mes;
        private System.Windows.Forms.TextBox txt_Ano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.CheckBox ckb_Versp;
        private System.Windows.Forms.CheckBox ckb_Noturno;
        private System.Windows.Forms.CheckBox ckb_Mat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Escolaridade;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.RadioButton rdb_Saude;
        private System.Windows.Forms.RadioButton rdb_Enge;
        private System.Windows.Forms.RadioButton rdb_Comp;
        private System.Windows.Forms.RadioButton rdb_Adm;
    }
}

