using Library;

namespace Program
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Greeter.Instance.SayHiToTheWorld();
        }
        */
        static void Main(string[] args)
        {
            Singleton<Greeter>.Instance.SayHiToTheWorld();
        }
    }
}
