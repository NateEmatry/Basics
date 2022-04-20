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

        public static void StringBuilderDemo() {

            
        }


        
    }
}