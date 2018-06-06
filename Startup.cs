using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FirstCore.DB;

namespace FirstCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseInMemoryDatabase("name");
            });
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseMvc();

            // app.Use(async (context, next) =>
            // {
            //     await context.Response.WriteAsync("开始进入第一个管道...<br/>");
            //     await next.Invoke();
            //     await context.Response.WriteAsync("结束第一个管道...");
            // });

            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("开始进入第二个管道...<br/>");
            //     await context.Response.WriteAsync("开始处理...<br/>");


            //     int[] arr = { 1, 2, 3 };
            //     int i = arr[3];
            //     await context.Response.WriteAsync($"i的值是{i}<br/>");

            //     await context.Response.WriteAsync("处理完毕，开始返回...<br/>");
            //     await context.Response.WriteAsync("结束第二个管道...<br/>");
            // });

        }
    }
}
