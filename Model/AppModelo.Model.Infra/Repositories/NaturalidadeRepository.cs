using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        /// <summary>
        /// Responsavel por inserir uma naturalidade no banco de dados atraves da descricao
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Retorna o pedido de cadastrar uma nacionalidade</returns>
        public bool Inserir(string descricao, bool status)
        {
            var agora = DateTime.Now.ToString("u");

            var sql = $"INSERT INTO naturalidade " +
                    $"(descricao, dataCriacao, dataAlteracao, ativo) " +
                    $"VALUES " +
                    $"('{descricao}','{agora}','{agora}', {status})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        /// <summary>
        /// Responsavel por atualuizar as naturalidades cadastradas no banco de dados atraves do id   
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de atualizar uma naturalidade pelo id</returns>
        public bool Atualizarr(int id, string descricao)
        {
            var sql = $"UPDATE naturalidade SET descricao = '{descricao}' WHERE id = {id}";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        /// <summary>
        /// Responsavel por remover uma naturalidade atraves da descricao
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de remover um naturalidade pela descricao</returns>
        public bool Remover(string descricao)
        {
            var sql = $"DELETE FROM naturalidade WHERE descricao = ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        /// <summary>
        /// Responsavel por obter todos as naturalidades cadastradas no banco de dados
        /// </summary>
        /// <returns>Retorna o pedido de obter todas a naturalidades cadastradas no banco de dados</returns>
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM naturalidade ORDER BY descricao DESC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = "SELECT id, descricao FROM naturalidade WHERE ativo = true";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        
        /// <summary>
        /// Obtêm a naturalidade pelo id
        /// </summary>
        /// <returns>Retorna o pedido de obter todas as naturalidades pelo id</returns>
        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }

        /// <summary>
        /// Obtêm  a naturalidade pela descricao
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de obter todas naturalidades pela descricao</returns>
        public NaturalidadeEntity ObterPorDescricao(string descricao)
        {
            var sql = $"SELECT id, descricao FROM naturalidade WHERE descricao = '{descricao}' ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);

            return resultado;
        }

        
    }
}
