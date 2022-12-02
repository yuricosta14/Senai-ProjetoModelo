using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        /// <summary>
        /// Responsavel por validar e cadastrar uma nova naturalidade no banco de dados
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Retorna o pedido de validação e cadastra uma nova naturalidade no banco de dados</returns>
        public bool Cadastrar(string descricao, bool status)
        {
            var repositorio = new NaturalidadeRepository();

            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if (naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, status);
            return resposta;
        }

        /// <summary>
        /// Responsavel por obter todas naturalidades cadastradas no banco de dados
        /// </summary>
        /// <returns>Retorna o pedido de obter todas as naturalidades cadastradas no banco de dados</returns>
        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }

        /// <summary>
        /// Responsavel por excluir uma naturalidade cadastrada no banco de dados
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de excluir uma naturalidade cadastrada no banco de dados</returns>
        public bool Deletar(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta;
        }

        /// <summary>
        /// Responsavel por atualizar as naturalidades cadastradas no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de atualizar as naturalidades cadastradas no banco de dados</returns>
        public bool Atualizarr(int id, string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizarr(id, descricao);
            return resposta;
        }
    }
}
   

    

