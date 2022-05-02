namespace Basics
{
    public static class Patterns {

        // Tuple patterns
        public static void TuplePatternsDemo() {

            Random rand = new Random();

            (int, int) p = (rand.Next(2), rand.Next(2));

            switch (p)
            {
                case (0, 0):
                    Console.WriteLine($"{p.ToString()}. How original!");
                    break;

                case (0, 1):
                case (1, 0):
                    Console.WriteLine($"{p.ToString()}. What an absolute unit!");
                    break;

                case (1, 1):
                    Console.WriteLine($"{p.ToString()}. Be there and be square.");
                    break;

                default: break;
            }

        }

        // Type patterns
        public static void TypePatternsDemo() {

            Random rand = new Random();
            int next = rand.Next(2);
            string str = "This is a string.";
            int combo = 12345;

            Object o;

            if (next == 0)
                o = str;
            else
                o = combo;

            switch (o)
            {
                case string s:
                    Console.WriteLine(str);
                    break;
                case int i:
                    Console.WriteLine($"The combination is: {i}");
                    break;

                default: break;
            }

        }

        // Positional patterns
        public static void PositionalPatternsDemo() {

            Random rand = new Random();

            (int, int) pt = (rand.Next(10) - 5, rand.Next(10) - 5);

            switch (pt)
            {
                case (int x, int y):
                    Console.WriteLine($"I know where it's at: {x}, {y}");
                    break;
            }

            switch (pt)
            {
                // Mix of constant and type patterns
                case (0, int y):
                    Console.WriteLine($"This is on the x-axis, at height {y}");
                    break;

                // Discard pattern
                case (int x, _):
                    Console.WriteLine("At X: {x}. As for Y, who knows?");
                    break;
            }
        }


        public static string WhenIsDemo() {

            Random rand = new Random();

            (int, int) pt = (rand.Next(640), rand.Next(480));

            if (pt is (int x, int y))
                Console.WriteLine($"x: {x}, y: {y}");

            return pt switch
            {
                (int w, int h) when w < h => "Portrait",
                (int w, int h) when w > h => "Landscape",
                (int w, int h) when w == h => "Square",
                _ => "Unknown"
            };
        }
    }
} 