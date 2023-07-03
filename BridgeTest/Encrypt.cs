

namespace BridgeTest
{
    public interface IEncryptor
    {
        public void encryptData();
    }

    public class EncAES : IEncryptor
    {
        public void encryptData()
        {
            Console.WriteLine("AES cypher is used");
        }
    }

    public class EncBlowfish : IEncryptor
    {
        public void encryptData()
        {
            Console.WriteLine("Blowfish cypher is used");
        }
    }

    public class Enc3DES : IEncryptor
    {
        public void encryptData()
        {
            Console.WriteLine("3DES cypher is used");
        }
    }
}
