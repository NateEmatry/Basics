namespace Basics
{
    public static class Misc {

        public static string? NullString;
        public static string NotNullString = "I am not null";

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

            // Null-conditional and null-coalescing operators

            string output = NullString?? "String is null";
            int characterCount = NullString?.Length ?? 0;
            characterCount = NotNullString?.Length ?? 0;

            Console.WriteLine(output);


            Console.WriteLine("End of MiscDemo method.");
        }
    }
}