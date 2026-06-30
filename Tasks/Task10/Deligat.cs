namespace C__TaskPractice.Tasks.Task10
{
    public class PriceProcessor
    {
        public decimal[] ApplyTax(decimal[] prices, Func<decimal, decimal> taxFunction)
        {
            if (prices == null || taxFunction == null)
            {
                throw new ArgumentNullException();
            }

            return prices.Select(price => taxFunction(price)).ToArray();
        }
    }
}
