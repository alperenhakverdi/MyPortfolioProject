﻿using DataAcessLayer.Abstract;
using DataAcessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
    internal class EfAboutDal: GenericRepository<About>, IAboutDal
    {
    }
}
