namespace TeamWpfCalc.Logic
{
    public class CalculatorCore
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0) throw new System.DivideByZeroException();
            return a / b;
        }
    }
}