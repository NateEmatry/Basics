namespace Basics
{
    public static class Tuples {

        public static void TuplesDemo() {

            (int x, int y) pt = (3, 4);
            Console.WriteLine($"Point tuple (int x, int y): ({pt.x}, {pt.y})");

            // Default member names
            (int, int) pt2 = (1, 2);
            Console.WriteLine($"Point tuple (int, int): ({pt2.Item1}, {pt2.Item2})");

            // Structural equivalence of tuples
            (int a, int b) newpt = pt;

            // Built-in methods:
            Console.WriteLine($"A hash code of {newpt.ToString()} is: {newpt.GetHashCode()}");

            // Deconstruction
            (int first, int second) = pt;
            Console.WriteLine($"Deconstructed: first = {first}, second = {second}");

            int ptx, pty;
            (ptx, pty) = pt2;
            Console.WriteLine($"Deconstructed: ptx = {ptx}, pty = {pty}");
        }

        // Tuple as a method return type
        public static (int, int) FindMinMax(int[] input) {

            if (input is null || input.Length == 0)
            {
                throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
            }

            var min = int.MaxValue;
            var max = int.MinValue;

            foreach (var i in input)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }

            return (min, max);

        }

    }
}