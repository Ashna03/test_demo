using Family_BAL.Service;
using Family_DAL.Interface;
using Family_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonDetailsController : ControllerBase
    {
        private readonly PersonService _personservice;
        private readonly IRepository<Person> _personrepo;         //personservice is dependent on Irepository
        public PersonDetailsController(PersonService personservice, IRepository<Person> personrepo)
        {
            _personservice = personservice;
            _personrepo = personrepo;

        }

        [HttpGet("/getperson")]
        public Object GetPersonById(int id)           //we will return json object
        {
            var result = _personservice.GetPersonById(id);
            var jsonResult = JsonConvert.SerializeObject(result);
            return jsonResult;
        }

        [HttpGet("/getall")]
        public Object GetAllPeople()
        {
            var result = _personservice.GetAllPeople();
            var jsonResult = JsonConvert.SerializeObject(result);
            return jsonResult;

        }

        [HttpPost("/addperson")]
        public async Task<Person> AddPerson([FromBody] Person addperson)
        {
            
               var addedperson = await _personservice.AddNewPerson(addperson);           //await since we r using task with async
               return addedperson;
           
        }

        [HttpDelete("/deleteperson")]
        public bool DeletePerson(Person delperson)
        {
            try
            {
                _personservice.RemovePerson(delperson);
                return true;

            }
            catch 
            {

                return false;
            }
        
        }

        [HttpPut("/updateperson")]
        public bool UpdatePerson(Person updateperson)
        {
            try
            {
                _personservice.GetPersonUpdate(updateperson);
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
