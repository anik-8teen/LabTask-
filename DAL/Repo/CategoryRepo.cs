using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class CategoryRepo
    {
        static DbNews Cat;
        static CategoryRepo ()
            {
            Cat = new DbNews();
            }
        static CategoryRepo Get(int id)
        {
            return Cat.categories.Find(id);

        }
    }
}
