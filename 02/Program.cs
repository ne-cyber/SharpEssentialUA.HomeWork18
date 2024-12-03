namespace MyNamespace
{

    using _02_Zovnishnia;


    class DirevedClass : Class
    {
        public void Method()
        {
            this.a = 111;
            this.str = "Hello";

            this.b = 222;
            this.str2 = "Hello";
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Class @class = new Class();

            // internal protected - члени доступні тільки в похідному класі
            //@class.a = 222;
            //@class.str = "Hello";

            @class.b = 222;
            @class.str2 = "Hello";


        }
    }
}