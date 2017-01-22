using Hangfire;
using Owin;

namespace ExampleService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHangfireDashboard();
        }
    }
}
