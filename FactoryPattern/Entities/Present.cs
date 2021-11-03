using FactoryPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Entities
{
    public class Present : Toy
    {
        public SolidBrush PresentColor { get; private set; }
        public SolidBrush PresentColor1 { get; private set; }


        public Present(Color color, Color color1)
        {
            PresentColor = new SolidBrush(color);
            PresentColor1 = new SolidBrush(color1);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentColor, 0, 0, Width, Height);
            g.FillRectangle(PresentColor1, 0, Height/2, Width, Height/3);
            g.FillRectangle(PresentColor1, Width / 2, 0, Width/3, Height);
        }
    }
}
