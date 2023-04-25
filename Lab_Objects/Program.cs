using static Lab_Objects.Wallet;

namespace Lab_Objects;
class Program
{
    static void Main(string[] args)
    {
        
        //Instances for some cards
        Card creditCard = new Card("Credit");
        Card debitCard = new Card("Debit");

        //Instances for some wallets
        Wallet biFoldWallet = new Wallet(WalletType.BiFold);
        Wallet triFoldWallet = new Wallet(WalletType.TriFold);
        Wallet moneyClipWallet = new Wallet(WalletType.MoneyClip);

        //Adding cards to the wallets
        biFoldWallet.AddCard(creditCard);
        biFoldWallet.AddCard(debitCard);
        triFoldWallet.AddCard(debitCard);
        moneyClipWallet.AddCard(creditCard);

        //Wallet store
        WalletStore walletStore = new WalletStore();

        //Add wallets to the store's stock
        walletStore.AddWallet(biFoldWallet);
        walletStore.AddWallet(triFoldWallet);
        walletStore.AddWallet(moneyClipWallet);

        //Display the current stock of wallets in the store
        walletStore.DisplayStock();

    }
}

