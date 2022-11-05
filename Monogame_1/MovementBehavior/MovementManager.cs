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

        
        //deze klasse houd zich bezich om de bewegingen te doen en tonen =>
        public void PlayerMove(IMovable playerMovement)
        {
            var pressedKeyValue = playerMovement.inputReader.ReadInput();
            Vector2 newPosition = Vector2.Zero;

           
            //update de positie
            if (pressedKeyValue == 65 || pressedKeyValue == 68)
            {
               
                if (pressedKeyValue == 65) //dit is A
                {
                    playerMovement.currentAnimation = CurrentAnimation.Run;
                    if (playerMovement.directionMovement == SpriteEffects.None)
                    {
                        playerMovement.directionMovement = SpriteEffects.FlipHorizontally;
                    }
                    newPosition.X += playerMovement.speed;

                }
                else
                {
                    
                    playerMovement.currentAnimation = CurrentAnimation.Run;
                    if (playerMovement.directionMovement == SpriteEffects.FlipHorizontally)
                    {
                        playerMovement.directionMovement = SpriteEffects.None;
                    }
                    newPosition.X -= playerMovement.speed;

                }
            }
            else 
            {
                playerMovement.currentAnimation = CurrentAnimation.Idle;
            }
            playerMovement.position = playerMovement.position + newPosition;
            

        }


        //draw de movement ==>
        public void DrawPlayerMovement(IMovable movable, Animation[] entityArray, SpriteBatch spriteBatch, Vector2 position, GameTime gameTime)
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
