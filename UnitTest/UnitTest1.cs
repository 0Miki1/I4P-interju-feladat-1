namespace UnitTest
{
    public class Tests
    {
        private Encrypt enc;
        private Decrypt dec;

        [SetUp]
        public void Setup()
        {
            enc = new Encrypt();
            dec = new Decrypt();
        }

        [Test]
        public void Encryption()
        {
            string message = "helloworld";
            string key = "abcdefgijkl";

            StringAssert.IsMatch("hfnosauzun", enc.EncryptMsg(message, key));
        }
    }
}