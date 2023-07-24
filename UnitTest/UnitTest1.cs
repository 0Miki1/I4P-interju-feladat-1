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
    }
}