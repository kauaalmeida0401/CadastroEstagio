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

namespace ATIVIDADE__ESTAGIO
{
    public partial class Form1 : Form
    {    
        private Candidato candidato;
        public Form1()
        {
            InitializeComponent();

            cbx_Escolaridade.DropDownStyle = ComboBoxStyle.DropDownList;  
        }
        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Dia.Text = "";
            txt_Mes.Text = "";
            txt_Ano.Text = "";
            txt_idade.Text = "";

            rdb_Adm.Checked = false;
            rdb_Comp.Checked = false;
            rdb_Enge.Checked = false;
            rdb_Saude.Checked = false;

            ckb_Mat.Checked = false;
            ckb_Versp.Checked = false;
            ckb_Noturno.Checked = false;
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_Nome.Text))
            {
                MessageBox.Show(
                    "Informe o nome do candidato. ", 
                    "Atenção", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                txt_Nome.Focus();
                return false;
            }
            if  (!rdb_Adm.Checked && !rdb_Comp.Checked && !rdb_Enge.Checked && !rdb_Saude.Checked)
            {
                MessageBox.Show(
                    "Informe pelo menos um campo", "Atenção", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return false;
            } 
            if (!ckb_Mat.Checked &&  !ckb_Versp.Checked && !ckb_Noturno.Checked)
            {
                MessageBox.Show("Informe pelo menos um turno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbx_Escolaridade.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a escolaridade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            try
            {
                int dia = int.Parse(txt_Dia.Text);
                int mes = int.Parse(txt_Mes.Text);
                int ano = int.Parse(txt_Ano.Text);
                DateTime data = new DateTime(ano, mes, dia);
            }
            catch
            {
                MessageBox.Show("Informe uma data de nascimento correta.");
                return false;
            }
            return true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int anoNascimento = int.Parse(txt_Ano.Text);

            int idade = 2026 - anoNascimento;

            txt_idade.Text = Convert.ToString(idade);
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }
            try
            {
                Candidato candidato = new Candidato();
                candidato.Nome = txt_Nome.Text.Trim();
                candidato.Dia = Convert.ToInt32(txt_Dia.Text);
                candidato.Mes = Convert.ToInt32(txt_Mes.Text);
                candidato.Ano = Convert.ToInt32(txt_Ano.Text);

                if (rdb_Adm.Checked ==  true)
                {
                    candidato.AreaDeAtuacao = "Administração";
                }
                if (rdb_Comp.Checked == true)
                {
                    candidato.AreaDeAtuacao = "Computação";
                }
                if (rdb_Enge.Checked == true)
                {
                    candidato.AreaDeAtuacao = "Engenharia";
                }
                if (rdb_Saude.Checked == true)
                {
                    candidato.AreaDeAtuacao = "Saúde";
                }

                candidato.Matutino = ckb_Mat.Checked;
                candidato.Vespertino = ckb_Versp.Checked;
                candidato.Noturno = ckb_Noturno.Checked;

                candidato.Escolaridade = cbx_Escolaridade.Text;
                CandidatoDAO dao = new CandidatoDAO();
                int idGerado = dao.Inserir(candidato);

                MessageBox.Show($"Candidato cadastrado com sucesso! Código: {idGerado} ");
                LimparCampos();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não foi possivel cadastrar no banco de dados!!" +  ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}. ERROR: {MessageBoxButtons.OK} {MessageBoxIcon.Information}");
                LimparCampos();
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
