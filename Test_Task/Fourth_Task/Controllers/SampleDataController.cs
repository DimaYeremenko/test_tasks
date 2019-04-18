using AutoMapper;
using Fourth_Task.Models;
using Fourth_Task.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Fourth_Task.Services.Models;

namespace Fourth_Task.Controllers
{
    [Route("api/test")]
    public class SampleDataController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserService _service;

        public SampleDataController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            var users = _service.GetAll();
            return _mapper.Map<IEnumerable<UserViewModel>>(users);
        }

        [HttpGet("{name}")]
        public IEnumerable<UserViewModel> Get(string name)
        {
            var users = _service.GetByName(name);
            return users != null ? _mapper.Map<IEnumerable<UserViewModel>>(users) : new List<UserViewModel>();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                _service.Update(id, _mapper.Map<User>(user));
            }

            return BadRequest(ModelState);
        } 
    }
}
