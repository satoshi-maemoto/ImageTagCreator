using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTagCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var targets = new string[]
            {
                ".JPG",
                ".JPEG",
                ".GIF",
            };

            var template = "<p><img alt=\"\" src=\"/files/u/blog/maemoto/{0}/{1}\" /><br />&nbsp;</p>";
            var currentDirectory = Path.GetFileName(Directory.GetCurrentDirectory());
            Console.WriteLine(currentDirectory);
            var files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (var file in files)
            {
                var match = false;
                foreach (var target in targets)
                {
                    if (file.ToUpper().EndsWith(target))
                    {
                        match = true;
                        break;
                    }
                }
                if (match)
                {
                    Console.WriteLine(string.Format(template, currentDirectory, Path.GetFileName(file)));
                }
            }
        }
    }
}
