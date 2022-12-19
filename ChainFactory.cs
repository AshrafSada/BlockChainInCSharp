namespace BlockChainInCSharp;

/// <summary>
/// Hold operation of blockchain creation
/// </summary>
public class ChainFactory
{
    private const int REWARD = 6;

    private const int TRANS_LIMIT = 5;

    public ChainFactory(string minerName)
    {
        MinerName = minerName;
        Blockchain = new LinkedList<Block>();
        _ = Blockchain.AddLast(BlockFactory.CreateGenesisBlock());
        Transactions = new List<string>();
    }

    public LinkedList<Block> Blockchain { get; }
    public string? MinerName { get; }
    public List<string>? Transactions { get; }

    public void AddBlock(string blockData)
    {
        byte[] blockHash = BlockFactory.CreateHashBlock(Blockchain.Last!.Value.PrevBlockHash, blockData, 0);
        Block block = new Block(blockHash, Blockchain.Last.Value.BlockHash, blockData, 0);
        _ = Blockchain.AddLast(block);
    }

    public void AddTransactions(string transaction)
    {
        while (Transactions!.Count <= TRANS_LIMIT)
        {
            Transactions.Add(transaction);
            break;
        }
    }

    // TODO: find hash and return block
}
