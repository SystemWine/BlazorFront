using FrontSystemWine.Data;
using FrontSystemWine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.Services
{
    public class EditarPreferenciaService
    {
        private readonly ApplicationDbContext _db;

        public EditarPreferenciaService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<TipoVinho> GetTiposVinho()
        {
            return _db.TiposVinho.ToList();
        }

        public List<TipoUva> GetTiposUva()
        {
            return _db.TiposUva.ToList();
        }

        public UsuarioPreferencia GetRegistroPreferenciaUsuario(string userId)
        {
            return _db.UsuarioPreferencias.Where(x => x.IdUsuario == userId).FirstOrDefault();
        }

        public bool AtualizarPreferencias(UsuarioPreferencia preferencia)
        {
            if (preferencia.Id == 0)
            {
                _db.UsuarioPreferencias.Add(preferencia);
            }            
            else
            {
                _db.UsuarioPreferencias.Update(preferencia);
            }

            _db.SaveChanges();

            return true;
        }
    }
}
