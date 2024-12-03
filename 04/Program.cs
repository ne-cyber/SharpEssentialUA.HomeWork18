
namespace MyNamespace
{

    // Имена пространства імен співпадають. Можна без "using MyNamespace;" Так можна навіть з зовнішньою програмою :)
    //using MyNamespace;

    class Program
    {

        public static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.a = 111;
            myClass.str = "Hello";


            Console.WriteLine("Hello world!!!");
        }


    }

}