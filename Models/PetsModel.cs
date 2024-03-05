using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // ADICIONADO AGORA
using System.Linq;
using System.Threading.Tasks;

namespace PegasusPetshop.Models
{
    public class PetsModel
    {
        [Key] //key = anotação / annotation
        public int id { get; set; }

        public int idDono { get; set; }
    
        public String Nome { get; set; }
        
        public String TipoPet { get; set; }

        public String Plano { get; set; }
    }    
}