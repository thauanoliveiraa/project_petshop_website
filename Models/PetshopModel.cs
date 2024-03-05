using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // ADICIONADO AGORA
using System.Linq;
using System.Threading.Tasks;

namespace PegasusPetshop.Models
{
    public class PetshopModel
    {
        // model do funcionario
        [Key] //key = anotação / annotation
        public int Id { get; set; }
    
        public String Nome { get; set; }

        public String Genero { get; set; }
        
        public String Cargo { get; set; }

        public String Salario { get; set; }

        public String Contato { get; set; }

        public String Email { get; set; }

        public String Endereco { get; set; }        

    }
}