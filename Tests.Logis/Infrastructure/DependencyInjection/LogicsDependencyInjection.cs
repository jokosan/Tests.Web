using Microsoft.Extensions.DependencyInjection;
using Tests.Logis.Service;
using Tests.Logis.Service.Global;
using Tests.Logis.Service.Security;

namespace Tests.Logis.Infrastructure.DependencyInjection
{
    public class LogicsDependencyInjection
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddScoped<SecurityService>();
            services.AddScoped<TestsSecurityService>();
            services.AddScoped<SecurityService>();
            services.AddScoped<GlobalsService>();
            services.AddScoped<TestService>();
            services.AddScoped<QuestionsServises>();
            services.AddScoped<AnswerOptionsServises>();
        }
    }
}
