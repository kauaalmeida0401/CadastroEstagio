using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace ATIVIDADE__ESTAGIO
{
    internal class CandidatoDAO
    {
        public  int Inserir(Candidato candidato)
        {
            const string msql = "INSERT INTO candidato (Nome, data_nascimento, area_atuacao, Matutino, Vespertino, Noturno, Escolaridade) " +
                "VALUES (@Nome, @data_nascimento, @area_atuacao, @Matutino, @Vespertino, @Noturno, @Escolaridade)";

            var conexao = Conexao.ObterConexao();
            var comando = new MySqlCommand(msql, conexao);

            comando.Parameters.AddWithValue("@Nome", candidato.Nome);
            comando.Parameters.AddWithValue("@data_nascimento", new DateTime(candidato.Ano, candidato.Mes, candidato.Dia));
            comando.Parameters.AddWithValue("@area_atuacao", candidato.AreaDeAtuacao);
            comando.Parameters.AddWithValue("@Matutino", candidato.Matutino ? 1: 0);
            comando.Parameters.AddWithValue("@Vespertino", candidato.Vespertino ? 1 : 0);
            comando.Parameters.AddWithValue("@Noturno", candidato.Noturno ? 1 : 0);
            comando.Parameters.AddWithValue("@Escolaridade", candidato.Escolaridade);
            int linhas = comando.ExecuteNonQuery();
           
            //conexao.Open();
            
            if (linhas == 0)
            {
                throw new Exception("Nenhum registro no banco de dados");
            }
            return Convert.ToInt32(comando.LastInsertedId);
        }
    }
}
