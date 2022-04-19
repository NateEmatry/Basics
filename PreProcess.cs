#define DEBUG
#define ERR_NOT
// #define ERR

namespace Basics
{
    public static class PreProcessor {

        public static void TestDebug() {

            #if DEBUG
                Console.WriteLine("Debug mode");
            #else
                Console.WriteLine("Production mode");
            #endif


            #if ERR
                // A way to make your own compiler error
                #error I told you not to make an error!
            #endif

            // Tells the compiler to report errors at this location
            #line 666 "Sith.cs"
            // #error Wipe them out.

            #line hidden
            // Anything in there will be skipped by the debugger when stepping through code.
            #line default

            /* The #pragma directive provides two features: it can be used to disable selected
                compiler warnings, and it can also be used to override the checksum values the
                compiler puts into the .pdb file it generates containing debug information.

                Both of these are designed primarily for code generation scenarios.
            */

            #pragma warning disable CS0168  // (declared variable not used)
            int a;

            // Warnings from code analyzers can also be disabled.

            // To disable warnings about nullable references:
            #pragma warning disable nullable

            // Allows fine-grained control of the nullable annotation context
            #nullable disable
            #nullable enable
            #nullable restore
            
            // These directives do nothing and are meant for text editors designed
            // to recognize them, e.g. to collapse sections.
            #region
                int x = 3;
                int y = 4;
                string str = $"{x} + {y} = {x + y}.";
                Console.WriteLine(str);
            #endregion
        }


    }
}