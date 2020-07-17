using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodDonation.WebAPI.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using BloodDonation.DAL;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace BloodDonation.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddDbContext<SampleDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SampleDb")));

            services.AddDependencyInjuction();
            services.AddMvc().AddMvcOptions(options => options.EnableEndpointRouting = false)
                             .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                             .AddNewtonsoftJson(options => {
                                 //options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                                 options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                              });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.WithOrigins("http://localhost:3000")
                           .AllowAnyHeader()
                           .AllowAnyMethod());

            app.UseMvc();
        }
    }
}
