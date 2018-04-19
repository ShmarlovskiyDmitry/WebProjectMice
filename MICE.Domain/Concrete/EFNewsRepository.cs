using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MICE.Domain.Abstract;
using MICE.Domain.Entities;
using System.Data.Entity.Migrations;


namespace MICE.Domain.Concrete
{
    public class EFNewsRepository:INewsRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<News> NewsContent
        {
            get { return context.NewsContent; }
        }
    }
}
