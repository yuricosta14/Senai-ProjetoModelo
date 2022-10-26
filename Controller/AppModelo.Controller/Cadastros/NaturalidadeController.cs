using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        public bool Cadastrar(string descricao, bool status)
        {
            var repositorio = new NaturalidadeRepository();
           
            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if(naturalidade !=null) return false;

            var resposta = repositorio.Inserir(descricao, status);
            return resposta;
        }

        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }
    }
}