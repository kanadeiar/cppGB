using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Star : BaseObject
    {
        private static Image ImageStar = Image.FromFile("Star.png");
        static Star()
        {
        }
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public override void Draw(Graphics g)
        {
            //g.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X+Size.Width, Pos.Y+Size.Height);
            //g.DrawLine(Pens.White, Pos.X+Size.Width, Pos.Y, Pos.X, Pos.Y+Size.Height);
            g.DrawImage(ImageStar, Pos.X, Pos.Y, Size.Width, Size.Height);
            
        }
        public override void Update()
        {
            Pos.X += Dir.X;
            if (Pos.X + Size.Width < 0)
            {
                Pos.X = Game.Width + Size.Width;
                Pos.Y = Game.rand.Next(Game.Height-Size.Height);
            }
        }
    }
}
