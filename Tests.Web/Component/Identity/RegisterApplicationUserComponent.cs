﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Radzen;
using System.Collections.Generic;
using Tests.Database.ModelIdentity;
using Tests.Logis.Service.Global;
using Tests.Logis.Service.Security;

namespace Tests.Web.Component.Identity
{
    public class RegisterApplicationUserComponent : ComponentBase
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
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected TestsSecurityService SecurityDb { get; set; }

        ApplicationUser _user;
        protected ApplicationUser user
        {
            get
            {
                return _user;
            }
            set
            {
                if (!object.Equals(_user, value))
                {
                    var args = new PropertyChangedEventArgs() { Name = "user", NewValue = value, OldValue = _user };
                    _user = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Security.InitializeAsync(AuthenticationStateProvider);
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            user = new ApplicationUser();
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close();
            await JSRuntime.InvokeAsync<string>("window.history.back");
        }
    }
}