using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.Owin.Hosting;
using System;
using System.ServiceProcess;
using System.Threading;

namespace ExampleService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Thread.Sleep(20000);

            GlobalConfiguration.Configuration.UseMemoryStorage();
            StartOptions options = new StartOptions();
            options.Urls.Add("http://localhost:9095");
            options.Urls.Add("http://127.0.0.1:9095");
            options.Urls.Add($"http://{Environment.MachineName}:9095");

            WebApp.Start<Startup>(options);
        }

        protected override void OnStop()
        {
        }
    }
}
