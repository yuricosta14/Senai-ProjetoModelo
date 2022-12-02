using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Entities
{
    /// <summary>
    /// Responsavel por retornar um valor e atribuir um novo valor nas propriedades
    /// </summary>
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime UltimoLogin { get; set; }
    }
}
