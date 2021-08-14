using APISigna.infra.Connection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.infra.Data
{
    public class Context : BaseSQLServer
    {
        public Context() : base("localDB")
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
