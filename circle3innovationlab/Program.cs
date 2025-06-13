using Umbraco.Cms.Infrastructure.Persistence;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// إضافة إعدادات Umbraco
builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddDeliveryApi()
    .AddComposers()
    .Build();

// تهيئة MVC
builder.Services.AddMvc(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(5); // أو أي مدة تحبها
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

WebApplication app = builder.Build();

// تأكد من استخدام الـ session بعد ما يتم بناء التطبيق بالكامل
app.UseSession();

// ابدأ Umbraco بعد بناء التطبيق
await app.BootUmbracoAsync();

// الآن يمكنك استخدام IUmbracoDatabaseFactory و باقي الخدمات بشكل آمن
var dbFactory = app.Services.GetRequiredService<IUmbracoDatabaseFactory>();

app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseInstallerEndpoints();
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });

await app.RunAsync();
