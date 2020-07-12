using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SkinProject
{
    public class MyBitmap
    {
        public Bitmap bmp { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string dir { get; set; }

        public MyBitmap() { }

        public MyBitmap(Bitmap bmp, string path) {
            this.bmp = bmp;
            this.path = path;
            string[] asd = path.Split('\\');
            this.name = asd[asd.Length - 1].Split('.')[0];
            this.dir = Path.GetDirectoryName(path);
        }

    }
}
