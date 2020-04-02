//add
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    class Game
    {
        private static BufferedGraphicsContext context;
        public static BufferedGraphics Buffer;
        public static int Width {get;set;}
        public static int Height {get;set;}
        static Game()
        {
        }
        public static void Init(Form form)
        {
            Graphics g;
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = context.Allocate(g, new Rectangle(0,0,Width,Height));
        }
        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black);
            Buffer.Graphics.DrawRectangle(Pens.White, new Rectangle(100,100,200,200));
            Buffer.Graphics.FillEllipse(Brushes.Wheat, new Rectangle(100,100,200,200));
            Buffer.Render();
        }

    }
}
