using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer.Abstract;
using DataAcessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAcessLayer.EntityFramework
{
    public class EfExperienceDal: GenericRepository<Experience>, IExperienceDal
    {
    }
}
