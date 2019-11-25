using FrontSystemWine.Data;
using FrontSystemWine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.Services
{
    public class UsuarioNotaVinhoService
    {
        private readonly ApplicationDbContext _db;

        public UsuarioNotaVinhoService(ApplicationDbContext db)
        {
            _db = db;
        }

        public UsuarioNotaVinho GetUsuarioNotaVinho(string userId, int vinhoId)
        {
            return _db.UsuarioNotaVinhos.Where
                (
                    x => x.IdUsuario == userId
                    && x.IdVinho == vinhoId
                ).FirstOrDefault();
        }

        public bool AtualizarVoto(UsuarioNotaVinho nota)
        {
            if (nota.Id == 0)
            {
                _db.UsuarioNotaVinhos.Add(nota);
            }
            else
            {
                _db.UsuarioNotaVinhos.Update(nota);
            }

            _db.SaveChanges();

            return true;
        }
    }
}
