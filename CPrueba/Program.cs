using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace CPrueba
{
    class MainClass
    {
        public static async Task Main(string[] args)
        {
            Test tmpTest = new Test();
            await tmpTest.InjectHTML();
            
        }
    }
}








