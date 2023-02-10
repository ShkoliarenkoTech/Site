using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Site.Interfaces;
using Site.Data.Mocks;


namespace Site
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllBakery,MockBakery>(); // connect any interface to one class which realize it.
            services.AddTransient<IBakeryProductsCategory,MockCategories>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // page with any exceptions;
            app.UseStatusCodePages(); // code of the pages 404, 500 , ~200~ - succeeded;
            app.UseStaticFiles(); // show css files, pictures ...;
            app.UseMvcWithDefaultRoute(); // follow URL-adress (if controller & view  == doesn't exsist --> URL-by-default.)
        }
    }
}
