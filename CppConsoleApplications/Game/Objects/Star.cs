using System;
//using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Game
{
    class Star : BaseObject
    {
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X+Size.Width, Pos.Y+Size.Height);
            g.DrawLine(Pens.White, Pos.X+Size.Width, Pos.Y, Pos.X, Pos.Y+Size.Height);
        }
        public override void Update()
        {
            Pos.X += Dir.X;
            if (Pos.X < 0)
                Pos.X = Game.Width + Size.Width;
        }
    }
}
