using System;

namespace BridgeTest
{
    public abstract class Message
    {
        public String body { get; set; }
        public String subject { get; set; }

        public IEncryptor encryptor { get; set; }


        public abstract void encrypt();

    }

    public class Email : Message
    {
        public Email() {
            this.body = "EMail body sample";
            this.subject = "Email subject sample";
        }
        public override void encrypt()
        {
            Console.WriteLine("Encrypt a Email");
            encryptor.encryptData();
        }
    }

    public class SystemMessage : Message
    {
        private DateTimeOffset timestamp;

        public SystemMessage()
        {
            this.timestamp = (DateTimeOffset)DateTime.UtcNow;
            this.body = "SystemMessage body sample";
            this.subject = "SystemMessage subject sample";
        }

        public override void encrypt()
        {
            Console.WriteLine("Encrypt a SystemMessage");
            encryptor.encryptData();
        }
    }

    public class MessageList : List<Message>
    {
        //public Message GetBySubject(string subject)
        //{
        //    return this.FirstOrDefault(x => x.subject == subject);
        //}

    }
}
