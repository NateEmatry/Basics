namespace Basics
{
    public static class Misc {

        public static void MiscDemo() {

            /*  The "dynamic" type is presented to the runtime as an object.
                The compiler will not know if attempted operations will be successful.
                (Don't use this.)
            */
            dynamic dyn = 3.33;
            float fl = 3.33f;
            Console.WriteLine("Dynamic: 3.33");
            Console.WriteLine($"ToString(): {dyn.ToString()}");
            Console.WriteLine($"GetHashCode(): {dyn.GetHashCode()}");
            Console.WriteLine($"Equals 3.33f: {dyn.Equals(fl)}");

            // Compiles, but throws exception at runtime
            try {
                Console.WriteLine($"NotARealMethod(): {dyn.NotARealMethod()}");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            Console.WriteLine("End of MiscDemo method.");
        }
    }
}