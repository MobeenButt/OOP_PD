using System;

namespace Ocean
{
    internal class Angle
    {
        public int Degrees;
        public float Minutes;
        public char Direction;

        public Angle(int degrees, float minutes, char direction)
        {
            Degrees = degrees;
            Minutes = minutes;
            Direction = direction;
        }

        public void ChangeAngle(int deg, float min, char dir)
        {
            Degrees = deg;
            Direction = dir;
            Minutes = min;
        }

        public string DisplayAngle()
        {
            return $"{Degrees} \u00b0 {Direction} {Minutes}";
        }
    }
}
