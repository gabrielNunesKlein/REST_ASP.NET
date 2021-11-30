using _001_REST_API.NET_Criando_Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_REST_API.NET_Criando_Projeto.Services.Implementation
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);
    }
}
