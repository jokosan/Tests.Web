using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Tests.Database.Infrastructure.UnitOfWorks;
using Tests.Database.Model;

namespace Tests.Logis.Service
{
    public class TestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TestService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<ListTests>> GetAllStatusTrue()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userTestResult = await _unitOfWork.UserTestUnitOfWork.QueryObjectGraph(x => x.UserId == userId);
            var result = await _unitOfWork.TestUnitOfWork.QueryObjectGraph(x => x.StatusPublic == true);

            List<ListTests> listTests = new();
            foreach (var item in userTestResult)
            {
                listTests.Add(result.FirstOrDefault(x => x.IdListTest == item.TestId));
            }

            return listTests.AsEnumerable();
        }

        public async Task<ListTests> GetById(int IdListTest)
            => await _unitOfWork.TestUnitOfWork.GetById(IdListTest);
    }

}
