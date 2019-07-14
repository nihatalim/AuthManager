using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthManager.Contexts;
using Microsoft.Extensions.Localization;

namespace AuthManager.Repositories
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly DatabaseContext context;
        private readonly IStringLocalizer localizer;
        public ResourceRepository(DatabaseContext context, IStringLocalizer localizer)
        {
            this.context = context;
            this.localizer = localizer;
        }
    }
}
