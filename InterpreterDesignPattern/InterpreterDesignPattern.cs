using System;
using System.Collections.Generic;

namespace InterpreterDesignPattern
{
    class Program
    {
        static void Main(String[] args)
        {
            Calculator calculator = new Calculator();
            String expression = "1+2+3+4+5-1-2-3";
            calculator.parse(expression);
            Console.WriteLine(expression + "=" + calculator.calculate());
            Console.ReadKey();
        }
    }
    public interface IExpression
    {
        int interpret();
    }
    //终结符
    public class ValueExpression : IExpression
    {
        private int value;

        public ValueExpression(int value)
        {
            this.value = value;
        }
        public int interpret()
        {
            return value;
        }
    }
    //非终结符
    public class AddExpression : IExpression
    {
        private IExpression left;
        private IExpression right;

        public AddExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public int interpret()
        {
            return left.interpret() + right.interpret();
        }
    }
    //非终结符
    public class SubtractionExpression : IExpression
    {
        private IExpression left;
        private IExpression right;

        public SubtractionExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public int interpret()
        {
            return left.interpret() - right.interpret();
        }
    }
    // Context 
    public class Calculator
    {
        private IExpression Expression = null;

        public void parse(string expression)
        {
            char[] expressionArray = expression.ToCharArray();
            Stack<IExpression> stack = new Stack<IExpression>();
            for (int i = 0; i < expressionArray.Length; i++)
            {;
                if ("+".Equals(expressionArray[i].ToString()))
                {
                    IExpression left = stack.Pop();
                    IExpression right = new ValueExpression(Convert.ToInt32(expressionArray[++i].ToString()));
                    stack.Push(new AddExpression(left, right));

                }
                else if ("-".Equals(expressionArray[i].ToString()))
                {
                    IExpression left = stack.Pop();
                    IExpression right = new ValueExpression(Convert.ToInt32(expressionArray[++i].ToString()));
                    stack.Push(new SubtractionExpression(left, right));
                }
                else
                {
                    stack.Push(new ValueExpression(Convert.ToInt32(expressionArray[i].ToString())));
                }

            }
            this.Expression = stack.Pop();
        }

        public int calculate()
        {
            return Expression.interpret();
        }
    }
}