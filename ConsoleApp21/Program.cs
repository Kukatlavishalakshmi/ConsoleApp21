using System;
using System;
namespace AccessSpecifiers
{
    class PublicTest
    {
        public string name = "vishu kukatla";
        public void Msg(string msg)
        {
            Console.WriteLine("hi " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicTest publicTest = new PublicTest();
            // Accessing public variable  
            Console.WriteLine("hi " + publicTest.name);
            // Accessing public function  
            publicTest.Msg("chinni");
            Console.ReadLine();
        }
    }
}
