using System;
using System.Data.SqlClient;
using System.Data;
using AppModelo.Model.Infra.Repositories;

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

       }


    }

