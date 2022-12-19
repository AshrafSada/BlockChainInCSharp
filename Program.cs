using static System.Console;

namespace BlockChainInCSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        string minerName = "Ashraf";

        ChainFactory chainFactory = new ChainFactory(minerName);
        chainFactory.AddBlock("Payment from Ashraf to PC Zone of 13.75 BTC for new Keyboard");
        chainFactory.AddBlock("Payment from Ashraf to name cheap (Domain Registration Service) of 1.96 Ether for domain registration");

        WriteLine("How our Blockchain looks like:");

        int blockNo = 0;
        foreach (var item in chainFactory.Blockchain)
        {
            blockNo++;

            WriteLine("************************************");
            WriteLine($"Block No = {blockNo}");
            WriteLine($"Block Hash = {BitConverter.ToString(item.BlockHash)}");
            WriteLine($"Previous Hash = {BitConverter.ToString(item.PrevBlockHash)}");
            WriteLine($"NONCE = {item.Nonce}");
            WriteLine($"Trx-Data = {item.Data}");
            WriteLine("************************************");
        }
    }
}
