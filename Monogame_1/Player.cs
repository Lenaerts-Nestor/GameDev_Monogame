using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_1.Interfaces;
using Monogame_1.MovementBehavior;
using System;

namespace Monogame_1
{
    public class Player : Entity , IMovable
    {
        
        
        private Animation[] playeranimation;
        private MovementManager Movement;
        public CurrentAnimation currentAnimation;

        public Player(Texture2D spriteIdle, Texture2D spriteRun, IInputReader inputReader  )
        {
            spritesheet = spriteIdle;
            speed = 2;
          

            playeranimation = new Animation[2];
            playeranimation[0] = new Animation(spriteIdle);
            playeranimation[1] = new Animation(spriteRun);

            this.inputReader = inputReader;
            Movement = new MovementManager();


        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            Movement.DrawPlayerMovement(this, playeranimation, spriteBatch, position,gameTime);
            //playeranimation.Draw(spriteBatch, this.position, gameTime);
            //spriteBatch.Draw(spritesheet, this.position, Color.White);
        }

        public override void Update()
        {
            Movement.PlayerMove(this);
            
        }

        public void DrawMovement()
        {
            
        }
        
    }
}
