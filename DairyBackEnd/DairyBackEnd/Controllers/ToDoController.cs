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
    public class ToDoController : ControllerBase
    {
        public class TodoController : ControllerBase
        {
            public DataContextClass dataContextClass { get; set; }
            public TodoController(DataContextClass todocontext)
            {
                this.dataContextClass = todocontext;

            }
            [HttpPost("Inserttodo")]

            public async Task<ActionResult> DairyEntry(ToDo td)
            {
                dataContextClass.tbltodo.Add(td);
                await dataContextClass.SaveChangesAsync();
                return Ok(td);
            }
            //[HttpGet("viewdata")]
            //public async Task<List<Todo>> ViewData()
            //{
            //    return Diary.tblTodo.ToList();
            //}

            //[HttpPost("Delete")]
            //public IActionResult Delete(Todo cu)
            //{

            //    Diary.tblTodo.Remove(cu);
            //    Diary.SaveChanges();
            //    return Ok(cu);
            //}
            //[HttpGet("ViewdataByid/{id}")]
            //public IActionResult ViewCourseByid(int id)
            //{
            //    return Ok(Diary.tblTodo.Find(id));
            //}
        }
    }
}
