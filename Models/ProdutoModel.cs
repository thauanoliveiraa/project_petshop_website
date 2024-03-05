using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // ADICIONADO AGORA
using System.Linq;
using System.Threading.Tasks;

namespace PegasusPetshop.Models
{
    public class ProdutoModel
    {
        [Key] //key = anotação / annotation
        public int CodigoDeBarra { get; set; }
    
        public String CNPJ { get; set; }

        public String Nome { get; set; }
        
        public String ClasseDoProduto { get; set; }

        public String Valor { get; set; }

        public String DataDeValidade { get; set; }

        public int QuantidadeEmEstoque { get; set; }
    }    
}