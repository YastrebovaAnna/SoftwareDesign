using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NetworkImageLoader : IImageLoaderStrategy
    {
        public void LoadImage(string url)
        {
            Console.WriteLine($"Loading an image from the internet: {url}");
        }
    }
}
