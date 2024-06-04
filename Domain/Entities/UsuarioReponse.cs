using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsuarioReponse
    {
        //atributos
       
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int? FkRol { get; set; }
       
    }
}
