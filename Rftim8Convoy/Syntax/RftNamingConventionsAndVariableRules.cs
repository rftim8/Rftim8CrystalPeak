namespace Rftim8Convoy.Syntax
{
    public class RftNamingConventionsAndVariableRules
    {
        public RftNamingConventionsAndVariableRules()
        {
            int func = 0;
            switch (func)
            {
                case 0:
                    NamingConventions();
                    break;
                case 1:
                    VariableRules();
                    break;
                default:
                    break;
            }
        }
        private static void NamingConventions()
        {
        }

        // PascalCase
        private readonly int PascalCaseVariable = 0;

        private static void PascalCaseMethod() { }

        class PascalCaseClass { }

        interface IPascalCaseInterface { }

        enum PascalCaseEnum { }

        delegate void PascalCaseDelegate();

        // camelCase
        private readonly int camelCaseVariable = 0;
        private static void CamelCaseMethod() { }

        // UPPER_CASE
        private const int UPPER_CASE_CONSTANT = 0;

        // _underscorePrefix
        private readonly int _underscorePrefixVariable = 0;

        // m_underscorePrefix for member variables
        class ExampleClass
        {
            private readonly int m_memberVariable = 0;
        }

        // Avoid Hungarian notation
        private readonly int count = 0; // Not: int iCount = 0;
                                        // Use meaningful names
        readonly int numberOfItems = 0; // Not: int n = 0;

        readonly DateTime creationTime = DateTime.Now;
        
        private static void VariableRules()
        {
            // Avoid single-character names except for loop counters
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            // Declaration and initialization
            int x = 10;
            Console.WriteLine(x);

            string name = "Rftim8";
            Console.WriteLine(name);
            // Implicit typing with var
            int y = 20; // y is inferred as int
            Console.WriteLine(y);


            string message = "Hello, World!"; // message is inferred as string Constants
            Console.WriteLine(message);

            const double Pi = 3.14159;
            Console.WriteLine(Pi);

            // Readonly fields (can be assigned in constructor)
            // Nullable types
            int? nullableInt = null;

            Console.WriteLine(nullableInt.HasValue ? $"Value: {nullableInt.Value}" : "No value assigned.");
            
            // Scope of variables
            {
                int scopedVariable = 5;
                Console.WriteLine(scopedVariable);
            }
            // scopedVariable is not accessible here
            // Variable naming rules
            // Valid
        }
    }
}