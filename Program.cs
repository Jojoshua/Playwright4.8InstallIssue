using Microsoft.Playwright;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Go().ConfigureAwait(false);
        }

        public static async Task Go()
        {
            using (var playwright = await Playwright.CreateAsync())
            {
                var browser = await playwright.Chromium.LaunchAsync();
                var page = await browser.NewPageAsync();
                await page.GotoAsync("https://playwright.dev/dotnet");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
                await browser.DisposeAsync();
            }
        }
    }
}
