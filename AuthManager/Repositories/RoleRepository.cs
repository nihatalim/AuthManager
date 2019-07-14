using AuthManager.Contexts;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DatabaseContext context;
        private readonly IStringLocalizer localizer;
        public RoleRepository(DatabaseContext context, IStringLocalizer localizer)
        {
            this.context = context;
            this.localizer = localizer;
        }
    }
}
