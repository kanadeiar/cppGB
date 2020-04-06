using System;
using System.Drawing;

namespace Game
{
    abstract class BaseObject
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;
        protected BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }
        public abstract void Draw(Graphics g);
        public virtual void Update()
        {
            Pos.X += Dir.X;
            Pos.Y += Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X+Size.Width > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y+Size.Height > Game.Height) Dir.Y = -Dir.Y;
        }
    }
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
    class Asteroid : BaseObject
    {
        public int Power {get;set;} = 1;
        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.White, Pos.X,Pos.Y,Size.Width,Size.Height);
        }
    }
    class Bullet : BaseObject
    {
        public Bullet(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.OrangeRed,Pos.X,Pos.Y,Size.Width,Size.Height);
        }
        public override void Update()
        {
            Pos.X+=3;
        }
    }
}
