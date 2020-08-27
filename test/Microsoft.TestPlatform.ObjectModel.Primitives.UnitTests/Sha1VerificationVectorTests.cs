namespace Microsoft.TestPlatform.ObjectModel.Primitives.UnitTests
{
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System.Linq;
    using System.Text;


    [TestClass]
    public class Sha1VerificationVectorTests
    {
        [TestMethod]
        public void SHA1_TestVectors_EmptyString()
        {
            SHA1_TestVector(
                string.Empty,
                "da39a3ee5e6b4b0d3255bfef95601890afd80709"
            );
        }

        [TestMethod]
        public void SHA1_TestVectors_abc()
        {
            SHA1_TestVector(
                "abc",
                "a9993e364706816aba3e25717850c26c9cd0d89d"
            );
        }

        [TestMethod]
        public void SHA1_TestVectors_448Bits()
        {
            SHA1_TestVector(
                "abcdbcdecdefdefgefghfghighijhijkijkljklmklmnlmnomnopnopq",
                "84983e441c3bd26ebaae4aa1f95129e5e54670f1"
            );
        }

        [TestMethod]
        public void SHA1_TestVectors_896Bits()
        {
            SHA1_TestVector(
                "abcdefghbcdefghicdefghijdefghijkefghijklfghijklmghijklmnhijklmnoijklmnopjklmnopqklmnopqrlmnopqrsmnopqrstnopqrstu",
                "a49b2446a02c645bf419f995b67091253a04a259"
            );
        }

        [TestMethod]
        public void SHA1_TestVectors_1Block()
        {
            SHA1_TestRepetitionVector(
                'a',
                512 / 8,
                "0098ba824b5c16427bd7a1122a5a442a25ec644d"
            );
        }

        [TestMethod]
        public void SHA1_ExtremelyLarge_TestVectors_500k_a()
        {
            SHA1_TestRepetitionVector(
                'a',
                500_000,
                "c3acc310183f238acea1cf5c243c74c11e53ca24"
            );
        }

        [TestMethod]
        public void SHA1_ExtremelyLarge_TestVectors_900k_a()
        {
            SHA1_TestRepetitionVector(
                'a',
                900_000,
                "723bd24ac7c6d439a0b16e27b353c0039e19e73b"
            );
        }

        [TestMethod]
        public void SHA1_ExtremelyLarge_TestVectors_999999_a()
        {
            SHA1_TestRepetitionVector(
                'a',
                999_999,
                "1d67a8a17e4191c700da10ddd6c2dc0176fe911d"
            );
        }

        [TestMethod]
        public void SHA1_ExtremelyLarge_TestVectors_1M_a()
        {
            SHA1_TestRepetitionVector(
                'a',
                1_000_000,
                "34aa973cd4c4daa4f61eeb2bdbad27316534016f"
            );
        }

        [TestMethod]
        public void SHA1_ExtremelyLarge_TestVectors_10M_a()
        {
            SHA1_TestRepetitionVector(
                'a',
                10_000_000,
                "b43859b53b0f90da01951b6ab59cc964f3a8671a"
            );
        }

        private void SHA1_TestVector(string message, string expected)
        {
            var hasher = new Sha1Helper.Sha1Implementation();
            var digest = ToHex(hasher.ComputeHash(UTF8Encoding.UTF8.GetBytes(message)));

            Assert.AreEqual(digest, expected, $"Test vector '{message}' failed!");
        }

        private void SHA1_TestRepetitionVector(char input, int repetition, string expected = null)
        {
            var bytes = new byte[repetition];
            for (int i = 0; i < repetition; i++)
            {
                bytes[i] = (byte)input;
            }

            var hasher = new Sha1Helper.Sha1Implementation();
            var digest = ToHex(hasher.ComputeHash(bytes));

            Assert.AreEqual(digest, expected, $"Test vector '{input}'*{repetition} failed!");
        }

        private static string ToHex(byte[] digest) => string.Concat(digest.Select(i => i.ToString("x2")));
    }
}
