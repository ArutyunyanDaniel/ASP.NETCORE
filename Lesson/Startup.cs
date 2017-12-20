using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Lesson
{
    //класс логигки обработки запросов 
    public class Startup
    {
        string name;
        public Startup()
        {
            name = "dany";
        }
        
        //упраляет добавление сервисов в приложении
        public void ConfigureServices(IServiceCollection services)
        {
        }

        //метод определяет как запрос будет обрабатываться
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Hello {name}");
            });
        }
    }
}
