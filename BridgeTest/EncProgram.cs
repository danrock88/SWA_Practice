using BridgeTest;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

class EncProgram {

    static void Main(string[] args)
    {
        //Initialize some messages as examples
        var MessageList = new MessageList();
        MessageList.Add(new Email());
        MessageList.Add(new SystemMessage());

        //Let user chose encryption method
        Console.WriteLine("You have {0} messages stored", MessageList.Count());
        Console.WriteLine("Plese choose an encryption method: \n" +
            "[1] AES \n" +
            "[2] Blowfish \n" +
            "[3] 3DES \n");
        string input = "0";
        input = Console.ReadLine();
        int inputInteger = Convert.ToInt32(input);

        IEncryptor AES = new EncAES();
        IEncryptor Blowfish = new EncBlowfish();
        IEncryptor DES = new Enc3DES();

        
        foreach (Message mes in MessageList)
        {
            switch (inputInteger)
            {
                case 1:
                    mes.encryptor = AES;
                    break;
                case 2:
                    mes.encryptor = Blowfish;
                    break;
                case 3:
                    mes.encryptor = DES;
                    break;
                default:
                    Console.WriteLine("No encryption method chosen. Aborted");
                    System.Environment.Exit(0);
                    break;
            }
            mes.encrypt();
        }
        
        Console.WriteLine("All messages encrypted");

    }



}


