﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kidzmile.Common.Uow;
using System.Data;

namespace Kidzmile.Web.Repository
{
   public class BaseAppRepository
    {
        private IDatabaseProvider database;
        public BaseAppRepository()
        {
            database = new DatabaseProvider();
        }

        public IDbConnection GetMasterDbConnection()
        {
            return database.GetMasterDbConnection();
        }
            
    }
}
