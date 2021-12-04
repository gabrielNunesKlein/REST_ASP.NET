using _001_REST_API.NET_Criando_Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_REST_API.NET_Criando_Projeto.Business
{
    public interface IBookBusiness
    {
        List<Book> FidAll();

        Book FindById(long id);

        Book Create(Book book);

        Book Update(Book book);

        void Delete(long id);
    }
}
