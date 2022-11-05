using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Monogame_1.Interfaces;
using SharpDX.Direct3D9;
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
        public int ReadInput()
        {
            KeyboardState statekey = Keyboard.GetState();
            
            if (statekey.IsKeyDown(Keys.A))
            {
                //TODO: vind een bbetere manier om de input te lezen
                return 65;
                
            }
            else if (statekey.IsKeyDown(Keys.D))
            {
                return 68;
            }
            else
            {
                return -1;
            }
            
        }

       
    }
}
