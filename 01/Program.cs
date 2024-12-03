namespace _01
{


    //////using MyCollections = _03.MyDictionary;

    using _03;

    class Program
    {
        public static void Main()
        {


            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "zero");
            myDictionary.Add(1, "one");
            myDictionary.Add(2, "two");
            myDictionary.Add(3, "three");

            foreach (string a in myDictionary)
                Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}