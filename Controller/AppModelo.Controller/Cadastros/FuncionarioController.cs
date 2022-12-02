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
        /// <summary>
        /// Responsavel por cadastrar as informações dos funcionarios no banco de dados
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
        /// <returns>Retorna o pedido de cadastrar as informações dos funcionarios</returns>
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
        
        /// <summary>
        /// Responsavel por obter todos os funcionarios cadastrados no banco de dados
        /// </summary>
        /// <returns>Retorna o pedido de mostrar todos os funcionarios cadastrados no banco de dados</returns>
        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (List<FuncionarioEntity>)resposta;
        }

        /// <summary>
        /// Responsavel por excluir funcionario cadastrado no banco de dados pela descrição
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de excluir funcionario pela deescrição</returns>
        public bool Deletar(string descricao)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta;
        }

    }


}

