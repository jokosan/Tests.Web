using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tests.Database.Model;
using Tests.Logis.Service;

namespace Tests.Web.Component
{
    public class IndexComponent : ComponentBase
    {
        [Inject]
        protected TestService _testService { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        public IEnumerable<ListTests> GetTests;

        protected override async Task OnInitializedAsync()
        {
            var resltGetTest = await _testService.GetAllStatusTrue();
            GetTests = resltGetTest;
        }

        protected void ButtonClickImgPage(int Id)
        {
            NavigationManager.NavigateTo($"/selected-test/{Id}");
        }
    }
}
