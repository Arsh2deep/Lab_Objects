using static Lab_Objects.Wallet;

namespace Lab_Objects
{
    internal class WalletStore
    {
        private List<Wallet> _stock; 

        //Constructor
        public WalletStore()
        {
            _stock = new List<Wallet>();
        }

        //Add wallet 
        public void AddWallet(Wallet wallet)
        {
            _stock.Add(wallet);
        }

        //Remove wallet
        public void RemoveWallet(Wallet wallet)
        {
            _stock.Remove(wallet);
        }

        //Display current stock
        public void DisplayStock()
        {
            Console.WriteLine("Current stock of wallets:");
            foreach (Wallet wallet in _stock)
            {
                Console.WriteLine(wallet.ToString());
            }
        }

    }
}