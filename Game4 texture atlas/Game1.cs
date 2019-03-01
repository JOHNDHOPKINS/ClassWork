using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Game4_texture_atlas
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private AnimatedSprite animatedSprite;
        Cube cube = new Cube();
        Cube cube2 = new Cube();
        Cube cube3 = new Cube();
        Cube cube4 = new Cube();
        private Texture2D ground;
        Texture2D Block;
        Rectangle groundHitBox;
        int num;
        int gravity=5;
        int speed = 5;
        int jumpHight = 0;

        bool jump = false;
        static int GenerateNumber()
        {

            Random rand = new Random();
            int randomNum = rand.Next(5,400);
            return randomNum;
        }
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ground = Content.Load<Texture2D>("ground");
            Block = Content.Load<Texture2D>("cube");
            Texture2D texture = Content.Load<Texture2D>("running2");
            animatedSprite = new AnimatedSprite(texture, 1, 9);




            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            num++;
            if (groundHitBox.Intersects(cube4.cubeHitBox))
            {
                num = 0;
            }


            jump = false;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (animatedSprite.hitbox.Y + 78 < 500)
            {
                animatedSprite.hitbox.Y+=gravity; 
            }
            if (animatedSprite.hitbox.Intersects(cube.cubeHitBox)|| animatedSprite.hitbox.Intersects(cube2.cubeHitBox)||animatedSprite.hitbox.Intersects(cube3.cubeHitBox) || animatedSprite.hitbox.Intersects(cube4.cubeHitBox) || animatedSprite.hitbox.Intersects(groundHitBox))
            {
                if (Keyboard.GetState().IsKeyDown(Keys.W))
                {
                    jump = true;
                    
                }
                animatedSprite.hitbox.Y -= 5;
            }   
            if (jump == true)
            {
                gravity = -5;
                gravity -=5; gravity -= 5;
                gravity -= 5; gravity -= 5;
            }
            if (jump == false)
            {
                gravity = 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
            animatedSprite.hitbox.X = animatedSprite.hitbox.X + speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                animatedSprite.hitbox.X = animatedSprite.hitbox.X - speed;
            }
            
            if (Keyboard.GetState().IsKeyDown(Keys.R))  
            {
                animatedSprite.hitbox.Inflate(1, 1);
                animatedSprite.hitbox.Y--;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.F))
            {
                animatedSprite.hitbox.Inflate(-1, -1);
                
            }
            
            
            
            // TODO: Add your update logic here

            animatedSprite.Update();
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            //(X(horizantal),Y(vertical),width,hight)

            groundHitBox = new Rectangle(0, 400, 800, 40);
            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(ground,groundHitBox, Color.White);
            spriteBatch.End();
            
            cube.Draw(Block,spriteBatch,400, 350, 25, 3);
            cube2.Draw(Block,spriteBatch, 400, 100, 50, 3);
            cube3.Draw(Block,spriteBatch, 450, 300, 50, 3);
            cube4.Draw(Block, spriteBatch, 300, num/2, 50, 3);

            animatedSprite.Draw(spriteBatch, new Vector2(200, 100));

            

            base.Draw(gameTime);
        }
    }
}
