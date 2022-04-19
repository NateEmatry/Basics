namespace Basics
{
    namespace NestedNamespace
    {
        public static class NestedClass {

            static readonly string msg = "This is a class in a nested namespace.";

            public static void PrintMessage() {

                Console.WriteLine(msg);
            }
        }
    }
}