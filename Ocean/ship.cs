using System;

namespace Ocean
{
    internal class Ship
    {
        public Angle Latitude;
        public Angle Longitude;
        public string Number;

        public Ship(Angle latitude, Angle longitude, string number)
        {
            Latitude = latitude;
            Longitude = longitude;
            Number = number;
        }

        public void PrintPosition()
        {
            Console.WriteLine("Ship is at Latitude: {0} and Longitude: {1}", Latitude.DisplayAngle(), Longitude.DisplayAngle());
        }
    }
}
