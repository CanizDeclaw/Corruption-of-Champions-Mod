using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoC_Desktop_WPF.Utilities
{
    // Source version of this preloads everything.  For now, we're just lazy and load on demand.
    public class ImageManager
    {
        string RootDirectory { get; set; }
        readonly string[] ValidFileTypes = new string[] { ".bmp", ".jpg", ".jpeg", ".png", ".tiff", ".gif" };
        readonly Random random = new Random();

        public Image GetImage(string imageReference)
        {
            var path = Path.Combine(RootDirectory, imageReference);
            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path)
                    .Where(f => ValidFileTypes.Contains(Path.GetExtension(f)))
                    .ToArray();
                var index = random.Next(files.Count());
                var file = files[index];

                var bmap = new BitmapImage(new Uri(file, UriKind.RelativeOrAbsolute));
                return new Image
                {
                    Source = bmap
                };
            }
            return null;
        }

        public ImageManager(string rootDirectory, bool preloadFilePaths = false)
        {
            RootDirectory = rootDirectory;
        }
    }
}