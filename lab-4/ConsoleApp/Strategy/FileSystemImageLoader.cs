using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FileSystemImageLoader : IImageLoaderStrategy
    {
        public void LoadImage(string filePath)
        {
            Console.WriteLine($"Loading an image from file system: {filePath}");
        }
    }
}
