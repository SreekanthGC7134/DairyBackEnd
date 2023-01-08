using DairyBackEnd.Data;
using DairyBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DairyBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        public DataContextClass dataContextClass { get; set; }
        public RegistrationController(DataContextClass registrationcontext)
        {
            this.dataContextClass = registrationcontext;
        }
        [HttpPost("Registration")]
        public async Task<ActionResult> reg(Registration re)
        {
            dataContextClass.tblregistration.Add(re);
            await dataContextClass.SaveChangesAsync();
            return Ok(re);
        }

        [HttpPost("login")]

        public IActionResult Login(Registration us)
        {
            var userAvailable = dataContextClass.tblregistration.Where(u => u.email == us.email && u.password == us.password).FirstOrDefault();
            if (userAvailable != null)
            {
                return Ok(userAvailable);
            }
            return Ok("Failed");

        }
    }
}
