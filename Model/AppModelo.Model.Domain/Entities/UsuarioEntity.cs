using System;

namespace AppModelo.Model.Domain.Entities
{
    public class UsuarioEntity
    {
        public int Id{ get; set; }
        public string Nome { get; set; }    
        public string Eail { get; set; }
        public string Snha { get; set; }
        public DateTime UtimoLogin { get; set; }



    }
}
