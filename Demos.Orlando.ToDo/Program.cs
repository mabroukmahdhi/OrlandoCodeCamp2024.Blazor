// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Presented w/ love at Orlando Code Camp 2024.
// ---------------------------------------------------------------

using Demos.Orlando.ToDo.Brokers.Storages;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demos.Orlando.ToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
             
            builder.Services.AddRazorPages(options=> options.RootDirectory ="/Views/Pages");
            builder.Services.AddServerSideBlazor(); 
            builder.Services.AddDbContext<StorageBroker>();
            builder.Services.AddScoped<IStorageBroker,StorageBroker>();

            var app = builder.Build();
             
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                 app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");
            app.Run();
        }
    }
}
