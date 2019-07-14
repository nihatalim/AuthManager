using AuthManager.Contexts;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Repositories
{
    public class LogicRepository : ILogicRepository
    {
        private readonly DatabaseContext context;
        private readonly IStringLocalizer localizer;
        public LogicRepository(DatabaseContext context, IStringLocalizer localizer)
        {
            this.context = context;
            this.localizer = localizer;
        }
    }
}
