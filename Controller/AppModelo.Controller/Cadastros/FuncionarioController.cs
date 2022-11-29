using System;
using System.Data.SqlClient;
using System.Data;
using AppModelo.Model.Infra.Repositories;
using AppModelo.Model.Domain.Entities;
using System.Collections.Generic;
using AppModelo.Model.Infra.Databases;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
            public bool Cadastrar(string nome, DateTime dataNascimento, bool sexo,
            string cpf, string email, string telefone, string telefoneContato, string cep,
            string logradouro, int numero, string complemento, string bairro, string municipio, string uf,
            int idNacionalidade, int idNaturalidade)
            {
                var repositorio = new FuncionarioRepository();
                var resposta = repositorio.Inserir(nome, dataNascimento, sexo, cpf, email, telefone,
                telefoneContato, cep, logradouro, numero, complemento, bairro, municipio,
                uf, idNacionalidade, idNaturalidade);

            return resposta;


            }

        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (List<FuncionarioEntity>)resposta;
        }

        public bool Deletar(string descricao)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta;
        }

    }


}

