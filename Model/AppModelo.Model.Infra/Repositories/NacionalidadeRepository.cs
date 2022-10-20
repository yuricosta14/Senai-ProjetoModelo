using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {
        //CRUD - create - read - uptade - delete
        //     insert    select   uptade  delete

        public bool Inserir(string descricao) 
        {
            var sql = $"INSERT INTO nacionalidades (descricao) VALUES ('{descricao}')";
            
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

        public IEnumerable<NacionalidadeEntity> ObterTodos() 
        {
            
            var sql  = "SELECT id, descricao FROM nacionalidades ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            
            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;

            

        }

        public NacionalidadeEntity ObterPorId() 
        {
            return new NacionalidadeEntity();
        }

    }
}
