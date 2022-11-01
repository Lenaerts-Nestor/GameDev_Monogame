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
        
        
        private Animation playeranimation;
        private MovementManager Movement;
       

        public Player(Texture2D sprite, IInputReader inputReader)
        {
            spritesheet = sprite;
            Speed = new Vector2();
            
            playeranimation = new Animation(spritesheet);
            this.inputReader = inputReader;
            Movement = new MovementManager();


        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            playeranimation.Draw(spriteBatch, this.Position, gameTime);
            //spriteBatch.Draw(spritesheet, this.position, Color.White);
        }

        public override void Update()
        {
            Movement.Move(this);
        }
        
    }
}
