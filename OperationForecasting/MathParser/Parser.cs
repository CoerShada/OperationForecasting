using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathParser
{
    abstract class Parser
    {

        public const char END_ARG = ')';
        public const char START_ARG = '(';


        public static int GetPriority(char action)
        {
            switch (action)
            {
                case '^':
                    return 4;
                case '*':
                case '/':
                    return 3;
                case '+':
                case '-':
                    return 2;
            }
            return 0;
        }

        public static bool CanMergeCells(Cell leftCell, Cell rightCell)
        {
            return GetPriority(leftCell.action) >= GetPriority(rightCell.action);
        }

        public static void MergeCells(Cell leftCell, Cell rightCell)
        {
            switch (leftCell.action)
            {
                case '^':
                    leftCell.value = Math.Pow(leftCell.value, rightCell.value);
                    break;
                case '*':
                    leftCell.value *= rightCell.value;
                    break;
                case '/':
                    leftCell.value /= rightCell.value;
                    break;
                case '+':
                    leftCell.value += rightCell.value;
                    break;
                case '-':
                    leftCell.value -= rightCell.value;
                    break;
            }
            leftCell.action = rightCell.action;
        }

        public static double Merge(Cell currentCell, ref int index, List<Cell> listToMerge, bool mergeOneOnly = false)
        {
            while (index < listToMerge.Count)
            {
                Cell nextCell = listToMerge[index++];
                while (!CanMergeCells(currentCell, nextCell))
                {
                    Merge(nextCell, ref index, listToMerge, true /*mergeOneOnly*/);
                }
                MergeCells(currentCell, nextCell);
                if (mergeOneOnly)
                {
                    return currentCell.value;
                }
            }
            return currentCell.value;
        }

        public static double LoadAndCalculate(string data, Dictionary<string, double> values)
        {

            data = data.Replace(" ", "").Replace(".", ",");
            
            int from = 0;
            for (int i = 0; i < values.Count; i++)
            {
                string name = values.Keys.ToArray()[i];
                double value = values.Values.ToArray()[i];

                while (data.Contains(name))
                {
                    data = data.Substring(0, data.IndexOf(name)) + value + data.Substring(data.IndexOf(name) + name.Length);
                }

            }
            if (data.Contains("|"))
            {
                while (true)
                {
                    data = data.Substring(1);
                    string condition = data.Substring(1, data.IndexOf("|"));

                    if (condition.Equals(""))
                    {
                        
                        data = data.Substring(data.IndexOf("|") + 1);
                        data = data.Substring(0, data.IndexOf("|") == -1 ? data.Length : data.IndexOf("|"));
                        break;

                    }
                    else
                    {
                        string tempData = data.Substring(0, data.IndexOf("|") != -1 ? data.IndexOf("|") + 1 : data.Length - 1);
                        string op = data.IndexOf("!=") != -1 ? "!=" : data.IndexOf(">=") != -1 ? ">=" : data.IndexOf("<=") != -1 ? "<=" : data.IndexOf(">") != -1 ? ">" : data.IndexOf("<") != -1 ? "<" : "=";

                        int indexSplit = tempData.IndexOf(op);
                        string condition1 = tempData.Substring(0, indexSplit);
                        int index = indexSplit + op.Length - 1;
                        string condition2 = tempData.Substring(index + 1, tempData.Length - index - 2);
                        int fromVal1 = 0;
                        int fromVal2 = 0;
                        double value1 = LoadAndCalculate(condition1, ref fromVal1);
                        double value2 = LoadAndCalculate(condition2, ref fromVal2);

                        data = data.Substring(data.IndexOf("|") + 1);

                        if ((op.Equals("!=") && notEquals(value1, value2)) || (op.Equals(">=") && largerOrEquals(value1, value2)) || (op.Equals("<=") && smallerOrEquals(value1, value2)) ||
                            (op.Equals("<") && smaller(value1, value2)) || (op.Equals(">") && larger(value1, value2)) || (op.Equals("=") && equals(value1, value2)))
                        {
                            data = data.Substring(0, data.IndexOf("|"));
                            break;
                        }
                        data = data.Substring(data.IndexOf("|"));
                    }
                }
            }
            return LoadAndCalculate(data, ref from);
        }

        internal static double LoadAndCalculate(string data, ref int from, char to = END_ARG)
        {
            if (from >= data.Length || data[from] == to)
            {
                throw new ArgumentException("Loaded invalid data: " + data);
            }

            List<Cell> listToMerge = new List<Cell>(16); //Почему 16?
            StringBuilder item = new StringBuilder();

            do
            {
                char ch = data[from++];
                if (StillCollecting(item.ToString(), ch, to))
                {
                    item.Append(ch);
                    if (from < data.Length && data[from] != to)
                    {
                        continue;
                    }
                }

                ParserFunction function = new ParserFunction(data, ref from, item.ToString(), ch);
                double value = function.GetValue(data, ref from);

                char action = ValidAction(ch) ? ch : UpdateAction(data, ref from, ch, to);
                listToMerge.Add(new Cell(value, action));
                item.Clear();

            } while (from < data.Length && data[from] != to);

            if (from < data.Length && (data[from] == END_ARG || data[from] == to))
            {
                from++;
            }

            Cell baseCell = listToMerge[0];
            int index = 1;

            return Merge(baseCell, ref index, listToMerge);
        }

        private static bool StillCollecting(string item, char ch, char to)
        {
            char stopCollecting = (to.Equals(END_ARG) || to.Equals(END_ARG)) ? END_ARG : to;

            return (item.Length == 0 && (ch.Equals('-') || ch.Equals(END_ARG)) || !(ValidAction(ch) || ch.Equals(START_ARG) || ch.Equals(stopCollecting)));
        }

        private static bool ValidAction(char ch)
        {
            return ch.Equals('*') || ch.Equals('/') || ch.Equals('+') || ch.Equals('-') || ch.Equals('^');
        }

        private static char UpdateAction(string item, ref int from, char ch, char to)
        {
            if (from >= item.Length || item[from].Equals(END_ARG) || item[from].Equals(to))
            {
                return END_ARG;
            }
            int index = from;
            char res = ch;

            while (!ValidAction(res) && index < item.Length)
            {
                res = item[index++];
            }
            from = ValidAction(res) ? index : index > from ? index - 1 : from;
            return res;
        }

        private static bool larger(double value1, double value2)
        {
            return value1 > value2;
        }

        private static bool smaller(double value1, double value2)
        {
            return value1 < value2;
        }

        private static bool equals(double value1, double value2)
        {
            return value1 == value2;
        }

        private static bool notEquals(double value1, double value2)
        {
            return value1 != value2;
        }

        private static bool smallerOrEquals(double value1, double value2)
        {
            return value1 <= value2;
        }

        private static bool largerOrEquals(double value1, double value2)
        {
            return value1 >= value2;
        }
    }
}