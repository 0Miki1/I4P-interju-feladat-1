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
            StringAssert.DoesNotMatch("encrypt", enc.EncryptMsg(message, key));
        }

        [Test]
        public void Decrypt()
        {
            string encMessage = "hfnosauzun";
            string key = "abcdefgijkl";

            StringAssert.IsMatch("helloworld", dec.DecrypMsg(encMessage, key));
            StringAssert.DoesNotMatch("decrypt", dec.DecrypMsg(encMessage, key));
        }

        [Test]
        public void TransferCharToCode()
        {
            Assert.IsTrue(0 == GetCharCode('a'));
            Assert.IsFalse(0 == GetCharCode('A'));
            Assert.IsTrue(25 == GetCharCode('z'));
            Assert.IsTrue(4 == GetCharCode('e'));
            Assert.IsFalse(16 == GetCharCode('p'));
            Assert.IsFalse(0 == GetCharCode('@'));
        }

        [Test]
        public void TransferCodeToChar()
        {
            Assert.IsTrue('z' == GetChar(25));
            Assert.IsTrue('a' == GetChar(0));
            Assert.IsTrue('k' == GetChar(10));
            Assert.IsFalse('w' == GetChar(23));
            Assert.IsFalse('@' == GetChar(0));
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