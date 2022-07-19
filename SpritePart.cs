using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BannerEdge
{
    public class SpritePart
    {
        public string Name { get; private set; }
        public string CategoryName { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int SheetX { get; private set; }
        public int SheetY { get; private set; }
        public Bitmap Bitmap { get; private set; }

        public SpritePart(XElement element)
        {
            Name = element.Descendants("Name").FirstOrDefault().Value;
            CategoryName = element.Descendants("CategoryName").FirstOrDefault().Value;
            Width = int.Parse(element.Descendants("Width").FirstOrDefault().Value);
            Height = int.Parse(element.Descendants("Height").FirstOrDefault().Value);
            SheetX = int.Parse(element.Descendants("SheetX").FirstOrDefault().Value);
            SheetY = int.Parse(element.Descendants("SheetY").FirstOrDefault().Value);
        }

        internal void SplitFromAtlas(Image image)
        {
            Bitmap bitmap = (Bitmap)image;
            Bitmap = bitmap.Clone(new Rectangle(SheetX, SheetY, Width, Height), bitmap.PixelFormat);
        }

        internal void Write(string directoryPath)
        {
            var splits = Name.Split('\\');
            var dir = "";
            for(int i = 0; i < splits.Length; i++)
            {
                if(i < splits.Length - 1) dir += splits[i] + "\\";
            }
            var dirPath = directoryPath + "\\" + dir;
            if(!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
            Bitmap.Save(dirPath + splits[splits.Length -1] + ".png");
        }
    }
}
