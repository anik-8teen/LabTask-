using DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbNews : DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<News> News { get; set; }

    }
}
