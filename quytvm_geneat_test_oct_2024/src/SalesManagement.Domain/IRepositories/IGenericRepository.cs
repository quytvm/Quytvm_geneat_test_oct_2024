﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Domain.IRepositories
{
    public interface IGenericRepository<in T> where T : class
    {
    }
}
