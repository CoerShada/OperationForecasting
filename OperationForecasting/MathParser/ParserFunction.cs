using System;
using System.Collections.Generic;

namespace MathParser
{
    internal class ParserFunction
    {
        private static Dictionary<string, ParserFunction> m_functions = new Dictionary<string, ParserFunction>();
        private ParserFunction m_impl;
        private static IdentityFunction s_idFunction = new IdentityFunction();
        private static StrtodFunction s_strtodFunction = new StrtodFunction();

        public ParserFunction()
        {
            m_impl = this;
        }

        internal ParserFunction(string data, ref int from, string item, char ch)
        {
            if (item.Length == 0 && ch == Parser.START_ARG)
            {
                m_impl = s_idFunction;
                return;
            }

            if (m_functions.TryGetValue(item, out m_impl))
            {
                return;
            }

            // Функция не найдена, попытаемся разобрать это как число
            s_strtodFunction.Item = item;
            m_impl = s_strtodFunction;
            ParserFunction.AddFunction("pi", new PiFunction());
            ParserFunction.AddFunction("exp", new ExpFunction());
            ParserFunction.AddFunction("pow", new PowFunction());
        }

        public static void AddFunction(string name, ParserFunction function)
        {
            m_functions[name] = function;
        }

        public double GetValue(string data, ref int from)
        {
            return m_impl.Evaluate(data, ref from);
        }

        protected virtual double Evaluate(string data, ref int from)
        {
            return 0;
        }

        class IdentityFunction : ParserFunction
        {
            protected override double Evaluate(string data, ref int from)
            {
                return Parser.LoadAndCalculate(data, ref from, Parser.END_ARG);
            }
        }

        class StrtodFunction : ParserFunction
        {
            protected override double Evaluate(string data, ref int from)
            {
                decimal num;
                Decimal.TryParse(Item, out num);
                
                return Convert.ToDouble(num);
            }
            public string Item { private get; set; }
        }

        class PiFunction : ParserFunction
        {
            protected override double Evaluate(string data, ref int from)
            {
                return Math.PI;
            }
        }

        class ExpFunction : ParserFunction
        {
            protected override double Evaluate(string data, ref int from)
            {
                double arg = Parser.LoadAndCalculate(data, ref from, Parser.END_ARG);
                return Math.Exp(arg);
            }
        }

        class PowFunction : ParserFunction
        {
            protected override double Evaluate(string data, ref int from)
            {
                double arg1 = Parser.LoadAndCalculate(data, ref from, ',');
                double arg2 = Parser.LoadAndCalculate(data, ref from, Parser.END_ARG);
                return Math.Pow(arg1, arg2);
            }
        }
    }
}
