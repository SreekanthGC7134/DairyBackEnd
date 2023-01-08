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
    public class ProfileController : ControllerBase
    {
        public DataContextClass dataContextClass { get; set; }

        public ProfileController(DataContextClass profilecontext)
        {
            this.dataContextClass = profilecontext;
        }
        [HttpPost("Profile")]
        public async Task<ActionResult> Insprofile(Profile pr)
        {
            dataContextClass.tblprofile.Add(pr);
            await dataContextClass.SaveChangesAsync();
            return Ok(pr);
        }

        [HttpGet("Viewprofile/{id}")]
        public IActionResult Viewprofile(int id)
        {
            return Ok(dataContextClass.tblprofile.Find(id));
        }
    }
}
