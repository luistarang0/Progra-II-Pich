using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvSis.Utilities;
using NLog;

namespace InvSis.Data
{
    public class RolesDataAccess
    {
        private static readonly Logger _Logger = LoggingManager.GetLogger("InvSis.Data.RolesDataAccess");
        private readonly PostgreSQLDataAccess _dbAccess;

        public RolesDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception ex)
            {
                _Logger.Fatal(ex, "Error al inicializar PersonasDataAccess");
                throw;
            }
        }
    }
}
