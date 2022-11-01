using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_1.Interfaces
{
    public interface IInputReader
    {
        //deze klasse houd zich bezig om de input te lezen
        //we lezen de input van de PLAYER -->

        Vector2 ReadInput();
  
        public bool IsDestinationInput { get; }
    }
}
