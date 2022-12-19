namespace BlockChainInCSharp;

/// <summary>
/// Implementation of Block Interface
/// </summary>
public class Block
{
    public Block(byte[] blockHash, byte[] prevBlockHash, string data, int nonce)
    {
        BlockHash = blockHash;
        PrevBlockHash = prevBlockHash;
        Nonce = nonce;
        Data = data;
    }

    public byte[] BlockHash { get; }
    public string Data { get; }
    public int Nonce { get; }
    public byte[] PrevBlockHash { get; }
}