using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Fish
    {
        public Fish()
        {
        }

        public void setup()
        {
        }
    

        public void update()
        { 

        }
        void DrawFish(float x, float y, Color fishColor)
        {
            int height = 30;

            // offset to center the origin
            Vector2 offset = new Vector2(-30, -height);

            // draw the tail of the fish


            Draw.Triangle(
                new Vector2(x - 35, y),
                new Vector2(x - 85, y - 35),
                new Vector2(x - 85, y + 35)
            );

            // draw the top fin
            Draw.Triangle(
                new Vector2(x - 20, y - 15),
                new Vector2(x, y - 65),
                new Vector2(x + 25, y - 15)
            );

            // draw the bottom fin
            Draw.Triangle(
                new Vector2(x - 10, y + 15),
                new Vector2(x + 10, y + 55),
                new Vector2(x + 30, y + 15)
            );

            // draw the body of the fish
            Draw.LineSize = 0;
            Draw.FillColor = fishColor;

            Vector2 topRectPosition = new Vector2(x, y);
            topRectPosition += offset;

            Vector2 topRectSize = new Vector2(60, height);
            Draw.Rectangle(topRectPosition, topRectSize);

            Vector2 bottomRectPosition = new Vector2(x, y + height);
            bottomRectPosition += offset;

            Vector2 bottomRectSize = new Vector2(60, height);
            Draw.Rectangle(bottomRectPosition, bottomRectSize);

            // round out the fish body
            Draw.Circle(new Vector2(x - 30, y), 30);
            Draw.Circle(new Vector2(x + 30, y), 30);
            Draw.Rectangle(
                new Vector2(x - 30, y - 30),
                new Vector2(60, 60)
            );

            // draw the white belly
            Draw.FillColor = Color.White;

            Draw.Rectangle(
                new Vector2(x - 20, y + 12),
                new Vector2(55, 10)
            );

            // draw the side fin
            Draw.FillColor = fishColor;

            Draw.Triangle(
                new Vector2(x - 5, y),
                new Vector2(x - 20, y + 35),
                new Vector2(x + 20, y + 10)
            );

            // draw the fish eye
            float eyeRadius = 8f;
            float eyeOffset = 35f;
            float heightOffset = 10f;

            Draw.FillColor = Color.White;

            Vector2 eyeCirclePos = new Vector2(x, y);
            eyeCirclePos.X += eyeOffset;
            eyeCirclePos.Y -= heightOffset;

            Draw.Circle(eyeCirclePos, eyeRadius);

            // draw the pupl of eye
            Draw.FillColor = Color.Black;
            Draw.Circle(eyeCirclePos, 4f);

            // draw the mouth
            Draw.FillColor = Color.Black;
            Draw.Rectangle(
                new Vector2(x + 48, y + 10),
                new Vector2(10, 3)
            );
        }
    }
}



