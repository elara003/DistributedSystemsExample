using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Person.Repository.Contracts;
using Person.Model;
using Person.Model.Contracts;

namespace Person.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonRepository _personRepository;

        public PersonController(ILogger<PersonController> logger,
                                IPersonRepository personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        }

        [HttpGet]
        public IEnumerable<Person.Model.Person> Get()
        {
            return _personRepository.GetAll(x => true);
        }

        [HttpPost]
        public void Post(PersonDto personDto)
        {
            var person = new Person.Model.Person(new Name{ First = personDto.FirstName, Last = personDto.LastName });
            _personRepository.Insert(person);
        }

        public class PersonDto
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
    }
}
