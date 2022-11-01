using Microsoft.Xna.Framework;
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
        public void Move(IMovable movable)
        {
            var newPosition = movable.inputReader.ReadInput();
            //update de positie
            movable.Position = movable.Position + newPosition;

        }
        public void Draw(Player movable)
        {
           
        }
    }
}
