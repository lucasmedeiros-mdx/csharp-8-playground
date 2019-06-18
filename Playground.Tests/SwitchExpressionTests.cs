namespace Playground.Tests
{
    internal class Address
    {
        public Address(StateAbbreviation state)
        {
            State = state;
        }

        public StateAbbreviation State { get; }
    }

    enum StateAbbreviation
    {
        FL,
        MN,
        WA,
    }

    class SwitchExpressionTests
    {
        public decimal CurrentSwitch(Address location, decimal salePrice)
        {
            decimal price;
            switch (location.State)
            {
                case StateAbbreviation.WA:
                    price = salePrice * 0.65M;
                    break;
                case StateAbbreviation.MN:
                    price = salePrice * 0.6875M;
                    break;
                case StateAbbreviation.FL:
                    price = salePrice * 0.6M;
                    break;
                default:
                    price = 0M;
                    break;
            }

            return price;
        }


        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location.State switch
            {
                StateAbbreviation.WA => salePrice * 0.65M,
                StateAbbreviation.MN => salePrice * 0.6875M,
                StateAbbreviation.FL => salePrice * 0.6M,
                _ => 0M
            };
    }
}
