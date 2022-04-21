using System.Text;

namespace Basics
{
    public static class StringsDemo {

        // A string is a sequence of chars.    (System.String)
        // A char is a 16-bit value representing one UTF-16 code unit. (System.Char)

        public static void CharsDemo() {

            char[] chars = { 'c', 'a', 'f', (char)0x00e9, 's' };
            string text = new string(chars);

            // Designate a verbatim string with @
            // This avoids complications with escape characters.
            Console.WriteLine(@"Char array is 'c', 'a', 'f', (char)0x00e9, 's'.");

            Console.WriteLine($"Initial text is {text}.");

            for (int i = 0; i <= chars.Length / 2; ++i)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length - (i + 1)];
                chars[chars.Length - (i + 1)] = temp;
            }

            string reversed = new string(chars);

            Console.WriteLine($"Reversed text is {reversed}.");

        }

        /*
            Since strings are immutable, a StringBuilder should be used
            when a large number of operations on a string are required.
         */
        public static void StringBuilderDemo() {

            int capacity = 1000;
            int maxCapacity = 2000;

            StringBuilder sb = new StringBuilder(capacity);
            Console.WriteLine($"Created a new StringBuilder with capacity {capacity}");

            sb = new StringBuilder(capacity, maxCapacity);
            Console.WriteLine($"Created a new StringBuilder with starting capacity {sb.Capacity}"
                + $" and maximum capacity {sb.MaxCapacity}");

            sb = new StringBuilder();
            Console.WriteLine($"Created a new StringBuilder with default starting capacity {sb.Capacity}"
                + $" and default max capacity {sb.MaxCapacity}");


            
            sb.EnsureCapacity(20000);
            Console.WriteLine($"Capacity {sb.MaxCapacity} is at least 20,000.");

            string phrase = "Apple";

            sb = new StringBuilder(phrase);
            Console.WriteLine($"Created a new StringBuilder from starting phrase \"{sb.ToString()}\"");

            sb.Append(", Banana");
            Console.WriteLine($"Appended: \"{sb.ToString()}\"");

            string[] crops = {"", "Cucumber", "Durian", "Eggplant", "Fig"};

            sb.AppendJoin(", ", crops);
            Console.WriteLine($"Append-joined: {sb.ToString()}");


            sb.Replace("Durian", "Dandelion");
            Console.WriteLine($"Replacement: {sb.ToString()}");

            sb.Remove(sb.ToString().IndexOf("Cucumber"), "Cucumber, ".Length);
            Console.WriteLine($"Removed \"Cucumber\": {sb.ToString()}");

            sb.Insert(sb.ToString().IndexOf("Dandelion"), "Cauliflower, ");
            Console.WriteLine($"Inserted \"Cauliflower\": {sb.ToString()}");

            sb.AppendLine();
            sb.AppendLine("Adding a line.");
            Console.WriteLine($"Append line: {sb.ToString()}");

            sb.Clear();
            Console.WriteLine($"Cleared StringBuilder: \"{sb.ToString()}\"");

        }


        
    }
}