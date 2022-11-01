using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_1
{
    public class Animation 
    {
        Texture2D spritesheet;
        
        int frames;
        int row = 0;
        int counter = 0;

        float TslFrame = 0;     //DEZE BETEKEND [TIJD SINDS LAATSTE FRAME]
        //ik gebruik hier width en height om elke sprite image exact te gebruiken. ik heb ze op 32px gezet bijde want de image komt met die grote en breedte
        public Animation(Texture2D spritesheet, float width = 32, float height= 32)
        {
            this.spritesheet = spritesheet;
            frames = (int)(spritesheet.Width / width);
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 position, GameTime gameTime, float miliSecPerFrame= 150)
        {
            if (counter < frames)
            {
                //deze null naast counter is de ROWS als je een sheet hebt
                var rect = new Rectangle(32 * counter, row, 32, 32);
                spriteBatch.Draw(spritesheet, position, rect, Color.White);
                TslFrame += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

                if (TslFrame > miliSecPerFrame)
                {
                    TslFrame -= miliSecPerFrame;
                    counter++;
                    if (counter == frames)
                    {
                        counter = 0;
                    }
                }
            }
           
        }

    }
}
