using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Tomappto.Api.Test.Extensions
{
    internal class ApiWebApplicationFactory<TStartUp>
            : WebApplicationFactory<TStartUp> where TStartUp : class
    {

        Action<IServiceCollection> serviceConfiguration { get; }

        public ApiWebApplicationFactory(Action<IServiceCollection> serviceConfiguration) : base()
        {
            this.serviceConfiguration = serviceConfiguration;
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            if (this.serviceConfiguration != null)
            {
                builder.ConfigureServices(this.serviceConfiguration);
            }
        }


    }
}
