﻿using System;
using EducationPortal.BLL.Interfaces;
using EducationPortal.Prompt.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace EducationPortal.Prompt
{
    public class Startup
    {
        public IServiceCollection Services { get; private set; }

        public IServiceProvider ServiceProvider { get; private set; }
        
        
        public IServiceProvider ConfigureServices()
        {
            var bll = new BLL.Startup();
            bll.ConfigureServices();

            this.Services = bll.Services;

            this.Services.AddScoped<AccountController>();
            this.Services.AddScoped<ArticleController>();
            this.Services.AddScoped<MaterialController>();
            
            return this.ServiceProvider = Services.BuildServiceProvider();
        }
    }
}
