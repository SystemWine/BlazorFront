using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.Models
{
    public class Regiao
    {
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        public int IdPais { get; set; }

        [ForeignKey("IdPais")]
        public virtual Pais Pais{ get; set; }

    }
}
