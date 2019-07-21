using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.DAL.Abstract;
using DevFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.DAL.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
