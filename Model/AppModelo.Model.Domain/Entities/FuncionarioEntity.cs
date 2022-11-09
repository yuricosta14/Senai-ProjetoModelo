﻿using System;

namespace AppModelo.Model.Domain.Entities
{
    public class FuncionarioEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNAscimento { get; set; }

        public bool Sexo { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string TelefoneContato { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public string Uf { get; set; }

        public int IdNacionalidade { get; set; }

        public int IdNaturalidade { get; set; }
    }
}
