using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using Tests.Database.Model;
using Tests.Logis.Service;

namespace Tests.Web.Component
{
    public class SelectedTestComponent : ComponentBase
    {
        [Inject]
        protected TestService _testService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public dynamic Id { get; set; }

        protected bool checkBoxStart;
        protected bool disabledButton = true;

        protected ListTests listTests { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var resltGetTest = await _testService.GetById(Convert.ToInt32(Id));
            listTests = resltGetTest;
        }

        protected void OnChange(bool? value)
        {
            disabledButton = value == true ? false : true;
        }

        protected void OnClick(int id)
        {
            NavigationManager.NavigateTo($"/walkthrough/{id}");
        }
    }
}
