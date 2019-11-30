using FrontSystemWine.Data;
using FrontSystemWine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FrontSystemWine.DTOS;

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
                .Include(v => v.Regiao)
                .ToList();
        }

        public List<Pais> GetPaises()
        {
            return _db.Paises.ToList();
        }

        public List<TipoUva> GetTiposUva()
        {
            return _db.TiposUva.ToList();
        }

        public List<TipoVinho> GetTiposVinho()
        {
            return _db.TiposVinho.ToList();
        }

        public List<Regiao> GetRegioes()
        {
            return _db.Regioes.ToList();
        }

        public bool CriarVinho(Vinho vinho)
        {
            _db.Vinhos.Add(vinho);
            _db.SaveChanges();
            return true;
        }

        public List<Vinho> GetVinhosComFiltro(AtributosPesquisaVinho filtros)
        {
            return _db.Vinhos
                .Where(x => x.IdTipoUva == filtros.IdTipoUva || filtros.IdTipoUva == 0)
                .Where(x => x.IdTipoVinho == filtros.IdTipoVinho || filtros.IdTipoVinho == 0)
                //.Where(x => x. == filtros.IdPais || filtros.IdPais == 0)
                .Where(x => x.IdRegiao == filtros.IdRegiao || filtros.IdRegiao == 0)
                .Where(x => x.Regiao.Pais.Id == filtros.IdPais || filtros.IdPais == 0)
                .ToList();
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
