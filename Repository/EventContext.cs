using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class EventContext : DbContext
    {
        public DbSet<DataBaseEvent> Events{ get; set; }
    }
}
