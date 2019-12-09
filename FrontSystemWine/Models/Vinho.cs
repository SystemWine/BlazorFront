using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.Models
{
    public class Vinho
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int IdRegiao { get; set; }
        
        [ForeignKey("IdRegiao")]
        public virtual Regiao Regiao{ get; set; }

        public int IdTipoUva { get; set; }

        [ForeignKey("IdTipoUva")]
        public virtual TipoUva TipoUva { get; set; }

        public double Valor { get; set; }
        public int Ano { get; set; }
        
        public int IdTipoVinho { get; set; }
        
        [ForeignKey("IdTipoVinho")]
        public virtual TipoVinho TipoVinho { get; set; }

        public int IdArmonizacao { get; set; }

        [ForeignKey("IdArmonizacao")]
        public virtual Armonizacao Armonizacao { get; set; }

        public byte[] Imagem { get; set; }
    }
}
