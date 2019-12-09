using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.DTOS
{
    public class AtributosPesquisaVinho
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int IdTipoVinho { get; set; }

        public int IdTipoUva { get; set; }

        public int IdPais { get; set; }

        public int IdRegiao { get; set; }

        public int IdArmonizacao { get; set; }
    }
}
