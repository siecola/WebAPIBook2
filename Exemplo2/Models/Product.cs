using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exemplo2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string nome { get; set; }

        public string descricao { get; set; }

        [Required]
        public string codigo { get; set; }

        public decimal preco { get; set; }
    }
}