namespace ScreenSound.Models
{
    internal class Evaluation
    {
        public Evaluation(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public static Evaluation Parse(string value)
        {
            int parsedValue;
            try { parsedValue = int.Parse(value); } catch { parsedValue = 0; }
            return new Evaluation(parsedValue);
        }
    }
}