using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DairyBackEnd.Models
{
    public class ToDo
    {
        [Key]
        public int tid { get; set; }
        public string task { get; set; }
        public string status {get;set;}
    }
}
