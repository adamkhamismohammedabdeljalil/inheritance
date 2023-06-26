namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //instantiate Dog class
            Dog dog = new Dog();
            dog.Name = "Jargass";
            dog.Speak();

            //instantiate Snake class
            Snake snake = new Snake();
            snake.Name = "Randy";
            snake.Speak();
        }
    }
}