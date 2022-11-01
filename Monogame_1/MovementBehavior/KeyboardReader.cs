using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Monogame_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Monogame_1.Entity;

namespace Monogame_1.MovementSection
{
    public class KeyboardReader : IInputReader
    {
       
        public bool IsDestinationInput { get; }

        
        public Vector2 ReadInput()
        {
            KeyboardState statekey = Keyboard.GetState();
            Vector2 NewPosition = Vector2.Zero;
            //dit gaat default zijn. dus als er geen input word gegeven blijft die idle ==>
         
            if (statekey.IsKeyDown(Keys.A))
            {
                NewPosition.X -= 2;
              
            }
            else if (statekey.IsKeyDown(Keys.D))
            {
                NewPosition.X += 2;
            }
            return NewPosition;
        }
    }
}
