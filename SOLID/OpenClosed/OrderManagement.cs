namespace OpenClosed
{


    public abstract class CardType
    {
        //Standard,
        //Silver,
        //Gold,
        //Premium
        public abstract decimal GetDiscountedPrice(decimal total);


    }

    public class Standard : CardType
    {
        public override decimal GetDiscountedPrice(decimal total)
        {
            return total * .95m;
        }
    }

    public class Silver : CardType
    {
        public override decimal GetDiscountedPrice(decimal total)
        {
            return total * .9m;
        }
    }

    public class Gold : CardType
    {
        public override decimal GetDiscountedPrice(decimal total)
        {
            return total * .85m;
        }
    }

    public class Premium : CardType
    {
        public override decimal GetDiscountedPrice(decimal total)
        {
            return total * 0.8m;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public CardType CardType { get; set; }
    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public decimal GetTotalPrice(decimal price)
        {
            return Customer.CardType.GetDiscountedPrice(price);
            //switch (Customer.CardType)
            //{
            //    case CardType.Standard:
            //        return price * .95m;
            //    case CardType.Silver:
            //        return price * .9m;
            //    case CardType.Gold:
            //        return price * 0.85m;
            //    case CardType.Premium:
            //        return price * .8M;
            //    default:
            //        return price;
            //}

        }
    }
}
