﻿using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        public bool Cadastrar(string descricao, bool status)
        {
            var repositorio = new NaturalidadeRepository();

            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if (naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, status);
            return resposta;
        }

        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }

        public bool Deletar(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta;
        }

        public bool Atualizarr(int id, string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizarr(id, descricao);
            return resposta;
        }
    }
}
   

    

