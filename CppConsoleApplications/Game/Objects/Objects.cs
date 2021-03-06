﻿using System;
using System.Drawing;

namespace Game
{
    abstract class BaseObject
    {
        public delegate void Message();
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
    class Asteroid : BaseObject, ICloneable, IComparable
    {
        public int Power {get;set;} = 1;
        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.White, Pos.X,Pos.Y,Size.Width,Size.Height);
        }
        public object Clone()
        {
            Asteroid asteroid = new Asteroid(new Point(Pos.X, Pos.Y), new Point(Dir.X, Dir.Y), new Size(Size.Width,Size.Height))
            { Power = Power };
            return asteroid;
        }

        public int CompareTo(object obj)
        {
            if (obj is Asteroid tmp)
            {
                if (Power > tmp.Power)
                    return 1;
                if (Power < tmp.Power)
                    return -1;
                else
                    return 0;
            }
            throw new ArgumentException("Par id not Asteroid!");
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
            if (Pos.X>Game.Width)
                Pos.Y = -100;
            else
                Pos.X+=3;
        }
    }
    class Ship : BaseObject
    {
        public Point Rect { get => Pos; }
        private int energy = 100;
        public int Energy => energy;
        public static event Message MessageDie;
        public void EnergyLow(int n)
        {
            energy -= n;
        }
        public Ship(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public override void Update()
        {
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Wheat,Pos.X,Pos.Y,Size.Width,Size.Height);
        }
        public void Up()
        {
            if (Pos.Y>0) Pos.Y = Pos.Y - Dir.Y;
        }
        public void Down()
        {
            if (Pos.Y+Size.Height<Game.Height) Pos.Y = Pos.Y + Dir.Y;
        }
        public void Die()
        {
            MessageDie?.Invoke();
        }
    }

}
