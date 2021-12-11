using _001_REST_API.NET_Criando_Projeto.Data.VO;
using _001_REST_API.NET_Criando_Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_REST_API.NET_Criando_Projeto.Business
{
    public interface IBookBusiness
    {
        List<BookVO> FidAll();

        BookVO FindById(long id);

        BookVO Create(BookVO book);

        BookVO Update(BookVO book);

        void Delete(long id);
    }
}
