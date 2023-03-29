using DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class NewsRepo
    {
        static DbNews NewsCon;

        static NewsRepo()
        {
            NewsCon = new DbNews();
        }
        public static List<News> Get()
        {
            return NewsCon.News.ToList();
        }
    }
}
