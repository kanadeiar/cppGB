using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
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
            Buffer.Render(); //перерисование
        }
        public static void Update()
        {
            foreach (BaseObject obj in objs)
                obj.Update();
        }
        public static BaseObject[] objs;
        public static void Load()
        {
            objs = new BaseObject[100];
            for (int i = 0; i < objs.Length; i++)
            {
                int randsize = i switch
                {
                    int ik when ik < 90 => rand.Next(3, 9),
                    int _ => rand.Next(10, 20)
                };
                int speed = randsize / 3;
                objs[i] = new Star(new Point(rand.Next(Width-randsize), rand.Next(Height-randsize)), new Point(-speed, 0), new Size(randsize, randsize));
            }
        }

    }
}
