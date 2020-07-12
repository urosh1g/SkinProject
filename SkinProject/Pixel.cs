using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SkinProject
{
    public class Pixel
    {
        public int I { get; set; }
        public int J { get; set; }
        public Color color { get; set; }
        PixelType t;
        public BodyPart BodyPart { get; set; }

        public Pixel(int i, int j, Color c, BodyPart bp) {
            this.I = i;
            this.J = j;
            this.color = c;
            if (this.color.A == Convert.ToByte(PixelType.TRANSPARENT))
                this.t = PixelType.TRANSPARENT;
            else if (this.color.A <= Convert.ToByte(PixelType.TRANSLUCENT))
                this.t = PixelType.TRANSLUCENT;
            else this.t = PixelType.OPAQUE;
            this.BodyPart = bp;
        }

        public override string ToString()
        {
            return $"POSITION = ({I},{J})  PIXEL TYPE = {t}  BODY PART = {BodyPart}\r\n";
        }

    }
}
