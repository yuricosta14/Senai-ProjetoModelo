using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class UsuarioRepository
    {
        /// <summary>
        /// Responsavel pela verificação se o usuario esta cadastrado no banco de dados
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns>Retorna o pedido de conectar o usuario pelo email e senha</returns>
        public UsuarioEntity Obter(string usuario, string senha)
        {
            var sql = $"SELECT email, senha FROM usuarios " +
                $"WHERE email = '{usuario}' AND senha = '{senha}';";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);


            return resultado;

        }

        /// <summary>
        /// Responsavel por verificar se o email do usuario esta cadastrado no banco de dados
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Retorna o pedido de obter o usuario pelo email</returns>
        public UsuarioEntity ObterPorEmail(string email)
        {
            var sql = $"SELECT email, nome FROM usuarios WHERE email = '{email}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;

        }

        /// <summary>
        /// Responsavel por atualizar a senha do usuario no banco de dados através do email cadastrado.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="novaSenha"></param>
        /// <returns>Retorna o pedido de atualizar a senha do usuário pelo email</returns>
        public bool AtualizarSenha(string email, string novaSenha)
{
            var sql = $"UPDATE usuarios " +
                      $"SET senha = '{novaSenha}' " +
                      $"WHERE email = '{email}'; ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
