using System;

namespace classes {
    class Car {

        string color = "red";

        string marca = "GM";

        double price = 36.500;
        static void Main() {
            Console.WriteLine("Classes review\n");
            carroAzul();
        }

        static void carroAzul() {
            Car carroAzul = new Car();
            Console.WriteLine("A marca do carro é: " + carroAzul.marca);
        }
    }
}