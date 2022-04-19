using System.Numerics;

namespace Basics
{
    public static class Types {

        public static void NumericTypesDemo() {

            #pragma warning disable CS0168  // declared but value not assigned
            #pragma warning disable CS0219  // value assigned but not used

            // INTEGER TYPES

            byte b = 1;     // Unsigned byte, 8 bits, 0 to 255      (System.Byte)
            sbyte sb = -1;   // Signed byte, 8 bits, -128 to 127     (System.SByte)
            ushort ush = 1; // Unsigned short, 16 bits, 0 to 65535  (System.UInt16)
            short sh = -1;   // Signed short, 16 bits, -32768 to 32767 (System.Int16)
            uint ui = 123U;    // Unsigned int, 32 bits, 0 to 4,294,967,295    (System.UInt32)
            int i = 1;      // Signed int, 32 bits, -2,147,483,648 to 2,147,483,647 (System.Int32)
            ulong ul = 123UL;   // Unsigned long, 64 bits, 0 to 18,446,744,073,709,551,615  (System.UInt64)
            long l = -123L;     // Signed long, 64 bits, -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (System.Int64)

            // FLOATING-POINT TYPES

            float f = 1.0F;  // 32 bits, 23-bit (7 decimal) precision, 1.5e-45 to 3.4e38   (System.Single)
            double d = 1.0D;  // 64 bits, 52-bit (15 decimal) precision, 5.0e-324 to 1.7e308 (System.Double) 

            // (System.Decimal)
            // Designed for greater precision with decimal arithmetic.
            // Represents any decimal with 28 or fewer digts accurately.
            // 128-bits: 1 sign bit, 96-bit integer, 29-bit power of 10
            decimal dc = 1.0M;

            // C# allows underscores anywhere in numeric literals.

            long worldPop = 8_234_747_919;
            int myAge = 4_2;

            Console.WriteLine($"worldPop input as 8_234_747_919, stored as {worldPop}");
            Console.WriteLine($"myAge input as 4_2, stored as {myAge}");

            // EXPONENTIAL FORMATS

            float floatExp = 1.0e10F;
            double doubleExp = 2.5e-33D;
            decimal decimalExp = 2.2e22M;

            // HEX AND BINARY

            int hexInt = 0xa5;
            int binInt = 0b_0010_1010;

            Console.WriteLine($"hexInt input as 0xa5, stored as {hexInt}");
            Console.WriteLine($"binInt input as 0b_0010_1010, stored as {binInt}");

            // To display as octal, use Convert.ToString(number, 8);
            int octInt = 10;
            Console.WriteLine($"octInt input as 10, diplayed as octal: {Convert.ToString(octInt, 8)}");

            // NUMERIC CONVERSIONS

            // Range-narrowing conversions require explicit casts.
            double convertD = 42;
            int convertInt = (int)42.0;
        }

        public static void CheckedContextDemo() {

            int big_a = 2_000_000_000;
            int big_b = 1_000_000_000;
            int big_c = big_a + big_b;


            Console.WriteLine("Unchecked: One billion plus two billion is: " + big_c);

            try {
                big_c = checked(big_a + big_b);
            }
            catch (Exception e) {
                Console.WriteLine("Checked: One billion plus two billion is: " + e);
            }  
        }

        // Copied from the book.
        public static void BigIntDemo() {

            
        }
    }
}