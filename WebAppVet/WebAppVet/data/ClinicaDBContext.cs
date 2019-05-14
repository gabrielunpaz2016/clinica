using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppVet.Models;

namespace WebAppVet.data
{
    public class ClinicaDBContext : DbContext
    {
        public ClinicaDBContext() : base("ClinicaDBContext")
        {
        }

        public DbSet<Room> Rooms { get; set; }
    }
}