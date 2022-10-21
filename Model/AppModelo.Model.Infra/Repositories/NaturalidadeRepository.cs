using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {

        public bool Inserir(string descricao)
        {
            var sql = $"INSERT INTO naturalidade (descricao, ativo, datacriacao, dataalteracao) VALUES ('{descricao}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;

        }

        public bool Atualizar()
        {
            return false;
        }

        public bool Remover()
        {
            return false;
        }

        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {

            var sql = "SELECT id, descricao FROM naturalidade ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;



        }

        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }

    }
}
