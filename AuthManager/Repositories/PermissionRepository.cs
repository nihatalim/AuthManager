using AuthManager.Contexts;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DatabaseContext context;
        private readonly IStringLocalizer localizer;
        public PermissionRepository(DatabaseContext context, IStringLocalizer localizer)
        {
            this.context = context;
            this.localizer = localizer;
        }
    }
}
