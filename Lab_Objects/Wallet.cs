namespace Lab_Objects
{
    internal class Wallet
    {
        //Enum for different types of wallets
        public enum WalletType
        {
            BiFold,
            TriFold,
            MoneyClip,
            CardHolder
        }

        public WalletType Type { get; set; }
        public List<Card> Cards { get; set; }

        //Constructor
        public Wallet(WalletType type)
        {
            Type = type;
            Cards = new List<Card>();
        }

        
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        
        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }

    
        public override string ToString()
        {
            return Type.ToString() + " wallet";
        }
    }
}