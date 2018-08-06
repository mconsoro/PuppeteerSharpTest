using PuppeteerSharp;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CPrueba
{
    public class Test
    {
        public async Task InjectHTML()
        {
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = false
            });
            var tmpFilePath = Path.Combine("C://Users//mconsoro//source//repos//CPrueba//CPrueba//Resources", "WebPage.html");
            string tmpHtml = File.ReadAllText(tmpFilePath);

            var page = await browser.NewPageAsync();
               
            await page.SetContentAsync(tmpHtml);

            var result = await page.GetContentAsync();
            await page.SetViewportAsync(new ViewPortOptions { Width = 910, Height = 2050 });

            await page.ScreenshotAsync("C://Users//mconsoro//source//repos//CPrueba//CPrueba//Resources//ImageWeb.png");

        }
    }
}
