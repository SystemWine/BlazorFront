using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.Models
{
    public class UsuarioNotaVinho
    {
        public int Id { get; set; }

        public string IdUsuario { get; set; }

        public int IdVinho { get; set; }

        public double Nota { get; set; }
    }
}
