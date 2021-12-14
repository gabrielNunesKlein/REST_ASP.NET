using System.Collections.Generic;

namespace _001_REST_API.NET_Criando_Projeto.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
