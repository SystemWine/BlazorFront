using FrontSystemWine.Data;
using FrontSystemWine.DTOS;
using FrontSystemWine.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace FrontSystemWine.Services
{
    public class APIRecomendacaoService
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly ApplicationDbContext _db;

        public APIRecomendacaoService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<RetornoAPIRecomendacao> ObterVinhosRecomendadosPorUsuario(string idUsuario)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            var serializer = new DataContractJsonSerializer(typeof(List<RetornoAPIRecomendacao>));

            var streamReturned = client.GetStreamAsync($"http://localhost:5000/recomendacoes?id_usuario={idUsuario}").Result;

            var retorno = serializer.ReadObject(streamReturned) as List<RetornoAPIRecomendacao>;

            return retorno;
        }

        public Vinho GetInstanciaVinho(int idVinho)
        {
            return _db.Vinhos.Where(x => x.Id == idVinho)
                .Include(v => v.TipoUva)
                .Include(v => v.TipoVinho)
                .Include(v => v.Regiao)
                .FirstOrDefault();
        }

    }
}
