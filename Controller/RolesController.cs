using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvSis.Utilities;
using NLog;
using InvSis.Data;

namespace InvSis.Controller
{
    public class RolesController
    {
        private static readonly Logger _Logger = LoggingManager.GetLogger("InvSis.Controller.RolesController");
        private readonly RolesDataAccess _rolesData;
        private readonly PermisosDataAccess _permisosData;
    }
}
