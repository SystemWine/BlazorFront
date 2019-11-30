using FrontSystemWine.DTOS;
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

        public RetornoAPIRecomendacao ProcessarTestes()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            var serializer = new DataContractJsonSerializer(typeof(RetornoAPIRecomendacao));

            var streamReturned = client.GetStreamAsync("http://localhost:5000/wine").Result;

            RetornoAPIRecomendacao retorno = serializer.ReadObject(streamReturned) as RetornoAPIRecomendacao;

            return retorno;
        }

    }
}
