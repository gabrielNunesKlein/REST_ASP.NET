using _001_REST_API.NET_Criando_Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _001_REST_API.NET_Criando_Projeto.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MokingPerson(i);
                persons.Add(person);
            }
            return persons;

        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Gabriel",
                LastName = "Klein",
                Address = "Rua A",
                Gender = "Mile"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MokingPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "firstName" + i,
                LastName = "lastName" + i,
                Address = "Rua" + i,
                Gender = "Mile"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
