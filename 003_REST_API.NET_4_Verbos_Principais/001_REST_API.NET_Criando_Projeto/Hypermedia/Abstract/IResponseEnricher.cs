using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace _001_REST_API.NET_Criando_Projeto.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
