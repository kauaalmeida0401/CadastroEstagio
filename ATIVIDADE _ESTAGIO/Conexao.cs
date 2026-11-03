using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ATIVIDADE__ESTAGIO
{
    internal class Conexao
    {
            private const string StringConexao =
            "Server=localhost;Port=3307;Database=db_estagio;" +
            "Uid=root;Pwd=;";
            /// <summary>Cria e já ABRE uma nova conexão.
            /// Quem chama deve descartá-la com using.</summary>
            public static MySqlConnection ObterConexao()
            {
                var conexao = new MySqlConnection(StringConexao);
                conexao.Open();
                return conexao;
            }
        public static bool TestarConexao(out string mensagem)
        {
            try
            {
                var conexao = ObterConexao();
                mensagem = $"Conectado! MySQL {conexao.ServerVersion}";
                return true;
            }
            catch (MySqlException ex)
            {
                // ex.Number identifica o tipo de falha
                mensagem = $"Falha {ex.Number}: {ex.Message}";
                return false;
            }
        }


    }
}
