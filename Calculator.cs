
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Calculator : ICalculator
    {
        public event EventHandler<OperandChangedEventArgs> GotResult;
        private Stack<double> stack = new Stack<double>();
        private double Result
        {
            get
            {
                return stack.Count() == 0 ? 0 : stack.Peek();
            }
            set
            {
                stack.Push(value);
                RaiseEvent();
            }
        }
        public void RaiseEvent()
        {
            GotResult.Invoke(this, new OperandChangedEventArgs(Result));
        }
        public void CancelLast()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                RaiseEvent();
            }
        }
        public void Divide(double numder)
        {
            try
            {
                checked
                {
                    if (numder != 0)
                    {
                        Result /= numder;
                    }
                    else
                    {
                        throw new CalculatorDivideByZeroException("Деление на ноль!!!");
                    }
                }
            }
            catch (OverflowException)
            {
                throw new CalculateOperationCauseOverflowException("Слишком большое число.");
            }
        }

        public void Multiply(double numder)
        {
            try
            {
                checked
                {
                    Result *= numder;
                }
            }
            catch (DivideByZeroException)
            {
                throw new CalculateOperationCauseOverflowException("Слишком большое число.");
            }

        }

        public void Substract(double numder)
        {
            try
            {
                checked
                {
                    Result -= numder;
                }
            }
            catch (DivideByZeroException)
            {
                throw new CalculateOperationCauseOverflowException("Слишком большое число.");
            }
        }

        public void Sum(double numder)
        {
            try
            {
                checked
                {
                    Result += numder;
                }
            }
            catch (DivideByZeroException)
            {
                throw new CalculateOperationCauseOverflowException("Слишком большое число.");
            }
        }

        public void Divide(int numder)
        {
            try
            {
                checked
                {
                    if (numder != 0)
                    {
                        Result /= numder;
                    }
                    else
                    {
                        throw new CalculatorDivideByZeroException("Деление на ноль!!!");
                    }
                }
            }
            catch (OverflowException)
            {
                throw new CalculateOperationCauseOverflowException("Слишком большое число.");
            }
        }

        public void Multiply(int numder)
        {
            try
            {
                checked
                {
                    Result *= numder;
                }
            }
            catch (DivideByZeroException)
            {
                throw new CalculateOperationCauseOverflowException("Слишком большое число.");
            }

        }

        public void Substract(int numder)
        {
            try
            {
                checked
                {
                    Result -= numder;
                }
            }
            catch (DivideByZeroException)
            {
                throw new CalculateOperationCauseOverflowException("Слишком большое число.");
            }
        }

        public void Sum(int numder)
        {
            try
            {
                checked
                {
                    Result += numder;
                }
            }
            catch (DivideByZeroException)
            {
                throw new CalculateOperationCauseOverflowException("Слишком большое число.");
            }
        }

    }
}