using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.App.Services;
using ValhallaVaultCyberAwareness.Components;
using ValhallaVaultCyberAwareness.Components.Account;
using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;
using ValhallaVaultCyberAwareness.DAL.Uow;
using ValhallaVaultCyberAwareness.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<IRepository<CategoryModel>, Repository<CategoryModel>>();
builder.Services.AddScoped<IRepository<SegmentModel>, Repository<SegmentModel>>();
builder.Services.AddScoped<IRepository<SubcategoryModel>, Repository<SubcategoryModel>>();
builder.Services.AddScoped<IRepository<QuestionModel>, Repository<QuestionModel>>();
builder.Services.AddScoped<IRepository<AnswerModel>, Repository<AnswerModel>>();
builder.Services.AddScoped<IRepository<ApplicationUser>, Repository<ApplicationUser>>();
builder.Services.AddScoped<IRepository<UserResponseModel>, Repository<UserResponseModel>>();
builder.Services.AddScoped<IUow, Uow>();
builder.Services.AddScoped<IViewModelService, ViewModelService>();
builder.Services.AddScoped<ISegmentService, SegmentService>();

builder.Services.AddScoped<IUserResponseService, UserResponseService>();
builder.Services.AddScoped<IAuthService, AuthService>();


builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
async Task CreateRolesAndUsersAsync(IServiceProvider serviceProvider)
{
    using var scope = serviceProvider.CreateScope();
    var services = scope.ServiceProvider;
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

    string[] roleNames = { "Admin", "User" };
    foreach (var roleName in roleNames)
    {
        var roleExist = await roleManager.RoleExistsAsync(roleName);
        if (!roleExist)
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }
    }

    // User data
    var adminEmail = "admin@example.com";
    var adminLogin = "admin";
    var userEmail = "user@example.com";
    var userLogin = "user";
    var password = "Password1234!";

    // Ensure admin user exists
    var adminUser = await userManager.FindByNameAsync(adminLogin);
    if (adminUser == null)
    {
        adminUser = new ApplicationUser { UserName = adminLogin, Email = adminEmail };
        var createAdminResult = await userManager.CreateAsync(adminUser, password);
        if (createAdminResult.Succeeded)
        {
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }
    }

    // Ensure non-admin user exists
    var userUser = await userManager.FindByNameAsync(userLogin);
    if (userUser == null)
    {
        userUser = new ApplicationUser { UserName = userLogin, Email = userEmail };
        var createUserResult = await userManager.CreateAsync(userUser, password);
        if (createUserResult.Succeeded)
        {
            await userManager.AddToRoleAsync(userUser, "User");
        }
    }
}

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", options =>
    {
        options.AllowAnyHeader();
        options.AllowAnyMethod();
        options.AllowAnyOrigin();
    });
});



builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

//AppStart heter egentligen App ursprungligen i projektutformningen men fick en konflikt pga ValhallaVaultCyberAwareness.App namngivningen av vårt projekt
app.MapRazorComponents<AppStart>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.UseRouting();
app.UseAuthorization();
app.UseAntiforgery();
app.MapControllers();
app.UseCors("AllowAll");


await CreateRolesAndUsersAsync(app.Services);

app.Run();
