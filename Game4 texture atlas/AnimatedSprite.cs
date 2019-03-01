using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Timers;

namespace Game4_texture_atlas
{
    public class AnimatedSprite
    {
        
        public Texture2D Texture { get; set; }
        public Rectangle hitbox;
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        public int i = 0;
        public AnimatedSprite(Texture2D texture, int rows, int columns)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;
            hitbox = new Rectangle(200, 200, 30,40);//position and size
        }
        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D)|| Keyboard.GetState().IsKeyDown(Keys.A))//right
            {
                currentFrame = currentFrame % 4;
                
                if (i >= 4)
                {
                    currentFrame++;
                    if (currentFrame >= 4)
                        currentFrame = 0;
                    i = 0;
                }
                i++;
            }
            
            else//standing still
            {
                currentFrame = 8;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))//left
            {
               
                currentFrame += 4;

            }
                
        }
        public void Draw(SpriteBatch spriteBatch,Vector2 location)
        {
            int width = 0;
            int height = 0;
            int row = 0;
            int column = 0;
          
               
                width = Texture.Width / Columns;
                height = Texture.Height / Rows;
                row = (int)((float)currentFrame / (float)Columns);
                column = currentFrame % Columns;
            


            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            //Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, hitbox, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
