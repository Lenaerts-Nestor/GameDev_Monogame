using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Monogame_1.Interfaces;

namespace Monogame_1
{
    //ik doe het elke entiteit heeft het volgende =>
    //we veronderst
    public abstract class Entity : IMovable
    {
        public Texture2D spritesheet;
        
        
        public Vector2 position { get; set; }
        public int speed { get; set; }
        public IInputReader inputReader { get; set; }
        public CurrentAnimation currentAnimation { get; set; }
        public SpriteEffects directionMovement { get; set; } = SpriteEffects.None;

        public abstract void Update();
        public abstract void Draw(SpriteBatch spriteBatchIdle, GameTime gameTime);



       
         
         
      
    }
}
