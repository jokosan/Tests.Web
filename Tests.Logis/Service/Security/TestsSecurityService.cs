using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tests.Database.Context;

namespace Tests.Logis.Service.Security
{
    public partial class TestsSecurityService
    {
        ApplicationIdentityDbContext Context
        {
            get
            {
                return this.context;
            }
        }

        private readonly ApplicationIdentityDbContext context;
        private readonly NavigationManager navigationManager;

        public TestsSecurityService(ApplicationIdentityDbContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public void Reset() => Context.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);

    }
}
