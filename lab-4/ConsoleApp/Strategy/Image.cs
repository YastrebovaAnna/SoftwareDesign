using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strategy
{
    public class Image
    {
        private IImageLoaderStrategy loader;
        private void SetStrategy(IImageLoaderStrategy loader)
        {
            this.loader = loader;
        }
        public void LoadImg(string href)
        {

            bool isMatch = Regex.IsMatch(href, @"\b(?:https?|ftp):\/\/[-A-Z0-9+&@#\/%?=~_|!:,.;]*[A-Z0-9+&@#\/%=~_|]", RegexOptions.IgnoreCase);
            SetStrategy(isMatch ? new NetworkImageLoader() : new FileSystemImageLoader());
            this.loader.LoadImage(href);
        }
    }
}
