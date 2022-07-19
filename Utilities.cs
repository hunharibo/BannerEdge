using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BannerEdge
{
    public static class Utilities
    {

        public static bool IsValidXMLFile(string path)
        {
            bool result = false;
            if (File.Exists(path))
            {
                try
                {
                    var node = XElement.Load(path);
                    if (node.Name == "SpriteData") result = true;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return result;
        }

        public static bool IsValidPNGFile(string path)
        {
            bool result = false;
            if (File.Exists(path))
            {
                var file = new FileInfo(path);
                if (file.Extension == ".png" && file.Length > 0) return true;
            }
            return result;
        }

        public static List<SpritePart> ParseParts(string path, string categoryName, string sheetId)
        {
            List<SpritePart> parts = new List<SpritePart>();
            XElement element = XElement.Load(path);
            foreach(var part in element.Descendants("SpritePart"))
            {
                if(part.Descendants("CategoryName").FirstOrDefault().Value == categoryName && part.Descendants("SheetID").FirstOrDefault().Value == sheetId)
                {
                    parts.Add(new SpritePart(part));
                }
            }
            return parts;
        }
    }
}
