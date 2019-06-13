using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _200395689A1.Models
{
    public class _200395689A1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public _200395689A1Context() : base("name=_200395689A1Context")
        {
        }

        public System.Data.Entity.DbSet<_200395689A1.Models.Game> Games { get; set; }

        public System.Data.Entity.DbSet<_200395689A1.Models.Publisher> Publishers { get; set; }

        public System.Data.Entity.DbSet<_200395689A1.Models.Developer> Developers { get; set; }

        public System.Data.Entity.DbSet<_200395689A1.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<_200395689A1.Models.Review> Reviews { get; set; }
    }
}
