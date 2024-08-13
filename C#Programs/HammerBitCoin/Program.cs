namespace HammerBitCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                BitCoinMiner game = new BitCoinMiner();
                game.Play();
                playAgain = BitCoinMiner.GetYesOrNo("Would you like to play again?");
            }
            Console.WriteLine("GoodBye !!!");
        }
    }
}
