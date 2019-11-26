using FrontSystemWine.Data;
using FrontSystemWine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FrontSystemWine.Services
{
    public class VinhoService
    {
        private readonly ApplicationDbContext _db;

        public VinhoService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Vinho> GetVinhos()
        {
            return _db.Vinhos
                .Include(v => v.TipoUva)
                .Include(v => v.TipoVinho)
                //.Include(v => v.Regiao)
                .ToList();
        }

        public List<TipoUva> GetTiposUva()
        {
            return _db.TiposUva.ToList();
        }

        public List<TipoVinho> GetTiposVinho()
        {
            return _db.TiposVinho.ToList();
        }

        public bool CriarVinho(Vinho vinho)
        {
            vinho.IdRegiao = 1;
            _db.Vinhos.Add(vinho);
            _db.SaveChanges();
            return true;
        }

        public bool AtualizarVinho(Vinho vinho)
        {
            var dbVinho = _db.Vinhos.FirstOrDefault(v => v.Id == vinho.Id);
            if (dbVinho != null)
            {
                if (vinho.Imagem == null)
                {
                    vinho.Imagem = dbVinho.Imagem;
                }
                _db.Vinhos.Update(vinho);
                _db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool DeletarVinho(Vinho vinho)
        {
            var dbVinho = _db.Vinhos.FirstOrDefault(v => v.Id == vinho.Id);
            if (dbVinho != null)
            {
                _db.Vinhos.Remove(dbVinho);
                _db.SaveChanges();
                return true;
            }

                return false;
        }
    }
}
