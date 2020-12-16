using System.Security.Claims;
using FirstTier.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FirstTier.Data;
using FirstTier.Data.Impl;
using FirstTier.Chat;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

namespace FirstTier
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            
            services.AddHttpContextAccessor();
            
            services.AddScoped<UserService, UserCloud>();
            
            services.AddScoped<AccountService,AccountCloud>();
            
            services.AddScoped<ArtworkService,ArtworkCloud>();

            services.AddScoped<AuthenticationStateProvider, UserCustomAuthenticationStateProvider>();
            
            //Provide database for chat
            services.AddDbContext<DataAccess.AppContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("sep3db")));
            
            //Register dapper in scope  
            services.AddScoped<DapperService, DapperCloud>();
            
            //services.AddSignalR().AddAzureSignalR(); // for chat

            services.AddAuthorization(options =>
            {
                options.AddPolicy("admin",  a => 
                    a.RequireAuthenticatedUser().RequireClaim("securityLevel", "5"));
              
                options.AddPolicy("LoggedUser", policy =>
                    policy.RequireAuthenticatedUser().RequireAssertion(context =>
                    {
                        Claim logClaim = context.User.FindFirst(claim => claim.Type.Equals("userId"));
                        if (logClaim == null)
                        {
                            return false;
                        }
                        return int.Parse(logClaim.Value) > 0;
                    }));
                options.AddPolicy("LoggedButNotAdmin", policy =>
                    policy.RequireAuthenticatedUser().RequireAssertion(context =>
                    {
                        Claim logClaim = context.User.FindFirst(claim => claim.Type.Equals("SecurityLevel"));
                        if (logClaim == null)
                        {
                            return false;
                        }
                        return int.Parse(logClaim.Value) == 3;
                    }));
                options.AddPolicy("Guest", policy =>
                                  
                    policy.RequireAuthenticatedUser().RequireAssertion(context =>
                    {
                        Claim logClaim = context.User.FindFirst(claim => claim.Type.Equals("userId"));
                        if (logClaim == null)
                        {
                            return true;
                        }
                        return false;
                    }));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
   
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
                endpoints.MapHub<ChatHub>(ChatHub.HubUrl);
            });
        }
    }
}