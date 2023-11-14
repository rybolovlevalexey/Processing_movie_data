using System;
using System.Data.Entity;

namespace Обработка_данных_о_фильмах
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
    }
}
