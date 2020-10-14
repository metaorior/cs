using System;


namespace forLoop {
    class Program{
        static void Main() {
             int[] numbers = {1,2,3,4,5,6,7,8};
            // int uint float double string varchar 

            for (var i = 0; i < numbers.Length; i++) {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}