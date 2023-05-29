using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using FEDAC.data.Concrete.EfCore;
using FEDAC.data.Abstract;
using FEDAC.business.Abstract;
using FEDAC.business.Concrete;
using Microsoft.EntityFrameworkCore;
using FEDAC.webui.Identity;
using Microsoft.AspNetCore.Identity;
using FEDAC.webui.EmailServices;
using Microsoft.Extensions.Configuration;
using shopapp.webui.Identity;

namespace FEDAC.webui
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }





        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=shopDb"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                //password giriş kosullari
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;

                //Lockout 
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                //options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false; //true olcak
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });
            //kullanıcının tarayıcısına bırakılan cookie.Tanıma işlemi için.
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".FEDAC.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };

            });


            //mvc yapisi icin ekledik, razor sayfalari icinde gerekli   
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>(); //daha sonra sql ,mysql,mssql kullanmak istersek tek bir yerden değiştireceğiz.
            services.AddScoped<IProductRepository, EfCoreProductRepository>();
            services.AddScoped<ICartRepository, EfCoreCartRepository>();  //Cart kısmı için


            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICartService, CartManager>();


            services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
                 new SmtpEmailSender(
                    _configuration["EmailSender:Host"],
                    _configuration.GetValue<int>("EmailSender:Port"),
                    _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    _configuration["EmailSender:UserName"],
                    _configuration["EmailSender:Password"])
                    );
            services.AddControllersWithViews();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IConfiguration configuration,UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            app.UseStaticFiles(); //wwwroot klasörlerine erişim..

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath = "/modules"
            });

            if (env.IsDevelopment()) //ortam değişkenleri
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();


            //localhost:5001 gibi yönlendirme yapmamıza olanak sağlar.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "cart", 
                    pattern: "cart",
                    defaults: new {controller="Cart",action="Index"}
                ); 
                endpoints.MapControllerRoute(
                    name: "adminuseredit", 
                    pattern: "admin/user/{id?}",
                    defaults: new {controller="Admin",action="UserEdit"}
                ); 

                 endpoints.MapControllerRoute(
                    name: "adminusers", 
                    pattern: "admin/user/list",
                    defaults: new {controller="Admin",action="UserList"}
                );

                endpoints.MapControllerRoute(
                    name: "adminroles", 
                    pattern: "admin/role/list",
                    defaults: new {controller="Admin",action="RoleList"}
                );

                endpoints.MapControllerRoute(
                    name: "adminrolecreate", 
                    pattern: "admin/role/create",
                    defaults: new {controller="Admin",action="RoleCreate"}
                );  

                endpoints.MapControllerRoute(
                    name: "adminroleedit", 
                    pattern: "admin/role/{id?}",
                    defaults: new {controller="Admin",action="RoleEdit"}
                ); 
                
                endpoints.MapControllerRoute(
                    name: "adminproduct",
                    pattern: "admin/products",
                    defaults: new { controller = "Admin", action = "ProductList" }
                );

                endpoints.MapControllerRoute(
                    name: "adminproductcreate",
                    pattern: "admin/products/create",
                    defaults: new { controller = "Admin", action = "ProductCreate" }
                );

                endpoints.MapControllerRoute(
                    name: "adminproductedit",
                    pattern: "admin/products/{id?}",
                    defaults: new { controller = "Admin", action = "ProductEdit" }
                );

                endpoints.MapControllerRoute(
                    name: "admincategoriescreate",
                    pattern: "admin/categories/create",
                    defaults: new { controller = "Admin", action = "CategoryCreate" }
                );

                endpoints.MapControllerRoute(
                    name: "admincategories",
                    pattern: "admin/categories",
                    defaults: new { controller = "Admin", action = "CategoryList" }
                );

                endpoints.MapControllerRoute(
                    name: "admincategoryedit",
                    pattern: "admin/categories/{id?}",
                    defaults: new { controller = "Admin", action = "CategoryEdit" }
                );


                //localhost/search
                endpoints.MapControllerRoute(
                    name: "search",
                    pattern: "search",
                    defaults: new { controller = "Shop", action = "search" }
                );

                endpoints.MapControllerRoute(
                    name: "productdetails",
                    //ürün içerisinde ikinci bölmede bir değer varsa category bölgesini shopControllerın IActionResulttan alır.
                    // örn: products/telefon gibii
                    pattern: "{url}",
                    defaults: new { controller = "Shop", action = "details" }
                );
                //sabit olarak url tanımı yaptık 

                endpoints.MapControllerRoute(
                    name: "products",
                    //ürün içerisinde ikinci bölmede bir değer varsa category bölgesini shopControllerın IActionResulttan alır.
                    // örn: products/telefon gibii
                    pattern: "products/{category?}",
                    defaults: new { controller = "Shop", action = "list" }
                );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"

                );
            });
                SeedIdentity.Seed(userManager,roleManager,configuration).Wait();
        }
    }
}