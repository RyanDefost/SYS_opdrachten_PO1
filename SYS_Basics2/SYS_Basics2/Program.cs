using System;

namespace SYS_Basics2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is X");
            string answer1 = (Console.ReadLine());
            int myX = Convert.ToInt32(answer1);
            Console.Clear();

            Console.WriteLine("What is Y");
            string answer2 = (Console.ReadLine());
            int myY = Convert.ToInt32(answer2);
            Console.Clear();

            Console.WriteLine("What is Width");
            string answer3 = (Console.ReadLine());
            int myWidth = Convert.ToInt32(answer3);
            Console.Clear();

            Console.WriteLine("What is Height");
            string answer4 = (Console.ReadLine());
            int myHeight = Convert.ToInt32(answer4);
            Console.Clear();

            Rectangle myRectangle = new Rectangle(myX, myY, myWidth, myHeight);

            Console.WriteLine(myRectangle.X + " X");
            Console.WriteLine(myRectangle.Y + " Y");
            Console.WriteLine(myRectangle.Width + " Width");
            Console.WriteLine(myRectangle.Height + " Height");
        }
    }

    class Rectangle
    {
        private int x = 50;
        public int X { get { return x; } }
        private int y = 50;
        public int Y { get { return y; } }
        private int width = 50;
        public int Width { get { return width; } }
        private int height = 50;
        public int Height { get { return height; } }

        public Rectangle(int x, int y, int width, int height)
        {
            Console.WriteLine(X + " Old X");
            Console.WriteLine(Y + " Old Y");
            Console.WriteLine(Width + " Old Width");
            Console.WriteLine(Height + " Old Height");
            Console.WriteLine("-----------------------------------------------------");

            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public Rectangle(int x, int y, int size)
        {
            moveTo(x, y);
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(int size)
        {
            size = this.x * this.y;
        }

        public void moveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        }

        public bool isSquare()
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void set(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
