using _001_REST_API.NET_Criando_Projeto.Hypermedia.Abstract;
using System.Collections.Generic;

namespace _001_REST_API.NET_Criando_Projeto.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
