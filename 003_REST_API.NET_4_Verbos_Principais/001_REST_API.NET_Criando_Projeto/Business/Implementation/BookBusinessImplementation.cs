using _001_REST_API.NET_Criando_Projeto.Models;
using _001_REST_API.NET_Criando_Projeto.Repository;
using _001_REST_API.NET_Criando_Projeto.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_REST_API.NET_Criando_Projeto.Business.Implementation
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Book> FidAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}
