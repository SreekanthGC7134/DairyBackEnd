using DairyBackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DairyBackEnd.Data
{
    public class DataContextClass:DbContext
    {
    public DataContextClass(DbContextOptions<DataContextClass> options):base(options)
        {

        }
        public DbSet<Registration> tblregistration { get; set; }
        public DbSet<Profile> tblprofile { get; set; }
        public DbSet<DairyEntry> tbldairyentry { get; set; }
        public DbSet<ToDo> tbltodo { get; set; }
    }
}