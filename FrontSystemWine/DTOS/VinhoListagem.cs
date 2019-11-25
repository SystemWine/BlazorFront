using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.DTOS
{
    public class VinhoListagem
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string TipoUva { get; set; }

        public double Valor { get; set; }
    }
}
