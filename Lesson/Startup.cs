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
    //обработка запросов
    public class Startup
    {
        int x = 2;
        //добавление сервисов
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
                string host = context.Request.Host.Value;
                string parh = context.Request.Path;
                string querty = context.Request.QueryString.Value;
                context.Response.ContentType = "text/html;charset=utf-8";
                await context.Response.WriteAsync($"<h3>Хост: {host}</h3>"+
                    $"<h3>Путь: {parh}</h3>"+ $"<h3>string: {querty}</h3>");
            });
        }
    }
}
