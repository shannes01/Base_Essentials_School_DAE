namespace Essentials
{
    internal class Calculator
    {
        public static string CalculateToString(int a, int b, string op)
        {
            switch (op)
            {
                case "+": return (a + b).ToString();
                case "-": return (a - b).ToString();
                case "*": return (a * b).ToString();
                case "/": return b == 0 ? "Unable to divide by zero" : (a / (double)b).ToString();
                default: return $"Unknown operator '{op}'";
            }
        }

        public static string CalculateToString(double a, double b, string op)
        {
            switch (op)
            {
                case "+": return (a + b).ToString();
                case "-": return (a - b).ToString();
                case "*": return (a * b).ToString();
                case "/": return b == 0 ? "Unable to divide by zero" : (a / b).ToString();
                default: return $"Unknown operator '{op}'";
            }
        }

        public static string CalculateToString(string a, string b, string op)
        {
            if (!double.TryParse(a, out var da) || !double.TryParse(b, out var db))
            {
                return $"Unable to parse operands '{a}' or '{b}'";
            }

            switch (op)
            {
                case "+": return (da + db).ToString();
                case "-": return (da - db).ToString();
                case "*": return (da * db).ToString();
                case "/": return db == 0 ? "Unable to divide by zero" : (da / db).ToString();
                default: return $"Unknown operator '{op}'";
            }
        }
        public static int CalculateToInt(int a, int b, string op)
        {
            switch (op)
            {
                case "+": return (a + b);
                case "-": return (a - b);
                case "*": return (a * b);
                case "/":
                    if (b == 0)
                    {
                        throw new Exception("unable to divide by zero");
                    }
                    return (a / b);
                default: throw new Exception($"Unknown operator '{op}'");
            }
        }
        public static int CalculateToInt(string a, string b, string op)
        {
            if (!int.TryParse(a, out var ia) || !int.TryParse(b, out var ib))
            {
                throw new Exception($"Unable to parse operands '{a}' or '{b}'");
            }

            switch (op)
            {
                case "+": return (ia + ib);
                case "-": return (ia - ib);
                case "*": return (ia * ib);
                case "/":
                    if (ib == 0)
                    {
                        throw new Exception("unable to divide by zero");
                    }
                    return ia / ib;
                default: throw new Exception($"Unknown operator '{op}'");
            }
        }

        public static double CalculateToDouble(int a, int b, string op)
        {
            switch (op)
            {
                case "+": return (a + b);
                case "-": return (a - b);
                case "*": return (a * b);
                case "/":
                    if (b == 0)
                    {
                        throw new Exception("unable to divide by zero");
                    }
                    return (double)a / b;
                default: throw new Exception($"Unknown operator '{op}'");
            }
        }

        public static float CalculateToFloat(int a, int b, string op)
        {
            switch (op)
            {
                case "+": return (a + b);
                case "-": return (a - b);
                case "*": return (a * b);
                case "/":
                    if (b == 0)
                    {
                        throw new Exception("unable to divide by zero");
                    }
                    return (float)a / b;
                default: throw new Exception($"Unknown operator '{op}'");
            }
        }

        public static float CalculateSquare(float a, int root = 2)
        {
            return (float)Math.Pow(a, root);
        }
        public static float CalculateSquare(string a, int root = 2)
        {
            if (!float.TryParse(a, out var fa))
            {
                throw new Exception($"Unable to parse operand '{fa}'");
            }
            return (float)Math.Pow(fa, root);
        }

        public static float CalculateSquare(string a, string root = "2")
        {
            if (!float.TryParse(a, out var fa))
            {
                throw new Exception($"Unable to parse operand '{fa}'");
            }
            if (!int.TryParse(root, out var iroot))
            {
                throw new Exception($"Unable to parse root '{root}'");
            }
            return (float)Math.Pow(fa, iroot);
        }
    }
}