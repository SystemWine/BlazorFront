using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.Models
{
    public class UsuarioPreferencia
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        public int IdTipoUva { get; set; }
        public int IdTipoVinho { get; set; }
        public bool MostrarBoasVindas { get; set; }
    }
}
