using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_1.Interfaces;
using Monogame_1.MovementSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_1.MovementBehavior
{
    public class MovementManager
    {

        
        //deze klasse houd zich bezich om de bewegingen te doen =>
        
       
        public void PlayerMove(IMovable movable)
        {
            var pressedKeyValue = movable.inputReader.ReadInput();
            Vector2 newPosition = Vector2.Zero;

           
            //update de positie
            if (pressedKeyValue == 65 || pressedKeyValue == 68)
            {
               
                if (pressedKeyValue == 65) //dit is A
                {
                    movable.currentAnimation = CurrentAnimation.Run;
                    if (movable.directionMovement == SpriteEffects.None)
                    {
                        movable.directionMovement = SpriteEffects.FlipHorizontally;
                    }
                    newPosition.X += movable.speed;

                }
                else
                {
                    
                    movable.currentAnimation = CurrentAnimation.Run;
                    if (movable.directionMovement == SpriteEffects.FlipHorizontally)
                    {
                        movable.directionMovement = SpriteEffects.None;
                    }
                    newPosition.X -= movable.speed;

                }
            }
            else 
            {
                movable.currentAnimation = CurrentAnimation.Idle;
            }
            movable.position = movable.position + newPosition;
            

        }


        //draw de movement ==>
        public void Draw(IMovable movable, Animation[] entityArray, SpriteBatch spriteBatch, Vector2 position, GameTime gameTime)
        {
            switch (movable.currentAnimation)
            {   
                case CurrentAnimation.Idle:
                    PlayerMove(movable);
                    entityArray[0].Draw(spriteBatch, position, gameTime, movable.directionMovement);
                    
                    break;
                case CurrentAnimation.Run:
                    PlayerMove(movable);
                    entityArray[1].Draw(spriteBatch, position, gameTime, movable.directionMovement);
                 
                    break;
                default:
                    break;
            }
        }
    }
}
