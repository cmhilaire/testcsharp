namespace HelloWorldApp
{
    class App
    {
        static void Main(string[] args)
        {
            Console.Write("Name : ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello : "+name);

            NewClass.Goodbye();
        }
    }
}
