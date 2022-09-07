using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeWF
{
    internal class MyObjects
    {
        public enum MazeObjectType { HALL, WALL, MEDAL, ENEMY, CHAR, HEAL };

        public Bitmap[] images = {new Bitmap(@"C:\Users\1lexaa\source\repos\MazeWF\MazeWF\bin\Debug\net6.0-windows\Resources\hall.png"),
            new Bitmap(@"C:\Users\1lexaa\source\repos\MazeWF\MazeWF\bin\Debug\net6.0-windows\Resources\wall.png"),
            new Bitmap(@"C:\Users\1lexaa\source\repos\MazeWF\MazeWF\bin\Debug\net6.0-windows\Resources\medal.png"),
            new Bitmap(@"C:\Users\1lexaa\source\repos\MazeWF\MazeWF\bin\Debug\net6.0-windows\Resources\enemy.png"),
            new Bitmap(@"C:\Users\1lexaa\source\repos\MazeWF\MazeWF\bin\Debug\net6.0-windows\Resources\player.png"),
            new Bitmap(@"C:\Users\1lexaa\source\repos\MazeWF\MazeWF\bin\Debug\net6.0-windows\Resources\aidkit.png")};

        public MazeObjectType type;
        public int width;
        public int height;
        public Image texture;

        public MyObjects(MazeObjectType type)
        {
            this.type = type;
            width = 16;
            height = 16;
            texture = images[(int)type];
        }
    }
}
