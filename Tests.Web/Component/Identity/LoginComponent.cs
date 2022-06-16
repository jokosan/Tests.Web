using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using System;
using System.Collections.Generic;
using Tests.Logis.Service.Global;
using Tests.Logis.Service.Security;
using Tests.Web.Pages.IdentityPages;

namespace Tests.Web.Component.Identity
{
    public class LoginComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

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
        protected SecurityService Security { get; set; }


        [Inject]
        protected TestsSecurityService SecurityDb { get; set; }

        dynamic _redirectUrl;
        protected dynamic redirectUrl
        {
            get
            {
                return _redirectUrl;
            }
            set
            {
                if (!object.Equals(_redirectUrl, value))
                {
                    var args = new PropertyChangedEventArgs() { Name = "redirectUrl", NewValue = value, OldValue = _redirectUrl };
                    _redirectUrl = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var query = System.Web.HttpUtility.ParseQueryString(new Uri(UriHelper.ToAbsoluteUri(UriHelper.Uri).ToString()).Query);

            var error = query.Get("error");

            redirectUrl = query.Get("redirectUrl"); ;

            if (!string.IsNullOrEmpty(error))
            {
                NotificationService.Notify(new NotificationMessage() { Severity = NotificationSeverity.Error, Summary = $"Error", Detail = $"{error}" });
            }
        }

        protected async System.Threading.Tasks.Task Login0Register()
        {
            await DialogService.OpenAsync<RegisterApplicationUser>("Register Application User", null);
        }
    }
}
