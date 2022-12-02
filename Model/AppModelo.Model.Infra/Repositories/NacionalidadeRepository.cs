using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {   
        //CRUD - create - read   - update - delete
        //       insert - select - update - delete  

        /// <summary>
        /// Responsavel por inserir uma nacionalidade no banco de dados atraves da descricao
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de inserir uma nova nacionalidade no banco de dados atraves da descricao</returns>
        public bool Inserir(string descricao)
        {
            //string interpolation
            var sql = $"INSERT INTO nacionalidades (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        /// <summary>
        /// Responsavel por atualuizar as nacionalidades cadastradas no banco de dados atraves do id e da descricao
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de atualizar as nacionalidades no banco de dados atraves do id e da descricao</returns>
        public bool Atualizarr(int id , string descricao) 
        {
            var sql = $"UPDATE nacionalidades SET descricao = '{descricao}' WHERE id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        /// <summary>
        /// Responsavel por remover uma nacionalidade atraves da descricao
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de remover uma nacionalidade atraves da descricao</returns>
        public bool Remover(string descricao)
        {
            var sql = $"DELETE FROM nacionalidades WHERE descricao = ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

            /// <summary>
            /// Responsavel por obter todos as nacionalidades cadastradas no banco de dados
            /// </summary>
            /// <returns>Retorna o pedido de obter todas nacionalidades</returns>
            public IEnumerable<NacionalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM nacionalidades ORDER BY descricao DESC";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            
            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;
        }
       
        /// <summary>
        /// Responsavel por obter as nacionalidades atraves do id
        /// </summary>
        /// <returns>Retorna o pedido de obter todas nacionalidades atraves do id</returns>
        public NacionalidadeEntity ObterPorId() 
        {
            return new NacionalidadeEntity();
        }

    }
}
