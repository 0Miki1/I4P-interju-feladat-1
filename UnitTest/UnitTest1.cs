namespace UnitTest
{
    [TestFixture]
    public class Tests : Transfer
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

        [Test]
        public void Decrypt()
        {
            string encMessage = "hfnosauzun";
            string key = "abcdefgijkl";

            StringAssert.IsMatch("helloworld", dec.DecrypMsg(encMessage, key));
        }

        [Test]
        public void TransferCharToCode()
        {
            char a = 'a';
            int code = 0;

            Assert.IsTrue(code == GetCharCode(a));
        }

        [Test]
        public void TransferCodeToChar()
        {
            int code = 25;
            char z = 'z';

            Assert.IsTrue(z == GetChar(code));
        }

        [Test]
        public void TransferCharToCodeSpace()
        {
            char space = ' ';
            int code = 26;

            Assert.IsTrue(code == GetCharCode(space));
        }

        [Test]
        public void TransferCodeToCharSpace()
        {
            int code = 26;
            char space = ' ';

            Assert.IsTrue(space == GetChar(code));
        }

        [Test]
        public void MsgFormatString()
        {
            string goodFormat = "helloworld";
            string badFormat = "HELLOWORLD1";

            Assert.IsTrue(Program.MsgFormat(goodFormat));
            Assert.IsFalse(Program.MsgFormat(badFormat));
        }
    }
}