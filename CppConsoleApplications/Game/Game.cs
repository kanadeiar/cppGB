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
        private static Ship ship;
        private static Timer timer = new Timer {Interval = 10};

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
            timer.Tick += Timer_Tick;
            timer.Start();
            form.KeyDown += Form_KeyDown;
            Ship.MessageDie += Finish;
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }
        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.ControlKey) bullet 
                = new Bullet(new Point(ship.Rect.X+100, ship.Rect.Y+8), new Point(4,0), new Size(6,3));
            if (e.KeyCode==Keys.Up) ship.Up();
            if (e.KeyCode==Keys.Down) ship.Down();
        }
        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black); //фон
            foreach (BaseObject obj in objs)
                obj.Draw(Buffer.Graphics);
            foreach (BaseObject obj in asteroids)
                obj.Draw(Buffer.Graphics);
            bullet?.Draw(Buffer.Graphics);
            ship.Draw(Buffer.Graphics);
            if (ship!=null)
                Buffer.Graphics.DrawString($"Energy: {ship.Energy}", SystemFonts.DefaultFont, Brushes.White, 0, 0);
            Buffer.Render(); //перерисование
        }
        public static void Update()
        {
            foreach (BaseObject obj in objs)
                obj.Update();
            foreach (BaseObject obj in asteroids)
                obj.Update();
            bullet?.Update();
            ship.Update();

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
            ship = new Ship(new Point(10,400),new Point(6,6), new Size(100,20));
        }
        public static void Finish()
        {
            timer.Stop();
            Buffer.Graphics.DrawString("The End", new Font(FontFamily.GenericSansSerif,30), Brushes.White,200,100);
            Buffer.Render();
        }
    }
}
