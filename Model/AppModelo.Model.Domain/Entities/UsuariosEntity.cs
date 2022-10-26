using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Entities
{
    internal class UsuariosEntity
    {
        public int Id{ get; set; }
        public string Nome { get; set; }    
        public string Eail { get; set; }
        public string Snha { get; set; }
        public DateTime UtimoLogin { get; set; }



    }
}
