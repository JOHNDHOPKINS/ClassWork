using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game4_texture_atlas
{
    public class Cube
    {
        public Rectangle cubeHitBox;
        public Texture2D Block { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Hight { get; set; }
        public Cube()
        {
            X = 0;
            Y = 0;
            Width = 0;
            Hight = 0;
        }
        public void Draw(Texture2D block,SpriteBatch spriteBatch,int X,int Y, int Width,int Hight)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Hight = Hight;
            Block = block;
            cubeHitBox = new Rectangle(X,Y,Width,Hight);
            spriteBatch.Begin();
            spriteBatch.Draw( Block, cubeHitBox, Color.White);
            spriteBatch.End();
        }
    }
}
