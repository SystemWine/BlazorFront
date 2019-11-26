using System;
using System.Collections.Generic;
using System.Text;
using FrontSystemWine.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FrontSystemWine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<TipoUva> TiposUva { get; set; }
        public DbSet<TipoVinho> TiposVinho { get; set; }
        public DbSet<UsuarioPreferencia> UsuarioPreferencias { get; set; }
        public DbSet<UsuarioNotaVinho> UsuarioNotaVinhos { get; set; }
        public DbSet<Vinho> Vinhos { get; set; }
    }
}
