using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {

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

        public IEnumerable<FuncionarioEntity> ObterTodos()
        {
            var sql = " SELECT * FROM funcionarios ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }

    }
}   
