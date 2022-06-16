using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Radzen;
using Radzen.Blazor;
using Tests.Logis.Service.Security;

namespace Tests.Web.Component.Identity
{
    public class MainLayoutComponent : LayoutComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }

        [Inject]
        protected TestsSecurityService SecurityDb { get; set; }

        protected RadzenBody body0;
        protected RadzenSidebar sidebar0;

        private void Authenticated()
        {
            StateHasChanged();
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            if (Security != null)
            {
                Security.Authenticated += Authenticated;

                await Security.InitializeAsync(AuthenticationStateProvider);
            }
        }

        protected async System.Threading.Tasks.Task SidebarToggle0Click(dynamic args)
        {
            await InvokeAsync(() => { sidebar0.Toggle(); });

            await InvokeAsync(() => { body0.Toggle(); });
        }
    }
}
