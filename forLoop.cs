using System;


namespace forLoop {
    class Program{
        static void Main() {
             int[] numbers = {1,2,3,4,5,6,7,8};
            // int uint float double string varchar 

            for (var i = 0; i < numbers.Length; i++) {
                Console.WriteLine(numbers[i]);
            }

            // Sort() functions sorts the array in alphabetic order
            string[] nomes = {"joao", "caio", "banana", "antonio"};

            for (var i = 0; i < nomes.Length; i++) {
            Array.Sort(nomes);

            Console.WriteLine(nomes[i]);
            }
        }




    }
}