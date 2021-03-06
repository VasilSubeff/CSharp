namespace Monopoly.Cards
{
    using System;
    using System.Collections.Generic;

    public static class ListRandomizer
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public class CardInitializer
    {

        List<ChanceCard> community = new List<ChanceCard>()
        {
            new SpaceCard("Advance to Go (Collect $200)", new Space(), CardType.LuckyCard), // Please enter the start field here when created.
            new ChanceCard("Bank Error In Your Favor – Collect $200", CardType.LuckyCard, 200),
            new ChanceCard("Doctor's Fee – Pay $50 ", CardType.BadLuckCard, 50),
            new SpaceCard("Get Out of Jail Free – This card may be kept until needed, or sold", new Space(), CardType.LuckyCard), // please add Jail Space - if Jail space and lucky card - then you can save.
            new SpaceCard("Go to Jail – Go Directly to Jail", new Space(), CardType.LuckyCard),
            new ChanceCard("Grand Opera Opening – Collect $50", CardType.LuckyCard, 50),
            new ChanceCard("Income Tax refund – Collect $20 ", CardType.LuckyCard, 20),
            new ChanceCard("Life Insurance Matures – Collect $100 ", CardType.LuckyCard, 100),
            new ChanceCard("Pay Hospital $100 ", CardType.BadLuckCard, 100),
            new ChanceCard("Pay School Tax of $150 ", CardType.BadLuckCard, 150),
            new ChanceCard("Receive For Services $25 ", CardType.LuckyCard, 25),
            new ChanceCard("You Have Won Second Prize in a Beauty Contest – Collect $10", CardType.LuckyCard, 10),
            new ChanceCard("You Inherit $100", CardType.LuckyCard, 100),
            new ChanceCard("From Sale of Stock You Get $45", CardType.LuckyCard, 45),
            new ChanceCard("Xmas Fund Matures - Collect $100", CardType.LuckyCard, 100)
        };

        List<ChanceCard> chanceList = new List<ChanceCard>()
        {
            new SpaceCard("Advance to Go (Collect $200)",new Space(), CardType.LuckyCard), // space to be replaced with Start.
            new SpaceCard("Advance to Illinois Ave.", new Space(), CardType.Neutral), // space to be replaced with Illinois Ave
            new SpaceCard("Advance token to nearest Utility. If unowned, you may buy it from the Bank", new Space(), CardType.Neutral),// repalce with nearest utility.
            new SpaceCard("Advance token to the nearest Railroad and pay owner twice the rental to which he/she is otherwise entitled.", new Space(), CardType.BadLuckCard),
            new SpaceCard("Advance to St. Charles Place", new Space(), CardType.Neutral),
            new ChanceCard("Get out of Jail free", CardType.LuckyCard),
            new MoveCard("Go back 3 spaces", CardType.Neutral, 3),
            new SpaceCard("Go directly to Jail", new Space(), CardType.BadLuckCard),
            new SpaceCard("Take a trip to Reading Railroad – if you pass Go collect $200", new Space(), CardType.LuckyCard),
            new SpaceCard("Take a Walk on the Board Walk", new Space(), CardType.Neutral),
            new ChanceCard("Your Building And Loan Matures – Collect $150", CardType.LuckyCard, 150)
       };

        public Queue<ChanceCard> InitializeQueue(List<ChanceCard> list)
        {
            
            list.Shuffle();
            return new Queue<ChanceCard>(list);
        }


    }
}
