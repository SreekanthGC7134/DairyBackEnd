using DairyBackEnd.Data;
using Microsoft.AspNetCore.Http;
using DairyBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DairyBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DairyEntryController : ControllerBase
    {
        public DataContextClass dataContextClass { get; set; }

        public DairyEntryController(DataContextClass dairycontext)
        {
            this.dataContextClass = dairycontext;
        }
        [HttpPost("DairyEntry")]
        
            public async Task<ActionResult> DairyEntry(DairyEntry da)
        {
            dataContextClass.tbldairyentry.Add(da);
            await dataContextClass.SaveChangesAsync();
            return Ok(da);
        }

        [HttpPost("ViewDairy")]

       public async Task<List<DairyEntry>> ViewDairy()
        {
            return dataContextClass.tbldairyentry.ToList();
        }
    }
}
