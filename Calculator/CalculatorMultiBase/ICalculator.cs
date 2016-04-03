namespace CalculatorMultiBase
{
    public interface ICalculator
    {
        string Addition(string operand1, string operand2);
        string Substraction(string operand1, string operand2);
        string Multiplication(string operand1, string operand2);
        string Division(string operand1, string operand2);
    }
}