namespace MathParser
{
    internal class Cell
    {
        internal double value;
        internal char action;

        internal Cell(double value, char action)
        {
            this.value = value;
            this.action = action;
        }
    }
}
