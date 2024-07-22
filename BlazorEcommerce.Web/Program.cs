using BlazorEcommerce.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorEcommerce.Web;

public class Program {
    public static async Task Main(string[] args) {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        const string baseUrl = "https://localhost:7243";
        builder.Services.AddScoped(sp => new HttpClient {
            BaseAddress = new Uri(baseUrl)
        });

        builder.Services.AddScoped<IProductService, ProductService>();

        await builder.Build().RunAsync();
    }
}