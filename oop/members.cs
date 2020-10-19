using System;

namespace members {

    class Car {
        string color = "blue";
        int maxSpeed = 500;

        static void fullThrottle() {
            Console.WriteLine("The car is going as fast as it can ");
             Car myObj = new Car();
            Console.WriteLine("The car is going on " + myObj.maxSpeed + "and its color is " + myObj.color);
        }

        static void Main(string[]args) {
           fullThrottle();

        }
    }
}