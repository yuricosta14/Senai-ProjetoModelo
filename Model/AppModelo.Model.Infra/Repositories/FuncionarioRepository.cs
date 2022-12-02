using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{   
    /// <summary>
    /// Responsavel pela relação entre o programa e o banco de dados
    /// </summary>
    public class FuncionarioRepository
    {
        /// <summary>
        /// Responsavel por inserir um funcionario no banco de dados
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="cpf"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="telefoneContato"></param>
        /// <param name="cep"></param>
        /// <param name="logradouro"></param>
        /// <param name="numero"></param>
        /// <param name="complemento"></param>
        /// <param name="bairro"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
        /// <param name="idNacionalidade"></param>
        /// <param name="idNaturalidade"></param>
        /// <returns>Retorna o pedido de inserir um funcionario novo no banco de dados atraves dos parametros</returns>
            public bool Inserir(string nome, DateTime dataNascimento, bool sexo,
            string cpf, string email, string telefone, string telefoneContato, string cep,
            string logradouro, int numero, string complemento, string bairro, string municipio, string uf,
            int idNacionalidade, int idNaturalidade)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionarios (nome, data_nascimento, sexo, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, id_nacionalidade, id_naturalidade) VALUES ('{nome}', '{dataNascimento}', {sexo}, '{email}', '{telefone}', '{telefoneContato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {idNacionalidade}, {idNaturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
            }

        /// <summary>
        /// Responsavel por obter todos os funcionarios cadastrados no banco de dados
        /// </summary>
        /// <returns>Retorna o pedido de obter todos os funcionarios</returns>
        public IEnumerable<FuncionarioEntity> ObterTodos()
        {
            var sql = " SELECT * FROM funcionarios ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }
        
        /// <summary>
        /// Responsavel por remover um funcionario do banco de dados atraves do nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Retorna o pedido de remover funcionario atraves do nome</returns>
        public bool Remover(string nome)
        {
            var sql = $"DELETE FROM funcionarios WHERE nome = ('{nome}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

    }
}   
