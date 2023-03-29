using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Category
    {
        [Key]
        public int C_Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<News> News { get; set; }

        Category()
        {
            News = new List<News>();
        }
    }
}
