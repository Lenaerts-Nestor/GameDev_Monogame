using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_1.Interfaces
{
    public enum CurrentAnimation { Idle, Run}
    public interface IMovable
    {
        public Vector2 position { get; set; }
        public int speed { get; set; }
        public IInputReader inputReader { get; set; }

        public CurrentAnimation currentAnimation { get; set; }


    }
}
