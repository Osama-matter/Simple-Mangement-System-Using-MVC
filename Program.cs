using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Add services to the container (MVC + Razor Runtime Compilation)
builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation();

// 2. Register DbContext with proper options (like connection string)
builder.Services.AddDbContext<Entity_FreamWork.Models.HR_Database_Context>(options =>
{
    // تأكد من أن connection string موجود في appsettings.json
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// 3. Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 4. Map the default controller route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

// ✅ هذه السطر غير ضروري لأنك بالفعل عملت route افتراضي لـ Employee
// ❌ لو أضفته هيرجع RedirectLoop
// app.MapGet("/", () => Results.Redirect("/Employee"));

app.Run();
