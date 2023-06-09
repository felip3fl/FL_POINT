﻿using FL.Point.Data.Inferfaces.Base;
using FL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Point.Data.Inferfaces
{
    public interface IFinancialTransactionRepository : IBaseRepository<FinancialTransaction>
    {
        Task<FinancialTransaction> GetById(int id);
    }
}
