using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    public class TurnoDbContext : DbContext
    {
        public TurnoDbContext() : base("KeyDB") { }

        public DbSet<Turno> Turnos { get; set; }


    }
}