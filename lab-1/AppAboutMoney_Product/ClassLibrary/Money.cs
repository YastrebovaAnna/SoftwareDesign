namespace ClassLibrary
{
    public class Money : IMoney
    {
        public int WholePart { get; private set; }
        public int FractionalPart { get; private set; }
        public string CurrencyCode { get; set; }

        public Money(int wholePart, int fractionalPart)
        {
            SetMoneyValue(wholePart, fractionalPart);
        }

        private void ValidateAmount(int wholePart, int fractionalPart)
        {
            if (wholePart < 0 || fractionalPart < 0 || fractionalPart >= 100)
            {
                throw new ArgumentException("Whole part must be non-negative and fractional part must be between 0 and 99.");
            }
        }

        private void SetMoneyValue(int wholePart, int fractionalPart)
        {
            ValidateAmount(wholePart, fractionalPart);
            this.WholePart = wholePart + fractionalPart / 100;
            this.FractionalPart = fractionalPart % 100;
        }

        public void ChangeValue(int whole, int fractional)
        {
            int newWholePart = this.WholePart + whole;
            int newFractionalPart = this.FractionalPart + fractional;
            if (newFractionalPart >= 100 || newFractionalPart < 0)
            {
                newWholePart += newFractionalPart / 100;
                newFractionalPart %= 100;
            }
            if (newFractionalPart < 0)
            {
                newWholePart -= 1;
                newFractionalPart += 100;
            }

            SetMoneyValue(newWholePart, newFractionalPart);
        }
    }
}
