using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF_2023
{
    public class Car:Vehicle
    {
        private string color;
        private string name;
        private int maxSpeed;
        private int year;

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }
        public Car(string nameName)
        {
            name = nameName;
        }


        public void fullThrottle()
        {
            Console.WriteLine(name + "is going at the speed of" + maxSpeed);
        }


    }
}
