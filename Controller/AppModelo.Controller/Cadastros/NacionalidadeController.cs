using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        /// <summary>
        /// Responsavel por cadastrar nova nacionalidade no banco de dados
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de cadastro de nova nacionalidade</returns>
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }

        /// <summary>
        /// Responsavel por obter todas as nacionalidades cadastradas no banco de dados
        /// </summary>
        /// <returns>Retorna o pedido de obter todas nacionalidades cadastradas no banco de dados</returns>
        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }

        /// <summary>
        /// Responsavel por excluir uma nacionalidade cadastrada no banco de dados atraves da descrição
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de excluir uma nacionalidade cadastrada no banco de dados atraves da descrição</returns>
        public bool Deletar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta;
        }

        /// <summary>
        /// Responsavel por atualizar as nacionalidades cadastradas no banco de dados atraves do id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>Retorna o pedido de atualizar as nacionalidade cadastradas no banco de dados atraves do id  </returns>
        public bool Atualizarr(int id, string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizarr(id, descricao);
            return resposta;
        }
    }
}
