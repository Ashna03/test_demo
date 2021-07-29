using Family_DAL.Interface;
using Family_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_BAL.Service
{
    public class PersonService
    {
        private readonly IRepository<Person> _person;
        public PersonService(IRepository<Person> person)
        {
            _person = person;
        }
        public Person GetPersonById(int id)
        {
            return _person.DisplayByID(id);
            
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _person.DisplayAll();
        }

        public void GetPersonUpdate(Person updatedobj)
        {
            _person.Update(updatedobj);
        }

        public void RemovePerson(Person persontoremove)
        {
            _person.Remove(persontoremove);
        }

        public Task<Person> AddNewPerson(Person newobj)
        {
            return _person.Add(newobj);
        }
    }
}
