using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace AuthorizationAndAuthentication.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             start point of application, which bootstraps the host
             */
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
