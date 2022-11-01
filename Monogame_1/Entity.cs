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
        
        
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public IInputReader inputReader { get; set; }

        public abstract void Update();
        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}
