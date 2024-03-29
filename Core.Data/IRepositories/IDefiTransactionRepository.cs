﻿using Core.Data.Entities;
using Core.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.IRepositories
{ 

    public interface IDefiTransactionRepository : IRepository<DefiTransaction, Guid>
    {
    }
}
