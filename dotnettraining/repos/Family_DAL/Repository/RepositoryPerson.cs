using Family_DAL.Interface;
using Family_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family_DAL.Data;

namespace Family_DAL.Repository
{
    public class RepositoryPerson : IRepository<Person>
    {
        private FamilyDBContext _dbContext;
        public RepositoryPerson(FamilyDBContext dbcontextobj)     //contructor
        {
            _dbContext = dbcontextobj;
        }
        public async Task<Person> Add(Person obj)                //Task is an async method
        {
            var returnedobj = await _dbContext.Persons.AddAsync(obj);           //Addsync will convert it to task, every async method should have await
            _dbContext.SaveChanges();              //to save to db
            return returnedobj.Entity;             //from stored obj returnedobj, just returning entity

        }

        public IEnumerable<Person> DisplayAll()        //IEnumerable used so we can use LINQ statements
        {
            try
            {
                return _dbContext.Persons.Where(x => x.IsDeleted == false).ToList();
            }
            catch
            {
                throw;
            }
        }

        public Person DisplayByID(int id)
        {
            try
            {
                return _dbContext.Persons.Where(x => x.PersonID.Equals(id)).FirstOrDefault();    //FirstOrDefault used since we just hv to return 1 record,returns first record that has come from list of records
            }
            catch 
            {
                throw;
            }
            
        }

        public void Remove(Person obj)
        {
            //_dbContext.Remove(_dbContext.Persons.Where(x => x.PersonID.Equals(id)).FirstOrDefault()); //1st method       //if we pass int id as parameter instead of object , do this method
            //Person removeobj = _dbContext.Persons.Where(x => x.PersonID.Equals(id)).FirstOrDefault();  //2nd method     
            //_dbContext.Persons.Remove(removeobj);
            _dbContext.Persons.Remove(obj);
            _dbContext.SaveChanges();                   //necessary for both methods
        }

        public void Update(Person obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
        }
    }
}
