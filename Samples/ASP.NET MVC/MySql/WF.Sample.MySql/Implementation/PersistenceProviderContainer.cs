﻿using OptimaJet.Workflow.Core.Generator;
using OptimaJet.Workflow.Core.Persistence;
using OptimaJet.Workflow.MySQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WF.Sample.Business.DataAccess;

namespace WF.Sample.MySql.Implementation
{
    public class PersistenceProviderContainer : IPersistenceProviderContainer
    {
        public PersistenceProviderContainer()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            Provider = new MySQLProvider(connectionString);
        }

        public IWorkflowProvider Provider { get; private set; }
    }
}
