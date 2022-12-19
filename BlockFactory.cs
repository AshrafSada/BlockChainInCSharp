using System.Security.Cryptography;
using System.Text;

namespace BlockChainInCSharp;

public class BlockFactory
{
    private static string genesisBlockData = "GenesisBlock";

    /// <summary>
    /// Generate new Hash for block
    /// </summary>
    /// <param name="blockHash">Previous block hash</param>
    /// <param name="blockData">Block String Data</param>
    /// <param name="nonce">Integer to use once</param>
    /// <returns>New Hash Byte Array</returns>
    public static byte[] CreateHashBlock(byte[] blockHash, string blockData, int nonce)
    {
        string blockHashString = BitConverter.ToString(blockHash);
        string nonceString = nonce.ToString();
        string completeBlock = blockHashString + nonceString + blockData;

        // use any hash algorithm
        byte[] hash = SHA1.HashData(Encoding.ASCII.GetBytes(completeBlock));
        return hash;
    }

    /// <summary>
    /// Genesis block is the first none reference block in the chain
    /// </summary>
    /// <returns>New Block As Genesis Block</returns>
    public static Block CreateGenesisBlock()
    {
        byte[] prevHash = BitConverter.GetBytes(0);
        byte[] blockHash = CreateHashBlock(prevHash, genesisBlockData, 0);

        return new Block(blockHash, prevHash, genesisBlockData, 0);
    }
}