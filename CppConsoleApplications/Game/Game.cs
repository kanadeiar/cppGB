using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    static class Game
    {
        private static BufferedGraphicsContext context;
        public static BufferedGraphics Buffer;
        public static int Width {get;set;}
        public static int Height {get;set;}
        public static Random rand = new Random();
        private static BaseObject[] objs;
        private static Bullet bullet;
        private static Asteroid[] asteroids;
        static Game()
        {
        }
        public static void Init(Form form)
        {
            Graphics g; //графическое устройство для вывода графики
            context = BufferedGraphicsManager.Current; //буфер графического контекста для приложения
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = context.Allocate(g, new Rectangle(0,0,Width,Height)); //связь буфера в памяти с графическим объектом в целях рисования в буфере
            Load();
            Timer timer = new Timer {Interval = 10};
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }
        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black); //фон
            foreach (BaseObject obj in objs)
                obj.Draw(Buffer.Graphics);
            foreach (BaseObject obj in asteroids)
                obj.Draw(Buffer.Graphics);
            bullet.Draw(Buffer.Graphics);
            Buffer.Render(); //перерисование
        }
        public static void Update()
        {
            foreach (BaseObject obj in objs)
                obj.Update();
            foreach (BaseObject obj in asteroids)
                obj.Update();
            bullet.Update();
        }
        public static void Load()
        {
            objs = new BaseObject[100];
            for (int i = 0; i < objs.Length; i++)
            {
                int r = rand.Next(5,50);
                objs[i] = new Star(new Point(600, rand.Next(Height)), new Point(-r, r), new Size(4, 4));
            }
            asteroids = new Asteroid[3];
            for (int i = 0; i < asteroids.Length; i++)
            {
                int r = rand.Next(5, 50);
                asteroids[i] = new Asteroid(new Point(600, rand.Next(Height)), new Point(-r / 5, r), new Size(r, r));
            }
            bullet = new Bullet(new Point(0,200), new Point(5,0), new Size(4,1));
        }

    }
}
