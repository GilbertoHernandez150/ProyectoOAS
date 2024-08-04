namespace OAS.Web
public void ConfigureServices(IServiceCollection services)
{
    {
        services.AddControllersWithViews();

        // Configurar HttpClient
        services.AddHttpClient<PersonService>(client =>
        {
            client.BaseAddress = new Uri("https://localhost:5001/"); // Cambia esta URL según la configuración de tu API
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        });
    }
    services.AddHttpClient<ApiClient>(client =>
    {
        client.BaseAddress = new Uri("https://localhost:5001/api/");
        client.DefaultRequestHeaders.Add("Accept", "application/json");
    });

    services.AddControllersWithViews().AddRazorRuntimeCompilation();
}
