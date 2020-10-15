using System;

 namespace Main{
    class first{
       static void Main() {
            Console.WriteLine("Hello World");

            //type your username and press enter
            Console.WriteLine("Enter username: ");

            //create a string variable get user input from the keyboard and store in the variable
            string userName = Console.ReadLine();

            //print the variable
            Console.WriteLine("Username is: " +userName);            

            //try to read an int will give error because readLine only reads strings
            // but we can convert
            Console.WriteLine("Please enter a number");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you entered is " + number);


          

        }
    }
}