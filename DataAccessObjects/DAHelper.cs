using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Entity;

using AdventureWorks.Domain.ModelObjects;
using AdventureWorks.Domain.ModelObjects.Entities;

namespace AdventureWorks.Domain.DataAccessObjects
{
    public class DAHelper
    {
        private AdventureWorksModelContainer _dbcon;
        public AdventureWorksModelContainer getDbCon()
        {
            if (null == this._dbcon)
            {
                _dbcon = new AdventureWorksModelContainer();
            }
            return _dbcon;
        }

        private DbTransaction _dbtran;

        public void beginDbTransaction() 
        {
            _dbtran = getDbCon().Database.Connection.BeginTransaction();
        }

        public void Commit()
        {
            if (null != _dbtran)
            {
                _dbtran.Commit();
            }
        }

        public void Rollback()
        {
            if (null != _dbtran)
            {
                _dbtran.Rollback();
            }
        }

        public DbCommand getDbCommand()
        {
            return getDbCon().Database.Connection.CreateCommand();    
        }

        public int execDbCommand(string command)
        {
            DbCommand cmd = getDbCommand();
            cmd.CommandText = command;
            return cmd.ExecuteNonQuery();
        }
    }

}
