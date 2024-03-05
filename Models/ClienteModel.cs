using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // ADICIONADO AGORA
using System.Linq;
using System.Threading.Tasks;

namespace PegasusPetshop.Models
{
    public class ClienteModel
    {
        [Key] //key = anotação / annotation
        public int id { get; set; }
    
        public String CPF { get; set; }

        public String Nome { get; set; }
        
        public String Genero { get; set; }

        public int QuantidadePets { get; set; }

        public int Contato { get; set; }

        public String Email { get; set; }

        public String Endereco { get; set; }
    }    
}