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

        KeyboardReader PressedKeys;
        //deze klasse houd zich bezich om de bewegingen te doen =>
        public void Move(IMovable movable)
        {
            var pressedKeyValue = movable.inputReader.ReadInput();
            Vector2 newPosition = Vector2.Zero;
            //update de positie
            if (pressedKeyValue == 65 || pressedKeyValue == 68)
            {
                movable.currentAnimation = CurrentAnimation.Run;
                if (pressedKeyValue == 68)
                {
                    newPosition.X += 2;
                    
                }
                else
                {
                    newPosition.X -= 2;
                }
            }
            else 
            {
                movable.currentAnimation = CurrentAnimation.Idle;
            }
            movable.position = movable.position + newPosition;
            

        }
        public void Draw(IMovable movable, Animation[] entityArray, SpriteBatch spriteBatch, Vector2 position, GameTime gameTime)
        {
            switch (movable.currentAnimation)
            {   
                case CurrentAnimation.Idle:
                    Move(movable);
                    entityArray[0].Draw(spriteBatch, position, gameTime);
                    
                    break;
                case CurrentAnimation.Run:
                    Move(movable);
                    entityArray[1].Draw(spriteBatch, position, gameTime);
                 
                    break;
                default:
                    break;
            }
        }
    }
}
