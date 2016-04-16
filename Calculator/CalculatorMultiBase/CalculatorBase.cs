namespace CalculatorMultiBase
{
    using System;

    public abstract class CalculatorBase : ICalculator
    {
        private long _operand2;
        private long _operand1;
        private readonly int _radix;

        protected CalculatorBase(int radix)
        {
            this._radix = radix;
        }

        public string Addition(string operand1, string operand2)
        {
            return ProcedeToOperation(operand1, operand2, Operation.Addition);
        }

        public string Substraction(string operand1, string operand2)
        {
            return ProcedeToOperation(operand1, operand2, Operation.Substraction);
        }

        public string Multiplication(string operand1, string operand2)
        {
            return ProcedeToOperation(operand1, operand2, Operation.Multiplication);
        }

        public string Division(string operand1, string operand2)
        {
            return ProcedeToOperation(operand1, operand2, Operation.Division);
        }

        private long DoAddition()
        {
            return this._operand1 + this._operand2;
        }

        private long DoSubstraction()
        {
            return this._operand1 - this._operand2;
        }

        private long DoMultiplication()
        {
            return this._operand1 * this._operand2;
        }

        private long DoDivision()
        {
            return this._operand1 / this._operand2;
        }

        private string ProcedeToOperation(string operand1, string operand2, Operation operation)
        {
            SetOperands(operand1, operand2);
            return GetOperationResult(operation);
        }

        private string GetOperationResult(Operation operation)
        {
            return ConvertBack(PerfomOperation(operation));
        }

        private long PerfomOperation(Operation operation)
        {
            switch (operation)
            {
                case Operation.Addition:
                   return DoAddition();
                case Operation.Substraction:
                    return DoSubstraction();
                case Operation.Multiplication:
                    return DoMultiplication();
                case Operation.Division:
                    return DoDivision();
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }

        private void SetOperands(string operand1, string operand2)
        {
            this._operand1 = BaseChange.ArbitraryToDecimalSystem(operand1, this._radix);
            this._operand2 = BaseChange.ArbitraryToDecimalSystem(operand2, this._radix);
        }

        private string ConvertBack(long result)
        {
            return BaseChange.DecimalToArbitrarySystem(result, this._radix);
        }

        private enum Operation
        {
            Addition,
            Substraction,
            Multiplication,
            Division
        }
    }
}
